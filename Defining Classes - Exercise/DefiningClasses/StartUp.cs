using System;
using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            //int n = int.Parse(Console.ReadLine());

            //HashSet<Car> cars = new HashSet<Car>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] command = Console.ReadLine().Split().ToArray();

            //    string model = command[0];

            //    int fuelAmount = int.Parse(command[1]);

            //    double fuelConsumptionFor1km = double.Parse(command[2]);

            //    Car car = new Car();
            //    car.Model = model;
            //    car.FuelAmount = fuelAmount;
            //    car.FuelConsumptionPerKilometer = fuelConsumptionFor1km;

            //    cars.Add(car);


            //}

            //while (true)
            //{
            //    string[] command = Console.ReadLine().Split().ToArray();

            //    if (command[0] == "End")
            //    {
            //        break;
            //    }

            //    string carModel = command[1];

            //    int amountOfKm = int.Parse(command[2]);



            //    foreach (var item in cars)
            //    {
            //        if (item.Model == carModel)
            //        {

            //            item.CalculateDistance(amountOfKm);
            //        }
            //    }
            //}

            //foreach (var item in cars)
            //{
            //    Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            //}

            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                string model = command[0];

                int engineSpeed = int.Parse(command[1]);

                int enginePower = int.Parse(command[2]);

                int cargoWeight = int.Parse(command[3]);

                string cargoType = command[4];

                double tire1Pressure = double.Parse(command[5]);

                int tire1Age = int.Parse(command[6]);

                double tire2Pressure = double.Parse(command[7]);

                int tire2Age = int.Parse(command[8]);

                double tire3Pressure = double.Parse(command[9]);

                int tire3Age = int.Parse(command[10]);

                double tire4Pressure = double.Parse(command[11]);

                int tire4Age = int.Parse(command[12]);

                var tires = new Tire[4]
                {
                    new Tire(tire1Pressure, tire1Age),
                    new Tire(tire2Pressure, tire2Age),
                    new Tire(tire3Pressure, tire4Age),
                    new Tire(tire4Pressure, tire4Age),

                };

                var engine = new Engine(engineSpeed, enginePower);

                var cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string word = Console.ReadLine();

            if (word == "fragile")
            {
                int index = -1;

                for (int i = 0; i < cars.Count; i++)
                {
                    var fcar = cars[i];

                    var dcar = fcar.Tires[i].Pressure;

                    if (dcar < 1)
                    {
                        index = i;
                        break;
                    }

                   

                }


                var specialCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires[index].Pressure < 1);

                foreach (var item in specialCars)
                {
                    Console.WriteLine(item.Model);
                }




            }

            else
            {
                var specialCars = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250);

                foreach (var item in specialCars)
                {
                    Console.WriteLine(item.Model);
                }
            }


        }
    }
}
