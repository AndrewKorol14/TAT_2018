using System;

namespace Task2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if(args.Length <= 2)
                {
                    throw new Exception("A few arguments for calculating of square");
                }
                int length = Int32.Parse(args[0]);
                int width = Int32.Parse(args[1]);
                SquareCalculator calculator = new SquareCalculator();
                decimal square = calculator.CalcRectangleSquare(length, width);
                Console.WriteLine(square);
            }
            catch(FormatException ex)
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