using System;

namespace TaskDEV6
{
    /// <summary>
    /// Create command menu for working with products
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                CommandMenuCreator commandMenu = new CommandMenuCreator();
                commandMenu.CommandMenu();
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong symbols in the string of type or name of product");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}