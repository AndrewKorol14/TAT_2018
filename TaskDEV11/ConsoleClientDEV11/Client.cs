using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientDEV11
{
    /// <summary>
    /// Creates a client of web service
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            try
            {
                OurEraDayQuantityRef.GetterDaysService webService = new OurEraDayQuantityRef.GetterDaysService();
                Console.WriteLine("Enter the date in format DD/MM/YYYY, DD-MM-YYYY, DD.MM.YYYY, DD Month YYYY...");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Quantity of days of our era: " + webService.GetDayQuantity(date));
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}