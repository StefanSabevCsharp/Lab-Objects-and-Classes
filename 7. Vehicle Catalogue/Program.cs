using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Trucks> trucksList = new List<Trucks>();
            List<Cars> carsList = new List<Cars>();

            while (command[0] != "end")
            {
                if (command[0] == "Truck")
                {
                    Trucks truck = new Trucks();
                    truck.Brand = command[1];
                    truck.Model = command[2];
                    truck.Weight = int.Parse(command[3]);

                    trucksList.Add(truck);
                }
                else
                {

                    Cars car = new Cars();
                    car.Brand = command[1];
                    car.Model = command[2];
                    car.HorsePower = int.Parse(command[3]);

                    carsList.Add(car);
                }


                command = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            if (carsList.Any())
            {

                Console.WriteLine("Cars:");
                foreach (var item in carsList.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            if (trucksList.Any())
            {
                Console.WriteLine("Trucks:");
                foreach (var item in trucksList.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }


        }
    }
    public class Trucks
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    //public class Catalog
    //{
    //    List<Trucks> TrucksList { get; set; }
    //    List<Cars> CarsList { get; set; }
    //}
}
