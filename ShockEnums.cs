namespace SSR_Music_Packer_GUI;
internal static class ShockEnums {

    public enum EIntensityThreshold {
        AlwaysPlay,
        Low,
        Med,
        High,
        Extreme
    }

    public static string ToGameString(this EIntensityThreshold intensityThreshold) {
        return "NewEnumerator" + (int)intensityThreshold;
    }
}
