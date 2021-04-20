using System;
using System.Collections.Generic;

namespace BuilderPatternBase
{
    class Program
    {
        static void Main(string[] args)
        {

            // Type 1 using builder
            HouseBuilder builder = new HouseBuilder();

            builder.AddRooms(5)
                .AddWindows(4)
                .Floor(3)
                .Facade(Facade.East);

            House apartment = builder.Build();

            // Type 2 using builder
            House bungalow = builder.AddWindows(2)
                .Material(Material.Wood)
                .Build();

            // Type 3 using builder
            House familyHouse = new HouseBuilder()
                .AddWindows(7)
                .AddDoors(3)
                .AddRooms(6)
                .Garage(true)
                .Material(Material.Stone)
                .Build();


            House[] houses =
            {
                apartment,
                bungalow,
                familyHouse
            };

            // Write house attributes to the console.
            int houseCount = 1;
            foreach (House house in houses)
            {
                System.Console.WriteLine("\n\n---- House " + (houseCount++) + " ----");

                System.Console.WriteLine("Windows: " + house.windows);
                System.Console.WriteLine("Doors: " + house.doors);
                System.Console.WriteLine("Rooms: " + house.rooms);
                System.Console.WriteLine("Floor: " + house.floor);
                System.Console.WriteLine("Garage: " + house.hasGarage);
                System.Console.WriteLine("Facade: " + house.facade);
                System.Console.WriteLine("Manager Phone: " + house.siteManagerPhone);
                System.Console.WriteLine("Material: " + house.material);
            }
        }
    }
}
