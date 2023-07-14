using Newtonsoft.Json;
using SSR_Music_Packer;

namespace SSR_Music_Packer_GUI;
public class ProgramPreferences {

    public bool showFullMusicFilePaths,
        exportAsFolders,
        exportSeparately,
        useMFDPatch,
        hideSkippedWarnings;
    public string repakPath;
    public RecentList<string> recents = new();

    [JsonConstructor]
    public ProgramPreferences(bool showFullMusicFilePaths, bool exportAsFolders, bool exportSeparately, string repakPath, RecentList<string> recents, bool hideSkippedWarnings = false, bool useMFDPatch = true) {
        this.showFullMusicFilePaths = showFullMusicFilePaths;
        this.exportAsFolders = exportAsFolders;
        this.exportSeparately = exportSeparately;
        this.repakPath = repakPath.TweakFilePath() ?? "";
        this.useMFDPatch = useMFDPatch;
        this.hideSkippedWarnings = hideSkippedWarnings;
        this.recents = recents ?? new RecentList<string>();
        for (int i = 0; i < this.recents.Count; i++) {
            this.recents[i] = this.recents[i].TweakFilePath();
        }
    }
    public bool HasAllProperties() {
        return repakPath != null;
    }
}
