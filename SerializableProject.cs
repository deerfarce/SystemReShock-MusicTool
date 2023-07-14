using Newtonsoft.Json;
using static SSR_Music_Packer.AssetEditor;
using static SSR_Music_Packer_GUI.Areas;

namespace SSR_Music_Packer_GUI;
internal class SerializableProject {
    [JsonIgnore]
    public static int SaveVersion = 1;
    public int? save_version;
    public Dictionary<Area, Area> _musicSharingMap;
    public Dictionary<Area, AreaMusicData> _paths;

    [JsonConstructor]
    public SerializableProject(int __version, Dictionary<Area, Area> __musicSharingMap, Dictionary<Area, AreaMusicData> __paths) {
        _musicSharingMap = __musicSharingMap;
        _paths = __paths;
        save_version = __version;
    }

    public void Restore(MainForm? form) {
        paths = _paths;
        musicSharingMap = _musicSharingMap;
        foreach (Area area in Enum.GetValues(typeof(Area))) {
            if (!_paths.ContainsKey(area)) _paths.Add(area, new());
            if (!_musicSharingMap.ContainsKey(area)) _musicSharingMap.Add(area, area);
        }
        if (form != null) {
            form.UpdateWindow();
        }
    }
    /*
    public void RestoreDefault(MainForm form) {
        form.CurrentFileName = "";
        this._paths = GetDefaultPaths();
        this._musicSharingMap = GetDefaultMusicSharingMap();
        this.Restore(form);
    }*/

    public bool HasAllProperties() {
        return save_version != null && _musicSharingMap != null && _paths != null;
    }
}
