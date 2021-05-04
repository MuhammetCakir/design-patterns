using System;
using System.Collections.Generic;

namespace BuilderPatternBase
{
    class Program
    {
        static void Main(string[] args)
        {

            House familyHouse = new HouseBuilder()
                .BuildDoors(3)
                .BuildWindows(1)
                .BuildRoom()
                .BuildGarage()
                .SetCity(City.Istanbul)
                .Build();

            House villageHouse = new HouseBuilder()
                .BuildRoom()
                .SetCity(City.Trabzon)
                .Build();

            House luxuryHouse = new HouseBuilder()
                .BuildDoors(20)
                .BuildWalls(30)
                .BuildWindows(40)
                .BuildGarage()
                .SetCity(City.Izmir)
                .Build();


            House[] houses =
            {
                familyHouse,
                villageHouse,
                luxuryHouse
            };

            // Write house attributes to the console.
            int houseCount = 1;
            foreach (House house in houses)
            {
                System.Console.WriteLine("\n\n---- House " + (houseCount++) + " ----");

                System.Console.WriteLine("Windows: " + house.windows);
                System.Console.WriteLine("Doors: " + house.doors);
                System.Console.WriteLine("Walls: " + house.walls);
                System.Console.WriteLine("Garage: " + house.hasGarage);
                System.Console.WriteLine("City: " + house.city);
                System.Console.WriteLine("Price: " + house.price);
            }
        }
    }
}
