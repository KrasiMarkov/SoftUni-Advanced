using System;
using System.Collections.Generic;
using System.Linq;
namespace CarManufacturer
{
    public class StartUp

    {
        static void Main(string[] args)
        {

            List<Tire[]> tires = new List<Tire[]>();

            List<Engine> engines = new List<Engine>();


            List<Car> specialCars = new List<Car>();



            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();



                if (command[0] == "No")
                {
                    break;
                }

                var tire = new Tire[4]
                {
                    new Tire(int.Parse(command[0]), double.Parse(command[1])),
                    new Tire(int.Parse(command[2]), double.Parse(command[3])),
                    new Tire(int.Parse(command[4]), double.Parse(command[5])),
                    new Tire(int.Parse(command[6]), double.Parse(command[7]))
                };


                tires.Add(tire);

            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Engines")
                {
                    break;
                }

                int horsePower = int.Parse(command[0]);

                double cubicCapacity = double.Parse(command[1]);



                var engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);

            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Show")
                {
                    break;
                }

                var make = command[0];

                var model = command[1];

                var year = int.Parse(command[2]);

                var fuelQuantity = double.Parse(command[3]);

                var fuelConsumption = double.Parse(command[4]);

                var engineIndex = int.Parse(command[5]);

                var tiresIndex = int.Parse(command[6]);

                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);

                specialCars.Add(car);
            }

            specialCars = specialCars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10).ToList();


            if (specialCars.Any())
            {
                foreach (var car in specialCars)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }





            

        }
    }
}
