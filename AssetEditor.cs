using NVorbis;
using SSR_Music_Packer_GUI;
using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.PropertyTypes.Structs;
using UAssetAPI.UnrealTypes;
using static SSR_Music_Packer_GUI.Areas;

namespace SSR_Music_Packer;
internal class AssetEditor {

    const EngineVersion UE_VER = EngineVersion.VER_UE4_27;
    public const float DEFAULT_VOLUME = 0.7f;

    public static Area GetSharedArea(Area area) {
        return musicSharingMap[area];
    }

    public static string path_output_LevelFolder = "";
    public static string path_output_GameRoot = Path.Combine("SystemShock", "Content");
    public static string path_output_folder = Path.Combine(".", "MusicProject_Output");
    public static string path_input_Templates = Path.Combine(".", "assets");
    public static string path_input_Ogg = Path.Combine(".", "Input_Music");

    public static string path_output_BaseMusicPath {
        get { return Path.Combine(path_output_folder, path_output_LevelFolder, path_output_GameRoot, "Sound", "Music"); }
    }
    public static string path_output_BaseSoundSettingsPath {
        get { return Path.Combine(path_output_folder, path_output_LevelFolder, path_output_GameRoot, "Sound", "_SoundSettings"); }
    }
    public static string path_output_BaseSoundClassPath {
        get { return Path.Combine(path_output_BaseSoundSettingsPath, "SoundClass"); }
    }
    public static string path_output_AudioCollectionFolder {
        get { return Path.Combine(path_output_BaseMusicPath, "CustomMusic"); }
    }

    public static string path_virtual_Music = "/Game/Sound/Music/";

    public static Dictionary<Area, AreaMusicData> paths = GetDefaultPaths();

