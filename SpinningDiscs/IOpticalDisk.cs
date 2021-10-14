using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisk
    {
        void SpinDisk();
        void StopDisk();
        void EjectDisk();
    }
}
