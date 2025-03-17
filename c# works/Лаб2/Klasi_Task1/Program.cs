using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasi_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("qwd", "qwdqw", 123);
            Car car1 = new Car("хендай", "солярис", 1984);
            Car car2 = new Car("порше", "wdqwd", 1444);
            Car car3 = new Car("wefw", "wefwef", 1234);

            car1.Print();
            car2.Print();
            car3.Print();

            Console.ReadKey();
        }

    }

    public class Car
    {
        public string Model { get; set; }

        public string Brand { get; set; }
        public int Year { get; set; }

        public Car(string Brand, string Model, int Year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Year = Year;
        }
        public void Print()
        {
            Console.WriteLine("Task1");
            Console.WriteLine($"Бренд: {Brand} Модель: {Model} Год выпуска: {Year}");
        }

    }

    public class BankAccount
    {
        public string AccountNumber { get; set; }

        public string Balance { get; set; }
    }
}
