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

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var carOne = new Car();
            carOne.Year = 2020;
            carOne.Make = "Nissan";
            carOne.Model = "GT-R (R35)";
            carOne.IsDriveable = true;
            carOne.MakeEngineNoise("aggressive twin-turbo V6 growl with a sharp turbo whistle");
            carOne.MakeHonkNoise("beep beep");
            
            var carTwo = new Car()
            {
                Year = 2021, 
                Make = "Ford Mustang", 
                Model = "GT",
                IsDriveable = true
            };
            carTwo.MakeEngineNoise("rumbling V8 roar");
            carTwo.MakeHonkNoise("bold beep");

            var carThree = new Car(2021, "BMW", "M4");
            carThree.MakeEngineNoise("Smooth yet aggressive inline-6 with pops and crackles");
            carThree.MakeHonkNoise("medium-pitched beep");

            var parkingLot = new CarLot();
            parkingLot.Garage.Add(carOne);
            parkingLot.Garage.Add(carTwo);
            parkingLot.Garage.Add(carThree);
            parkingLot.CarDetails();
        }
    }
}
