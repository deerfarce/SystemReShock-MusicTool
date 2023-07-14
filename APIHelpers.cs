using System.Numerics;
using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.PropertyTypes.Structs;
using UAssetAPI.UnrealTypes;

namespace SSR_Music_Packer_GUI;
internal class APIHelpers {

    internal static NormalExport AddSoundGroupRow(UAsset asset, NormalExport ex) {
        if (ex["SoundGroup"] != null) return ex;
        BytePropertyData soundGroup = new BytePropertyData(FName.FromString(asset, "SoundGroup"));
        asset.AddNameReference(FString.FromString("ByteProperty"));
        soundGroup.ByteType = BytePropertyType.FName;
        soundGroup.EnumType = FName.FromString(asset, "ESoundGroup");
        soundGroup.EnumValue = FName.FromString(asset, "SOUNDGROUP_Music");
        ex.Data.Add(soundGroup);
        return ex;
    }

    internal static FPackageIndex CreateAudioImport(UAsset asset, string path, string objectname) {
        FPackageIndex packageIndex = asset.AddImport(new Import("/Script/CoreUObject", "Package", FPackageIndex.FromRawIndex(0), path, false, asset));
        return asset.AddImport(new Import("/Script/Engine", "SoundWave", packageIndex, objectname, false, asset));
    }

    internal static void SetBPM(NormalExport export, double BPM) {
        ((FloatPropertyData)export["BPM"]).Value = (float)BPM;
    }

    internal static StructPropertyData CreateNewAudioTrack(UAsset asset, int i, int preDelayMeasures, int retriggerMeasures, FPackageIndex trackIndex, Vector2? requiredCombatIntensityThreshold = null, ShockEnums.EIntensityThreshold requiredExploreIntensityThreshold = ShockEnums.EIntensityThreshold.AlwaysPlay, float chanceToPlay = 1.0f) {
        StructPropertyData track = new StructPropertyData(FName.FromString(asset, "Track" + i), FName.FromString(asset, "STRUCT_MusicCue_Layer"));

        NamePropertyData layername = new NamePropertyData(FName.FromString(asset, "LayerName_17_66FCEF4A474ECD06C6A28588437DF168"));
        layername.Value = FName.FromString(asset, "Track" + i);

        IntPropertyData predelay = new IntPropertyData(FName.FromString(asset, "Pre-delayMeasures_10_D59ECC864E5E6DAC568B9B80542FC90E"));
        predelay.Value = preDelayMeasures;

        IntPropertyData retrigger = new IntPropertyData(FName.FromString(asset, "RetriggerTimemeasures_7_8D5CB8494F18114D3BCEC5A26128009F"));
        retrigger.Value = retriggerMeasures;

        FloatPropertyData chancetoplay = new FloatPropertyData(FName.FromString(asset, "ChanceToPlay_20_0F40EB394488DED038A0BEAF5C8347CA"));
        chancetoplay.Value = chanceToPlay;

        FloatPropertyData volumemulti = new FloatPropertyData(FName.FromString(asset, "VolumeMultiplier_24_6E56106A4A835D0AB84BE6BE0478684E"));
        volumemulti.Value = 1.0f;

        BytePropertyData req_explore = new BytePropertyData(FName.FromString(asset, "RequiredExploreIntensityThreshold_32_9923DD19406C7969677605AEA0480983"));
        req_explore.ByteType = BytePropertyType.FName;
        req_explore.EnumType = FName.FromString(asset, "ENUM_IntensityThresholds");
        req_explore.EnumValue = FName.FromString(asset, "ENUM_IntensityThresholds::" + requiredExploreIntensityThreshold.ToGameString());

        StructPropertyData req_combat = new StructPropertyData(FName.FromString(asset, "RequiredCombatIntensityThreshold_37_F78B22D345DBB4433E973EA8C7596C6E"), FName.FromString(asset, "Vector2D"));
        Vector2DPropertyData v2d = new Vector2DPropertyData();
        if (requiredCombatIntensityThreshold != null) {
            v2d.X = requiredCombatIntensityThreshold.Value.X;
            v2d.Y = requiredCombatIntensityThreshold.Value.Y;
        } else {
            v2d.X = 0f;
            v2d.Y = 1f;
        }
        req_combat.Value.Add(v2d);

        BoolPropertyData shouldfade = new BoolPropertyData(FName.FromString(asset, "bShouldApplyFadeIn_14_D9F131584EF4B6700AEE26A2EA58CA2D"));
        shouldfade.Value = i <= 0;

        ArrayPropertyData segments = new ArrayPropertyData(FName.FromString(asset, "Segments_3_614984A44EF87D6C72DD658F11CAA084"));

        ObjectPropertyData music = new ObjectPropertyData();
        music.Value = trackIndex;

        segments.ArrayType = FName.FromString(asset, "ObjectProperty");
        segments.Value = segments.Value.Append(music).ToArray();

        track.Value.AddRange(new List<PropertyData>() {
            layername,
            predelay,
            retrigger,
            chancetoplay,
            volumemulti,
            req_explore,
            req_combat,
            shouldfade,
            segments
        });

        return track;
    }
}
