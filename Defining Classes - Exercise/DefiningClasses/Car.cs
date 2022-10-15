using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        //public string Model { get; set; }

        //public double FuelAmount { get; set; }

        //public double FuelConsumptionPerKilometer { get; set; }

        //public double TravelledDistance { get; set; }


        //public void CalculateDistance(int amountOfKm)
        //{
        //    var remainingFuel = FuelAmount - (amountOfKm * FuelConsumptionPerKilometer);

        //    if (remainingFuel >= 0)
        //    {
        //        FuelAmount = remainingFuel;

        //        TravelledDistance += amountOfKm;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Insufficient fuel for the drive");
        //    }

        //}

        public Car(string model, Engine engine, Cargo cargo, Tire[] tire)
        {

            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tire;

        }


        public string Model { get; set; }

        public Tire[] Tires { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }











    }
}
