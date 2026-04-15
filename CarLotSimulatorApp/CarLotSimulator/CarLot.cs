using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> Garage { get; set; } = new List<Car>();

    public void CarDetails()
    {
        foreach (var car in Garage)
        {
            car.DetailsTeller();
        }
    }
}