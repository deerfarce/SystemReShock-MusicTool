using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System.Diagnostics;
using static SSR_Music_Packer.AssetEditor;
using static SSR_Music_Packer_GUI.Areas;
using static SSR_Music_Packer_GUI.MainForm;

namespace SSR_Music_Packer_GUI;
internal class Utils {

    const string REQUIRED_PATCHES_VERSION = "1.0";

    public static void CopyDirectory(string src, string dest, bool recursive) {
        if (Directory.Exists(src)) {

            if (!Directory.Exists(dest)) {
                Directory.CreateDirectory(dest);
            }

            DirectoryInfo dir = new DirectoryInfo(src);

            foreach (FileInfo file in dir.GetFiles()) {
                file.CopyTo(Path.Combine(dest, file.Name));
            }


            if (recursive) {
                foreach (DirectoryInfo subDir in dir.GetDirectories()) {
                    CopyDirectory(subDir.FullName, Path.Combine(dest, subDir.Name), recursive);
                }
            }
        }
    }

    public static void CopyAndDeleteDirectory(string src, string dest, bool recursive) {
        CopyDirectory(src, dest, recursive);
        Directory.Delete(src, true);
    }

    public static double GetLoopSeconds(double BPM, int measures, int beats_per_bar) {
        if (BPM <= 0) return 0d;
        return (beats_per_bar * measures * 60) / BPM;
    }
    public static void CopyPatchToOutput(string assetName, string outpath) {
        Directory.CreateDirectory(outpath);
        File.Copy(Path.Combine(path_input_Templates, assetName + ".uasset"), Path.Combine(outpath, assetName + ".uasset"), true);
        File.Copy(Path.Combine(path_input_Templates, assetName + ".uexp"), Path.Combine(outpath, assetName + ".uexp"), true);
    }
    public static ProcessStartInfo CreateRepakProcessInfo(string file, string dir = "", string modName = "") {
        if (Preferences.exportSeparately && dir == "") {
            throw new ArgumentException("Input directory cannot be null if exporting separately.", "dir");
        }
        ProcessStartInfo procInfo = new ProcessStartInfo();
        procInfo.FileName = Preferences.repakPath;
        if (!Preferences.exportSeparately) {
            string fullpath = Path.GetDirectoryName(file);
            string filename = Path.GetFileNameWithoutExtension(file);
            if (filename == "") filename = "MusicMod";
            if (!filename.EndsWith("_P")) filename += "_P";
            filename += ".pak";
            procInfo.Arguments = "pack --version V11 -v \"" + path_output_folder + "\" \"" + Path.Combine(fullpath, filename) + "\"";
        } else {
            string moduleName = Path.GetFileNameWithoutExtension(dir);
            bool isPatch = moduleName.StartsWith("RequiredPatches_") || moduleName == "MFDPatch";
            procInfo.Arguments = "pack --version V11 -v \"" + dir + "\" \"" + Path.Combine(file, "MusicMod_" + (modName == "" ? "" : (isPatch ? "" : modName + "_")) + moduleName + "_P.pak") + "\"";
        }
        procInfo.CreateNoWindow = true;
        return procInfo;
    }
    static void OpenExplorerAtDir(string dir) {
        Process.Start("explorer", dir);
    }
    public static void SavePreferencesToFile() {
        string save = JsonConvert.SerializeObject(Preferences, Formatting.Indented);
        File.WriteAllTextAsync(Path.Combine(".", SettingsFileName), save);
    }

    public static bool AreaIsSharingMusic(Area area) {
        foreach (Area targetarea in musicSharingMap.Keys) {
            if (targetarea != area && musicSharingMap[targetarea] == area) return true;
        }
        return false;
    }

