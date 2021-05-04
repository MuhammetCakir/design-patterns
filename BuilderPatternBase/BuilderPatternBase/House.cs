using System;
namespace BuilderPatternBase
{
    public class House
    {
        public int windows;

        public int doors;

        public int walls;

        public bool hasGarage;

        public City city;

        public int price;

        public House() {
            windows = 0;
            doors = 0;
            walls = 0;
            price = 0;
            hasGarage = false;
        }
        
    }
}
