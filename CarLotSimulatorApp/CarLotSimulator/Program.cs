using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            var carOne = new Car();
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}");
            var carTwo = new Car();
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}");
            var carThree = new Car();
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}");
            var carLotOne = new CarLot();
            
            carOne.Make = "Honda";
            carTwo.Make = "BMW";
            carThree.Make = "Jeep";
            
            carOne.Year = 2015;
            carTwo.Year = 2020;
            carThree.Year = 2022;

            carOne.Model = "Civic";
            carTwo.Model = "X series";
            carThree.Model = "Trackhawk";

            carOne.IsDriveable = true;
            carTwo.IsDriveable = true;
            carThree.IsDriveable = true;
            
            carOne.MakeEngineNoise("Vrooom");
            carOne.MakeHonkNoise("Meep Meep");
            
            carTwo.MakeEngineNoise("Roaaaaar");
            carTwo.MakeHonkNoise("Beeeeeep");
            
            carThree.MakeEngineNoise("Whinnnnne");
            carThree.MakeHonkNoise("Hooooooonk");
            
            carLotOne.ParkingLot.Add(carOne);
            carLotOne.ParkingLot.Add(carTwo);
            carLotOne.ParkingLot.Add(carThree);
            
            carLotOne.CheckCars();
            
            

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
