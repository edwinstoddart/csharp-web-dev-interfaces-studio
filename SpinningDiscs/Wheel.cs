using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    class Wheel : IDisk
    {
        public void SpinDisk()
        {
            Console.WriteLine($"The Wheel is spinning with a speed of {Constants.WheelSpinSpeed}");
        }

        public void StopDisk()
        {
            Console.WriteLine("The Wheel slows to a stop...");
        }

        public void EjectDisk()
        {
            StopDisk();
            Console.WriteLine("The Wheel is ready to be removed.");
        }
    }
}
