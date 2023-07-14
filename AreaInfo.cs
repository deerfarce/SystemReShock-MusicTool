namespace SSR_Music_Packer_GUI;
public class AreaInfo {
    public string FolderName,
        Cue,
        LayerTable,
        MusicData,
        SoundClass;

    public AreaInfo(string _FolderName, string _Cue, string _LayerTable, string _MusicData, string _SoundClass) {
        this.FolderName = _FolderName;
        this.Cue = _Cue;
        this.LayerTable = _LayerTable;
        this.MusicData = _MusicData;
        this.SoundClass = _SoundClass;
    }
}