    //Main function that processes all of the music asset stuff
    //Sorry about the mess here
    public static int Run(ProgramPreferences Preferences) {

        if (!Directory.Exists("assets")) {
            MessageBox.Show("The \"assets\" folder could not be found. You may need to redownload this program to obtain it again.", "Cannot Continue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        int completed = 0;

        if (Directory.Exists("MusicProject_Output"))
            Directory.Delete("MusicProject_Output", true);

        path_output_LevelFolder = "";

        if (!Preferences.exportSeparately) {
            Directory.CreateDirectory(path_output_BaseSoundClassPath);
            Directory.CreateDirectory(path_output_BaseMusicPath);
            Directory.CreateDirectory(path_output_AudioCollectionFolder);
        }

        HashSet<string> createdpaths_MusicData = new HashSet<string>();

        //Load up all of the .uasset files
        UAsset asset_Cue = new UAsset(Path.Combine(path_input_Templates, "BP_MusicCue_Elevator.uasset"), UE_VER);
        UAsset asset_MusicData = new UAsset(Path.Combine(path_input_Templates, "Elevator_v1_2.uasset"), UE_VER);
        UAsset asset_SoundClass = new UAsset(Path.Combine(path_input_Templates, GeneralAreaInfo[Area.Elevator].SoundClass + ".uasset"), UE_VER);

        //remove the _2 from the vanilla elevator files
        //asset_MusicData.Exports[0].ObjectName = new FName(asset_MusicData, asset_MusicData.Exports[0].ObjectName.Value.Value.Split("_2")[0]);

        List<Area> notfound = new();
        List<Area> skipped = new();
        List<Area> incompleteTimingInfo = new();

        foreach (Area area in paths.Keys) {

            if (IsSpecialScene(area)) {
                paths[area].InputMusic_Intro_FileName = "";
            }

            int introMeasures = paths[GetSharedArea(area)].IntroMeasures;
            int mainMeasures = paths[GetSharedArea(area)].MainMeasures;
            double BPM = paths[GetSharedArea(area)].BPM;

            bool bHasPredefinedMeasures = ((introMeasures > 0 && paths[area].InputMusic_Intro_FileName != "") || paths[area].InputMusic_Intro_FileName == "") && mainMeasures > 0;
            bool bHasPredefinedBPM = BPM > 0d;

            List<string> InputPaths = new List<string>() {
                paths[area].InputMusic_Intro_FileName,
                paths[area].InputMusic_Main_FileName
            }.Where(x => x != "").ToList();

            //Skip if both input file paths are blank
            if (InputPaths.Count <= 0) {
                skipped.Add(area);
                continue;
            }

            //Skip if measures and bpm are 0 for non-intro scenes
            if (!IsSpecialScene(area) && (!bHasPredefinedMeasures || !bHasPredefinedBPM)) {
                incompleteTimingInfo.Add(area);
                continue;
            }

            //Skip if files given are not found
            bool stop = false;
            for (int i = 0; i < InputPaths.Count; i++) {
                if (!File.Exists(InputPaths[i])) {
                    notfound.Add(area);
                    stop = true;
                    break;
                }
            }
            if (stop) continue;


            //If we're exporting separate files, set the folder names to area names.
            //Add _MultiLevel if this area's music is shared among other areas, or if this
            //area uses another area's music.
            path_output_LevelFolder = (Preferences.exportSeparately ? Enum.GetName(typeof(Area), musicSharingMap[area]) : "") ?? "";
            if (Preferences.exportSeparately && (area != musicSharingMap[area] || Utils.AreaIsSharingMusic(area))) {
                string oldLevelFolder = path_output_LevelFolder;
                path_output_LevelFolder += "_MultiLevel";
                if (Directory.Exists(oldLevelFolder))
                    Directory.Move(oldLevelFolder, path_output_LevelFolder);
            }

            string class_virtual_SoundClass = GeneralAreaInfo[area].SoundClass;
            string path_virtual_SoundClass = "/Game/Sound/_SoundSettings/SoundClass/" + class_virtual_SoundClass;
            string path_virtual_VanillaFolder = path_virtual_Music + GeneralAreaInfo[area].FolderName.Replace("\\", "/") + "/";
            string path_virtual_Full_LayerTable = path_virtual_VanillaFolder + GeneralAreaInfo[area].LayerTable;
            string path_virtual_Full_Cue = path_virtual_VanillaFolder + GeneralAreaInfo[area].Cue;

            //Set volume in the SoundClass asset
            ((FloatPropertyData)(((StructPropertyData)((NormalExport)asset_SoundClass.Exports[0]).Data[0]).Value[0])).Value = paths[area].Volume;

            //Replace some name references in the SoundClass asset
            asset_SoundClass.SetNameReference(1, new FString(path_virtual_SoundClass));
            asset_SoundClass.SetNameReference(12, new FString(class_virtual_SoundClass));

            Directory.CreateDirectory(Path.Combine(path_output_BaseMusicPath, GeneralAreaInfo[area].FolderName));

            //Do special stuff for the Intro music
            if (IsSpecialScene(area)) {
                bool isIntro = area == Area.IntroCutscene;

                //Open asset
                UAsset _IntroMusicData = new UAsset(Path.Combine(path_input_Templates, "Cinematic_Intro_Music_v3.uasset"), UE_VER);

                //Adjust the target output path since the intro is not in the Music folder
                string path = Path.Combine(path_output_BaseMusicPath, (isIntro ? ".." : ""), GeneralAreaInfo[area].FolderName);
                Directory.CreateDirectory(path);

                using (VorbisReader oggdata = new VorbisReader(paths[area].InputMusic_Main_FileName)) {
                    NormalExport ex = (NormalExport)_IntroMusicData.Exports[0];

                    /*
                     * Unused since outro music stuff was removed
                    if (!isIntro) {
                        _IntroMusicData.SetNameReference(0, new FString(path_virtual_VanillaFolder + GeneralAreaInfo[area].MusicData));
                        _IntroMusicData.SetNameReference(3, new FString(GeneralAreaInfo[area].MusicData));
                        _IntroMusicData.AddNameReference(new FString("ObjectProperty"));
                        FPackageIndex soundclass = _IntroMusicData.AddImport(new Import("/Script/CoreUObject", "Package", FPackageIndex.FromRawIndex(0), path_virtual_SoundClass, false, _IntroMusicData));
                        FPackageIndex soundclass_obj = _IntroMusicData.AddImport(new Import("/Script/Engine", "SoundClass", soundclass, class_virtual_SoundClass, false, _IntroMusicData));
                        ObjectPropertyData sndclass = new ObjectPropertyData(FName.FromString(_IntroMusicData, "SoundClassObject"));
                        sndclass.Value = soundclass_obj;
                        ex.Data.Add(sndclass);
                    }*/

                    ((IntPropertyData)ex["NumChannels"]).Value = oggdata.Channels;
                    ((IntPropertyData)ex["SampleRate"]).Value = oggdata.SampleRate;
                    ((FloatPropertyData)ex["Duration"]).Value = (float)oggdata.TotalTime.TotalSeconds;
                    ((FloatPropertyData)ex["TotalSamples"]).Value = (float)oggdata.TotalSamples;

                    //Wrap the input ogg in a header and footer to allow it to be used in-game
                    _IntroMusicData.Exports[0].Extras = OggWrapper.WrapOgg(paths[area].InputMusic_Main_FileName, OggWrapper.OggType.IntroMusic);//OggWrapper.WrapOgg(paths[area].InputMusic_Main_FileName, isIntro ? OggWrapper.OggType.IntroMusic : (area == Area.EndCreditsSong1 ? OggWrapper.OggType.OutroMusic1 : OggWrapper.OggType.OutroMusic2));
                    //Write the music data asset out
                    _IntroMusicData.Write(Path.Combine(path, GeneralAreaInfo[area].MusicData + ".uasset"));
                    ex = null;
                }
                if (!Directory.Exists(path_output_BaseSoundClassPath)) Directory.CreateDirectory(path_output_BaseSoundClassPath);
                //Write soundclass asset out
                asset_SoundClass.Write(Path.Combine(path_output_BaseSoundClassPath, class_virtual_SoundClass + ".uasset"));
                _IntroMusicData = null;
                completed++;
                continue;
            }

            //Open up the music layer asset
            UAsset asset_LayerTable = new UAsset(Path.Combine(path_input_Templates, "DT_MusicLayers_Elevator.uasset"), UE_VER);
            List<StructPropertyData> MusicLayers = ((DataTableExport)asset_LayerTable.Exports[0]).Table.Data;

            //Adjust a ton of name refs for our new area
            asset_LayerTable.SetNameReference(1, new FString(path_virtual_Full_LayerTable));
            asset_LayerTable.SetNameReference(13, new FString(GeneralAreaInfo[area].LayerTable));
            //asset_LayerTable.Imports[3].ObjectName = new FName(asset_LayerTable, asset_LayerTable.Imports[3].ObjectName.Value.Value.Split("_2")[0]);
            //asset_LayerTable.Imports[5].ObjectName = new FName(asset_LayerTable, asset_LayerTable.Imports[5].ObjectName.Value.Value.Split("_2")[0]);

            asset_Cue.SetNameReference(3, new FString(path_virtual_Full_Cue));
            asset_Cue.SetNameReference(4, new FString(path_virtual_Full_LayerTable));
            asset_Cue.SetNameReference(9, new FString(GeneralAreaInfo[area].Cue + "_C"));
            asset_Cue.SetNameReference(18, new FString("Default__" + GeneralAreaInfo[area].Cue + "_C"));
            asset_Cue.SetNameReference(19, new FString(GeneralAreaInfo[area].LayerTable));

            if (Preferences.exportSeparately) {
                Directory.CreateDirectory(path_output_BaseMusicPath);
                Directory.CreateDirectory(path_output_BaseSoundClassPath);
                Directory.CreateDirectory(path_output_AudioCollectionFolder);
            }

            //Is this music data brand new?
            //Used for avoiding some redundant stuff when we come around to areas that share music
            bool MusicDataIsNew = createdpaths_MusicData.Add(GeneralAreaInfo[area].MusicData);

            //Is this only one music track?
            bool bIsSingle = InputPaths.Count == 1;
            //int previousMeasures = 0;

            //For each audio input track...
            //Originally began writing this part with multiple tracks in mind, so it's a bit messy too
            for (int i = 0; i < InputPaths.Count; i++) {

                string tempname = GeneralAreaInfo[area].MusicData + (bIsSingle ? "" : i);
                string temppath = path_virtual_Music + "CustomMusic/" + GeneralAreaInfo[area].MusicData + (bIsSingle ? "" : i);

                if (MusicDataIsNew) {
                    //Replace name refs related to the export name and soundclass name
                    asset_MusicData.SetNameReference(1, new FString(temppath));
                    asset_MusicData.SetNameReference(7, new FString(tempname));
                    asset_MusicData.SetNameReference(0, new FString(path_virtual_SoundClass));
                    asset_MusicData.SetNameReference(13, new FString(class_virtual_SoundClass));
                }

                double currentLength;
                int measures;
                if (i == 0) {
                    if (bIsSingle) measures = mainMeasures;
                    else measures = introMeasures;
                } else {
                    measures = mainMeasures;
                }

                using (VorbisReader oggdata = new VorbisReader(InputPaths[i])) {
                    NormalExport ex = (NormalExport)asset_MusicData.Exports[0];

                    if (MusicDataIsNew) {
                        //Add new property to the music data file containing the SoundGroup
                        APIHelpers.AddSoundGroupRow(asset_MusicData, ex);
                    }

                    ((IntPropertyData)ex["NumChannels"]).Value = oggdata.Channels;
                    ((IntPropertyData)ex["SampleRate"]).Value = oggdata.SampleRate;
                    ((FloatPropertyData)ex["Duration"]).Value = (float)oggdata.TotalTime.TotalSeconds;
                    ((FloatPropertyData)ex["TotalSamples"]).Value = (float)oggdata.TotalSamples;

                    currentLength = oggdata.TotalTime.TotalSeconds;
                    ex = null;
                }

                //if you are going to refactor this into supporting multiple tracks, you need to adjust this section too
                //If this is the second track (should be the main)
                if (i == 1) {
                    //Add a new track to the layer table with the main track info
                    StructPropertyData track = APIHelpers.CreateNewAudioTrack(asset_LayerTable, i, introMeasures + paths[area].PreDelayMeasures, mainMeasures + paths[area].PostDelayMeasures, APIHelpers.CreateAudioImport(asset_LayerTable, temppath, tempname));
                    MusicLayers.Add(track);
                //else if first track (can be either intro, or main if intro is empty)
                } else if (i == 0) {
                    asset_LayerTable.SetNameReference(2, new FString(temppath));
                    asset_LayerTable.SetNameReference(14, new FString(tempname));

                    APIHelpers.SetBPM((NormalExport)asset_Cue.Exports[1], BPM);

                    if (!bIsSingle) {
                        MusicLayers[0].Name = FName.FromString(asset_LayerTable, "Track0");
                        MusicLayers[0].SetPreDelayMeasures(paths[area].PreDelayMeasures);
                        MusicLayers[0].SetRetriggerMeasures(0);
                    } else {
                        MusicLayers[0].SetPreDelayMeasures(paths[area].PreDelayMeasures);
                        MusicLayers[0].SetRetriggerMeasures(measures + paths[area].PostDelayMeasures);
                    }
                }
                //previousMeasures = measures;

                if (MusicDataIsNew) {
                    //wrap ogg data and add its data to the Music Data asset
                    asset_MusicData.Exports[0].Extras = OggWrapper.WrapOgg(InputPaths[i], OggWrapper.OggType.Common);
                    asset_MusicData.Write(Path.Combine(path_output_AudioCollectionFolder, tempname + ".uasset"));
                }
            }
            //write our edited assets out for the current area
            asset_LayerTable.Write(Path.Combine(path_output_BaseMusicPath, GeneralAreaInfo[area].FolderName, GeneralAreaInfo[area].LayerTable + ".uasset"));
            asset_Cue.Write(Path.Combine(path_output_BaseMusicPath, GeneralAreaInfo[area].FolderName, GeneralAreaInfo[area].Cue + ".uasset"));
            asset_SoundClass.Write(Path.Combine(path_output_BaseSoundClassPath, class_virtual_SoundClass + ".uasset"));
            completed++;
        }
        //clean up and notify the user of any skipped items
        if (!Preferences.hideSkippedWarnings)
            NotifyOfSkippedLevels(notfound, skipped, incompleteTimingInfo);
        asset_Cue = null;
        asset_MusicData = null;
        asset_SoundClass = null;
        GC.Collect();
        return completed;
    }

    static void NotifyOfSkippedLevels(List<Area> notfound, List<Area> skipped, List<Area> incompleteTimingInfo) {
        string msg = "";
        bool showmsg = false;
        if (notfound.Count > 0) {
            showmsg = true;
            msg += "Unable to process [" + String.Join(", ", notfound) + "] due to missing files.\n\n";
        }
        if (skipped.Count > 0) {
            showmsg = true;
            msg += "Skipped [" + String.Join(", ", skipped) + "] due to empty paths.\n\n";
        }
        if (incompleteTimingInfo.Count > 0) {
            showmsg = true;
            msg += "Skipped [" + String.Join(", ", incompleteTimingInfo) + "]: all tracks must have a defined BPM and measure count.";
        }
        if (showmsg) MessageBox.Show(msg, "Skipped Levels", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
}
