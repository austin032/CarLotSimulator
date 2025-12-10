using System;
using System.Collections.Generic;
namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot = new List<Car>();
    public static int _numberOfCars;

    public void CheckCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
        }
        
    }
}