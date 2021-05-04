using System;
namespace BuilderPatternBase
{
    public class HouseBuilder
    {

        private House house;

        public HouseBuilder()
        {
            house = new House();
        }

        public HouseBuilder BuildWindows(int windows)
        {
            house.windows += windows;

            house.price += 10;

            return this;
        }

        public HouseBuilder BuildDoors(int doors)
        {
            house.doors += doors;

            house.price += 50;

            return this;
        }

        public HouseBuilder BuildWalls(int walls)
        {
            house.walls += walls;

            house.price += 100;

            return this;
        }

        public HouseBuilder BuildRoom()
        {
            BuildWalls(4);
            BuildDoors(1);
            BuildWindows(2);

            return this;
        }

        public HouseBuilder Destroy()
        {
            house.windows = 0;
            house.walls = 0;
            house.doors = 0;

            return this;
        }

        public HouseBuilder BuildGarage()
        {
            house.hasGarage = true;

            house.price += 5000;

            return this;
        }

        public HouseBuilder SetCity(City city)
        {
            house.city = city;

            switch (city)
            {
                case City.Istanbul:
                    house.price += 100000;
                    break;
                case City.Izmır:
                    house.price += 50000;
                    break;
                case City.Trabzon:
                    house.price += 10000;
                    break;
            }

            return this;
        }

        public House Build()
        { 
            return house;
        }
    }
}
