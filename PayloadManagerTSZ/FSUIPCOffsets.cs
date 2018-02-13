using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSUIPC;

namespace PayloadManagerTSZ
{
    class FSUIPCOffsets
    {
        static public Offset<double> grossWeight = new Offset<double>(0x30C0);
        static public Offset<int> zeroFuelWeight = new Offset<int>(0x3BFC);
        static public Offset<byte[]> FuelCenterTankPercentage = new Offset<byte[]>(0x0B74, 4);
    }
}
