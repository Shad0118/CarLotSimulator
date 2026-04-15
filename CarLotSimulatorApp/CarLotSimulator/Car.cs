using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }


    public Car()
    {
        
    }
    public Car(int year, string make, string model)
    {
        Year = year;
        Make = make;
        Model = model;
    }

    public void MakeEngineNoise(string noise)
    {
        EngineNoise = noise;
        Console.WriteLine($"{Make} {Model} {Year} engine sounds like {noise}");
    }

    public void MakeHonkNoise(string honknoise)
    {
        HonkNoise = honknoise;
        Console.WriteLine($"{Make} {Model} {Year} honk sounds like  {honknoise}");
    }

    public void DetailsTeller()
    {
        Console.WriteLine($"Car name = {Make} {Model} released at {Year}");
    }
    
}