using System.Text.RegularExpressions;
using UAssetAPI.PropertyTypes.Structs;

namespace SSR_Music_Packer;
public static class Extensions {

    private static Regex DotReg = new Regex("[.]+", RegexOptions.Compiled);

    enum NameType {
        Path,
        Filename
    }

    public static byte[] ToInt32_LE(this byte[] bytearray) {

        while (bytearray.Length < 4) {
            bytearray.Append((byte)0x00);
        }

        return new byte[4] {
            bytearray[3],
            bytearray[2],
            bytearray[1],
            bytearray[0]
        };

    }
    public static byte[] ToInt32(this byte[] bytearray) {

        while (bytearray.Length < 4) {
            bytearray.Append((byte)0x00);
        }

        return new byte[4] {
            bytearray[0],
            bytearray[1],
            bytearray[2],
            bytearray[3]
        };

    }

    public static StructPropertyData SetPreDelayMeasures(this StructPropertyData data, int measures) {
        data.Value[1].RawValue = measures;
        return data;
    }
    public static StructPropertyData SetRetriggerMeasures(this StructPropertyData data, int measures) {
        data.Value[2].RawValue = measures;
        return data;
    }
    public static string TweakFilePath(this string path) {
        return TweakString(path, NameType.Path);
    }
    public static string TweakFileNameInput(this string path) {
        return TweakString(path, NameType.Filename);
    }

    private static string TweakString(string str, NameType type) {
        string _str = str;
        char[] invalid = Path.GetInvalidPathChars().ToArray();
        if (type == NameType.Filename)
            invalid = invalid.Union(Path.GetInvalidFileNameChars()).Union(new char[] { '?', '\\', '/', '\0', ':', '"', '*', '<', '>', '|' }).ToArray();
        foreach (char sep in new char[2] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar }) {
            string[] split = _str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < split.Length; i++) {
                foreach (char inv in invalid) {
                    split[i] = split[i].Replace(inv, '_');
                    split[i] = DotReg.Replace(split[i], ".");
                }
            }
            _str = string.Join(sep, split);
            if (Path.AltDirectorySeparatorChar == Path.DirectorySeparatorChar) return _str;
        }
        return _str;
    }
}
