using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    class VinylRecord : BaseDisc, IDisk
    {
        public VinylRecord(Dictionary<string, string> storedData, int storageCapacity) : base(storedData, storageCapacity) {}

        public void SpinDisk()
        {
            Console.WriteLine($"The Vinyl Record is spinning at a speed of {Constants.VinylSpinSpeed}");
        }

        public void StopDisk()
        {
            Console.WriteLine("The Vinyl Record has slowed to a stop...");
        }

        public void EjectDisk()
        {
            Console.WriteLine("You may now remove the Vinyl Record from the platter.");
        }
    }
}
