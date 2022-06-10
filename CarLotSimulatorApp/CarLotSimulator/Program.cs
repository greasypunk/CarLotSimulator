using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODONE
            // Create a seperate class file called Car
            // Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            // The methods should take one string parameter: the respective noise property
            // Now that the Car class is created we can instanciate 3 new cars
            // Set the properties for each of the cars
            // Call each of the methods for each car
            // *************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // *************BONUS X 2*************//
            // Create a CarLot class
            // It should have at least one property: a List of cars
            // Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            // At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var myCarLot = new CarLot();
            myCarLot.CarList = new List<Car>();

            var myCar1 = new Car();
            myCarLot.CarList.Add(myCar1);
            myCar1.Make = "Ford";
            myCar1.Model = "Focus";
            myCar1.Year = 2010;
            myCar1.EngineNoise = "jigglejiggle";
            myCar1.HonkNoise = "beep beep";
            myCar1.IsDriveable = true;
            myCar1.MakeEngineNoise();
            myCar1.MakeHonkNoise();

            var myCar2 = new Car() { Make = "ChittyChitty", Model = "BangBang", Year = 1968, EngineNoise = "magical", HonkNoise = "dodododo", IsDriveable = true };
            myCarLot.CarList.Add(myCar2);
            myCar2.MakeEngineNoise();
            myCar2.MakeHonkNoise();

            var myCar3 = new Car("GMC", "Safari", 1997, "call the doctor", "BAHMP", false);
            myCarLot.CarList.Add(myCar3);
            myCar3.MakeEngineNoise();
            myCar3.MakeHonkNoise();

            foreach (var car in myCarLot.CarList)
                Console.WriteLine($"\nYear: {car.Year}, Make: {car.Make}, Model: {car.Model}");

        }
    }
}
