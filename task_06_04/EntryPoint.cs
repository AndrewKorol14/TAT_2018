using System;

namespace task_06_04
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Car[] carInAutohouse = new Car[4]
            {
                new Car("X6", "BMW"),
                new Car("2103", "VAZ"),
                new Car("Mondeo", "Ford"),
                new Car("2103", "VAZ")
            };
            Autohouse autohouse = new Autohouse(carInAutohouse);
            autohouse.Enumerator = "1";
            Console.WriteLine("Unique models: ");
            foreach(Car car in autohouse)
            {
                Console.WriteLine(car.model + " -- " + car.company);
            }
            autohouse.Enumerator = "2";
            Console.WriteLine("Companies: ");
            foreach (string car in autohouse)
            {
                Console.WriteLine(car);
            }
            autohouse.Enumerator = "aaa";
            Console.WriteLine("All cars: ");
            foreach (Car car in autohouse)
            {
                Console.WriteLine(car.model + " -- " + car.company);
            }
        }
    }
}