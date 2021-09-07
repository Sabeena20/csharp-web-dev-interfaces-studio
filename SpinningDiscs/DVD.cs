using System;
namespace SpinningDiscs
{
   
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        public DVD(string name, int maxCapacity, string disktype, int someUsedCapacity) : base(name, maxCapacity, disktype, someUsedCapacity)
        {
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public void ReadData()
        {
            Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }
    }
}