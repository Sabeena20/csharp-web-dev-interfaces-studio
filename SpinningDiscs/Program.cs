﻿using System;
namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD cd = new CD("CD example", 700, "CD-R", 350);
            DVD dvd = new DVD("DVD example", 4700, "DVD-R", 1450);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            cd.SpinDisc();
            dvd.SpinDisc();

            cd.ReadData();
            dvd.ReadData();

            Console.WriteLine(cd.WriteData(275));
            Console.WriteLine(dvd.WriteData(8000));

            Console.WriteLine(cd.DiskInfo());
            Console.WriteLine(dvd.DiskInfo());
        }
    }
}