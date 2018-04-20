using System;

namespace task_19_04
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            СoordinatePair coordinates = new СoordinatePair(rnd.Next(1,10));
            double finalResult = coordinates.DistanceCounter(СoordinatePair.GetDistanceByDecart); ;
            Console.WriteLine("Distance in decart system: " + finalResult);
            finalResult = coordinates.DistanceCounter(СoordinatePair.GetDistanceByOtherMethod); ;
            Console.WriteLine("Distance in other system: " + finalResult);
        }
    }
}