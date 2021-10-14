using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    class FloppyDisk : DigitalDisc, IDisk
    {
        public FloppyDisk(Dictionary<string, string> storedData, int storageCapacity) : base(storedData, storageCapacity) {}

        public void SpinDisk()
        {
            Console.WriteLine($"The Floppy Disk is spinning at a speed of {Constants.FloppySpinSpeed}.");
        }

        public void StopDisk()
        {
            Console.WriteLine("The Floopy Disk has stopped spinning...");
        }

        public void EjectDisk()
        {
            StopDisk();
            Console.WriteLine("The Floppy Disk has partially ejected. You may pull it out now.");
        }
    }
}
