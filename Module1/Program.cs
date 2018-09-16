﻿using System;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();

            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Milage = 11000;

            var Car2 = new Car("Red",2008);

            int carCount = Car.CountCars();

            Console.WriteLine($"There are {carCount} cars in inventory, right now.");
        }
    }
}
