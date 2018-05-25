using System;
using System.IO;

namespace TaskDEV7
{
    /// <summary>
    /// Choose command by user
    /// </summary>
    class EntryPoint
    { 
        static void Main(string[] args)
        {
            try
            {
                Storage store = new Storage();
                bool isPerformed = true;
                while(isPerformed)
                {
                    Client client = new Client();
                    bool isDone = true;
                    while(isDone)
                    {
                        Console.WriteLine("Enter 1 - check cars in storage, 2 - to order car, 3 - add new features, 4 - exit from program");
                        string menuKey = Console.ReadLine();
                        switch (menuKey)
                        {
                            case "1":
                                client.SetCommand(new CommandStorage(store));
                                client.PossibleCarsInformation(client.CarsFeatures);
                                break;
                            case "2":
                                client.SetCommand(new CommandStorage(store));
                                client.AddCarForBuying(client.CarsFeatures);
                                break;
                            case "3":
                                isDone = false;
                                break;
                            case "4":
                                isDone = false;
                                isPerformed = false;
                                break;
                            default:
                                Console.WriteLine("Enter correct command");
                                break;
                        }
                    }                    
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
