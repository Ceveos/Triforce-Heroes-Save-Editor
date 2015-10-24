using System;
using System.Linq;

namespace Triforce_Heroes_Save_Editor.Classes
{
    public static class ChecksumCalculator
    {
        /// <summary>
        /// Updates checksum of save file
        /// </summary>
        /// <param name="saveFile">Byte array of save file</param>
        public static void UpdateChecksum(byte[] saveFile)
        {
            Crc32 crc32 = new Crc32();
            uint crc1 = crc32.ComputeChecksum(saveFile.Skip(0x0000).Take(0x1FC).ToArray());
            uint crc2 = crc32.ComputeChecksum(saveFile.Skip(0x0200).Take(0x17FC).ToArray());
            uint crc3 = crc32.ComputeChecksum(saveFile.Skip(0x1A00).Take(0x11FC).ToArray());

            BitConverter.GetBytes(crc1).CopyTo(saveFile, 0x1FC);
            BitConverter.GetBytes(crc2).CopyTo(saveFile, 0x19FC);
            BitConverter.GetBytes(crc3).CopyTo(saveFile, 0x2BFC);
        }

        

    }
}
