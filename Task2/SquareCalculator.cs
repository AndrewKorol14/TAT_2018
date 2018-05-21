using System;

namespace Task2
{
    /// <summary>
    /// Calculator for finding the square of figure
    /// </summary>
    public class SquareCalculator
    {
        /// <summary>
        /// Calculates the square of rectangle
        /// </summary>
        /// <param name="length">Length</param>
        /// <param name="width">Width</param>
        /// <returns>Square of rectangle</returns>
        public decimal CalcRectangleSquare(int length, int width)
        {
            if(length <= 0 || width <= 0)
            {
                throw new Exception("Negative length or width is unacceptable");
            }
            return (decimal)length * width;
        }
    }
}