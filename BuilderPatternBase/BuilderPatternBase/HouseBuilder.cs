using System;
namespace BuilderPatternBase
{
    public class HouseBuilder
    {

        private House house;

        public HouseBuilder()
        {
            this.Reset();
        }

        public HouseBuilder Reset()
        {
            house = new House();

            return this;
        }

        public HouseBuilder AddWindows(int windows)
        {
            house.windows = windows;

            return this;
        }

        public HouseBuilder AddDoors(int doors)
        {
            house.doors = doors;

            return this;
        }

        public HouseBuilder AddRooms(int rooms)
        {
            house.rooms = rooms;

            return this;
        }

        public HouseBuilder Floor(int floor)
        {
            house.floor = floor;

            return this;
        }

        public HouseBuilder Garage(bool hasGarage)
        {
            house.hasGarage = hasGarage;

            return this;
        }

        public HouseBuilder Facade(Facade facade)
        {
            house.facade = facade;

            return this;
        }

        public HouseBuilder SiteManagerPhone(String phone)
        {
            house.siteManagerPhone = phone;

            return this;
        }

        public HouseBuilder Material(Material material)
        {
            house.material = material;

            return this;
        }

        public House Build()
        {
            House product = this.house;

            this.Reset();

            return product;
        }
    }
}