    public static bool FileIsOgg(string file) {
        if (File.Exists(file)) {
            bool retry = true;
            while (retry) {
                try {
                    using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read)) {
                        retry = false;
                        byte[] buffer = new byte[4];
                        byte[] oggMarker = new byte[4] { 0x4F, 0x67, 0x67, 0x53 };
                        fs.Read(buffer, 0, 4);
                        fs.Close();
                        for (int i = 0; i < buffer.Length; i++) {
                            if (buffer[i] != oggMarker[i]) return false;
                        }
                        return true;
                    }
                } catch (IOException e) {
                    if (MessageBox.Show("Can't open that file - it might be in use by another program.\nTry opening that file again?", "File I/O Exception", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel) {
                        retry = false;
                        return false;
                    }
                }
            }
        }
        return false;
    }

    public static void ExportProject(Form? parentForm = null) {
        bool hasRepak = true;
        if (!Preferences.exportAsFolders && Preferences.repakPath == "") {
            hasRepak = false;
            if (MessageBox.Show("Your project cannot be exported as a .pak file because you " +
                "do not have a path set to repak.exe. You can set it by going to Edit > Preferences." +
                "\n\nWould you like to export this project without packing it anyway?",
                "repak.exe Path Not Set", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
                return;
            }
        }
        string file;
        string modname = "";
        if (!hasRepak || Preferences.exportAsFolders || Preferences.exportSeparately) {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog()) {
                dialog.IsFolderPicker = true;
                NamePrompt.PromptType pt = NamePrompt.PromptType.Pak;
                if (hasRepak && Preferences.exportSeparately && !Preferences.exportAsFolders) {
                    dialog.Title = "Export all .pak files to folder...";
                } else {
                    pt = NamePrompt.PromptType.Folder;
                    dialog.Title = "Export asset files to folder...";
                }
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                    file = dialog.FileName;
                    using (NamePrompt np = new NamePrompt(pt)) {
                        DialogResult result = np.ShowDialog();
                        if (result == DialogResult.OK) modname = np.name;
                        np.Dispose();
                        if (result != DialogResult.OK) return;
                    }
                } else {
                    return;
                }
            }
        } else {
            using (CommonSaveFileDialog dialog = new CommonSaveFileDialog()) {
                dialog.DefaultExtension = "pak";
                dialog.DefaultFileName = "MusicMod_P";
                dialog.Filters.Add(new CommonFileDialogFilter(".pak file", "*.pak"));
                dialog.Title = "Export .pak as file...";
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                    file = dialog.FileName;
                } else {
                    return;
                }
            }
        }
        if (file == "" || file == null) return;

        Dictionary<Area, string[]> tempFields = new();

        foreach (Area area in musicSharingMap.Keys) {
            if (area != musicSharingMap[area]) {
                tempFields[area] = new string[] {
                    GeneralAreaInfo[area].MusicData,
                    paths[area].InputMusic_Intro_FileName,
                    paths[area].InputMusic_Main_FileName
                };
                GeneralAreaInfo[area].MusicData = GeneralAreaInfo[musicSharingMap[area]].MusicData;
                paths[area].InputMusic_Intro_FileName = paths[musicSharingMap[area]].InputMusic_Intro_FileName;
                paths[area].InputMusic_Main_FileName = paths[musicSharingMap[area]].InputMusic_Main_FileName;
            }
        }

        int completed = Run(Preferences);

        if (completed > 0) {

            if (Preferences.useMFDPatch) {
                path_output_LevelFolder = Preferences.exportSeparately ? "MFDPatch" : "";
                CopyPatchToOutput("Mix_OpenMFD", path_output_BaseSoundSettingsPath);
            }

            path_output_LevelFolder = Preferences.exportSeparately ? "RequiredPatches_v" + REQUIRED_PATCHES_VERSION : "";
            CopyPatchToOutput("Music", path_output_BaseSoundClassPath);
            CopyPatchToOutput("DT_LevelMusic", path_output_BaseSoundSettingsPath);

            if (!Preferences.exportAsFolders && Preferences.repakPath != "" && hasRepak) {
                if (!Preferences.exportSeparately) {
                    ProcessStartInfo repak = CreateRepakProcessInfo(file, modName: modname);
                    Process repakProc = Process.Start(repak);
                    repakProc.WaitForExit();
                    repakProc.Close();
                    repakProc.Dispose();
                } else {
                    string[] dirs = Directory.GetDirectories(path_output_folder);
                    Parallel.ForEach(dirs, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, dir => {
                        ProcessStartInfo repak = CreateRepakProcessInfo(file, dir, modName: modname);
                        Process repakProc = Process.Start(repak);
                        repakProc.WaitForExit();
                        repakProc.Close();
                        repakProc.Dispose();
                    });
                }
                Directory.Delete(path_output_folder, true);
            } else if (Preferences.exportAsFolders || (!Preferences.exportAsFolders && Preferences.repakPath == "")) {
                string output = "MusicMod" + (modname == "" ? "" : "_") + modname;
                int tries = 1;
                if (Directory.Exists(Path.Combine(file, output))) {
                    while (Directory.Exists(Path.Combine(file, output + " (" + tries + ")"))) {
                        tries++;
                    }
                    output += " (" + tries + ")";
                }
                CopyAndDeleteDirectory(path_output_folder, Path.Combine(file, output), true);
            }

            if (parentForm != null)
                parentForm.Activate();

            if (MessageBox.Show("Finished! Open output directory?", "Music Pack Created", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                OpenExplorerAtDir(file.EndsWith(".pak") ? Path.GetDirectoryName(file) : file);
        } else {
            MessageBox.Show("There were no tracks to process! Aborted.", "Nothing happened.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        foreach (Area area in tempFields.Keys) {
            GeneralAreaInfo[area].MusicData = tempFields[area][0];
            paths[area].InputMusic_Intro_FileName = tempFields[area][1];
            paths[area].InputMusic_Main_FileName = tempFields[area][2];
        }
    }
}
