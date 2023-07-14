using Newtonsoft.Json;
using SSR_Music_Packer;

namespace SSR_Music_Packer_GUI;


public class AreaMusicData {
    public string InputMusic_Intro_FileName { get; set; } = "";
    public string InputMusic_Main_FileName { get; set; } = "";

    public int PreDelayMeasures = 0,
        PostDelayMeasures = 0;
    public float Volume = AssetEditor.DEFAULT_VOLUME;
    public double BPM = 0d;
    public int IntroMeasures = 0;
    public int MainMeasures = 0;

    public void ClearFileNames() {
        InputMusic_Intro_FileName = "";
        InputMusic_Main_FileName = "";
    }

    [JsonConstructor]
    public AreaMusicData(string _InputMusic_Main_FileName = "", string _InputMusic_Intro_FileName = "", int _PreDelayMeasures = 0, int _PostDelayMeasures = 0, float _Volume = AssetEditor.DEFAULT_VOLUME, double _BPM = 0d, int _IntroMeasures = 0, int _MainMeasures = 0) {
        this.InputMusic_Intro_FileName = (_InputMusic_Intro_FileName == "" || _InputMusic_Intro_FileName == null) ? "" : Path.Combine(AssetEditor.path_input_Ogg, _InputMusic_Intro_FileName);
        this.InputMusic_Main_FileName = (_InputMusic_Main_FileName == "" || _InputMusic_Main_FileName == null) ? "" : Path.Combine(AssetEditor.path_input_Ogg, _InputMusic_Main_FileName);
        this.PreDelayMeasures = _PreDelayMeasures;
        this.PostDelayMeasures = _PostDelayMeasures;
        this.Volume = _Volume;
        this.BPM = _BPM;
        this.IntroMeasures = _IntroMeasures;
        this.MainMeasures = _MainMeasures;
    }
}
