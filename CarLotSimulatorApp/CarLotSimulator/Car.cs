using System;

namespace CarLotSimulator;

public class Car
{
    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"A {Make} {Model} engine sounds like this {EngineNoise}.");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"A {Make} {Model} has a honk noise that sounds like {HonkNoise}.");
    }

    public Car()
    {
        CarLot._numberOfCars++;
    }
    
}