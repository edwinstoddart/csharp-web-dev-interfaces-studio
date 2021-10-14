using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisk
    {
        public DVD(Dictionary<string,string> storedData, int storageCapacity) : base(storedData, storageCapacity) {}

        // TODO: Implement your custom interface.
        public void SpinDisk()
        {
            Console.WriteLine($"The DVD is spinning at a speed of {Constants.DVDSpinSpeed}");
        }

        public void StopDisk()
        {
            Console.WriteLine("The DVD has stopped spinning...");
        }

        public void EjectDisk()
        {
            StopDisk();
            Console.WriteLine("The DVD tray has extended, please remove the DVD.");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
