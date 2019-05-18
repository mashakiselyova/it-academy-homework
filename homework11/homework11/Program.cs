using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotorcycle[] motorcycles = new IMotorcycle[5];
            motorcycles[0] = new Motorcycle();
            motorcycles[0].CreateMotorcycle();
            motorcycles[0].GetMotorcycle();
            motorcycles[0].GetMotorcycleByID();
            motorcycles[0].UpdateMotorcycle();
            motorcycles[0].DeleteMotorcycle();
            Console.ReadLine();
        }
    }

    interface IMotorcycle
    {
        void CreateMotorcycle();
        void GetMotorcycle();
        void GetMotorcycleByID();
        void UpdateMotorcycle();
        void DeleteMotorcycle();
    }

    class Motorcycle : IMotorcycle
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void CreateMotorcycle()
        {
            Console.WriteLine("Creating a motorcycle:");
            Console.WriteLine("Enter Id of the motorcycle");
            Id = Console.ReadLine();
            Console.WriteLine("Enter a name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter a model");
            Model = Console.ReadLine();
            Console.WriteLine("Enter a year");
            Year = Convert.ToInt32(Console.ReadLine());
        }

        public void DeleteMotorcycle()
        {
            Console.WriteLine("Motorcycle was deleted");
        }

        public void GetMotorcycle()
        {
            Console.WriteLine();
            Console.WriteLine($"The name of the motorcycle - {Name}");
        }

        public void GetMotorcycleByID()
        {
            Console.WriteLine();
            Console.WriteLine($"Id of the motorcycle - {Id}");
        }

        public void UpdateMotorcycle()
        {
            Console.WriteLine("Updating the motorcycle:");
            Console.WriteLine("Enter a new Id of the motorcycle");
            Id = Console.ReadLine();
            Console.WriteLine("Enter a new name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter a new model");
            Model = Console.ReadLine();
            Console.WriteLine("Enter a new year");
            Year = Convert.ToInt32(Console.ReadLine());
        }
    }
}
