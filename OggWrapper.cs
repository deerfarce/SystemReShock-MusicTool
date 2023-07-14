﻿using SSR_Music_Packer;

namespace SSR_Music_Packer_GUI;
internal class OggWrapper {

    public enum OggType {
        Common,
        IntroMusic,
        OutroMusic1,
        OutroMusic2
    }

    public static byte[] WrapOgg(string file, OggType oggType) {

        byte[][] common_bytes = {
            new byte[24] { 0x00, 0x00, 0x00, 0x00, 0x01, 00, 0x00, 0x00, 0x01, 00, 00, 00, 0x11, 00, 00, 00, 00, 00, 00, 00, 0x48, 00, 00, 00 },
            new byte[8]  { 0x1A, 0x05, 0x00, 0x00, 0x00, 00, 0x00, 0x00 },
            new byte[16] { 0x2A, 0xE7, 0x51, 0x67, 0xBD, 00, 0xDB, 0x48, 0x98, 0x0A, 0xCC, 0x7D, 0xBA, 0x5D, 0xA0, 0xD7 }
        };

        byte[][] intro_bytes = {
            new byte[24] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 00, 00, 00, 0x0B, 00, 00, 00, 00, 00, 00, 00, 0x48, 00, 00, 00 },
            new byte[8]  { 0xAD, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
            new byte[16] { 0x56, 0xCA, 0x59, 0x07, 0x15, 0x40, 0x1D, 0x40, 0xBA, 0xA7, 0xDA, 0x65, 0x04, 0x74, 0xBA, 0x09 }
        };

        byte[][] outro_bytes1 = {
            new byte[24] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 00, 00, 00, 0x0D, 00, 00, 00, 00, 00, 00, 00, 0x48, 00, 00, 00},
            new byte[8]  { 0x71, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
            new byte[16] { 0x69, 0xA6, 0x4E, 0x05, 0x04, 0xC6, 0x71, 0x42, 0x93, 0xE1, 0x5A, 0x85, 0x07, 0xF5, 0x66, 0x1B }
        };

        byte[][] outro_bytes2 = {
            new byte[24] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 00, 00, 00, 0x0D, 00, 00, 00, 00, 00, 00, 00, 0x48, 00, 00, 00},
            new byte[8]  { 0x97, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
            new byte[16] { 0xF2, 0x37, 0x00, 0x2D, 0xFC, 0xE3, 0x65, 0x4E, 0x94, 0xC4, 0xFC, 0xC4, 0x51, 0x3F, 0x6C, 0x3E }
        };

        byte[][] bytemap;
        switch (oggType) {
            case OggType.IntroMusic:
                bytemap = intro_bytes;
                break;
            case OggType.OutroMusic1:
                bytemap = outro_bytes1;
                break;
            case OggType.OutroMusic2:
                bytemap = outro_bytes2;
                break;
            default:
                bytemap = common_bytes;
                break;
        }

        byte[] size = (BitConverter.GetBytes(new FileInfo(file).Length)).ToInt32();
        byte[] ogg = File.ReadAllBytes(file);
        return bytemap[0].Concat(size).Concat(size).Concat(bytemap[1]).Concat(ogg).Concat(bytemap[2]).ToArray();
    }
}
