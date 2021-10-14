using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisk
    {
        public CD(Dictionary<string, string> storedData, int storageCapacity) : base(storedData, storageCapacity)
        {
        }
        // TODO: Implement your custom interface.
        public void SpinDisk()
        {
            Console.WriteLine($"The CD is spinning at a speed of {Constants.CDSpinSpeed}.");
        }

        public void StopDisk()
        {
            Console.WriteLine("The CD has stopped spinning...");
        }

        public void EjectDisk()
        {
            StopDisk();
            Console.WriteLine("The CD dock is open, please remove the CD.");
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
