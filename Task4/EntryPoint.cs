using System;

namespace Task4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            InputDataPerson inputter = new InputDataPerson();
            string key = null;
            while(key != "+")
            {            
                inputter.AddPersons();
                key = Console.ReadLine();
            }
            foreach(Person person in inputter.Persons)
            {
                Console.WriteLine(person);
            }
            PersonInformationCreator personInfo = new PersonInformationCreator();
            double averageAge = personInfo.CountAverageAge(inputter.Persons);
            int oldestAge = personInfo.FindOldestAge(inputter.Persons);
            int youngestAge = personInfo.FindYoungestAge(inputter.Persons);
            Console.WriteLine(youngestAge + "   " + oldestAge + "   " + averageAge);
        }
    }
}