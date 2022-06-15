using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public static int numberOfCars = 0;
        public static List<Car> StaticCarList = new List<Car>();

        public List<Car> CarList { get; set; } = new List<Car>();
    }
}
