using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IDisk
    {
        void SpinDisk();
        void StopDisk();
        void EjectDisk();
    }
}
