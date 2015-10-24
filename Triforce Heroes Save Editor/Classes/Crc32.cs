using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triforce_Heroes_Save_Editor.Classes
{
    // Credits to http://sanity-free.org/12/crc32_implementation_in_csharp.html
    public class Crc32
    {
        readonly uint[] _table;

        public uint ComputeChecksum(byte[] bytes)
        {
            uint crc = 0xffffffff;
            foreach (byte t in bytes)
            {
                byte index = (byte)(((crc) & 0xff) ^ t);
                crc = ((crc >> 8) ^ _table[index]);
            }
            return ~crc;
        }

        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            return BitConverter.GetBytes(ComputeChecksum(bytes));
        }

        public Crc32()
        {
            const uint poly = 0xEDB88320;
            _table = new uint[256];
            for (uint i = 0; i < _table.Length; ++i)
            {
                uint temp = i;
                for (int j = 8; j > 0; --j)
                {
                    if ((temp & 1) == 1)
                        temp = ((temp >> 1) ^ poly);
                    else
                        temp >>= 1;
                }
                _table[i] = temp;
            }
        }
    }
}
