namespace TaskDEV7
{
    /// <summary>
    /// Describe creator of 'Ford' cars
    /// </summary>
    class FordCreator : Creator
    {
        /// <summary>
        /// Create new car of brand 'Ford'
        /// </summary>
        /// <returns>Car of brand 'Ford'</returns>
        public override Car CreateCar(string model, string bodyStyle, string transmission, string engine, string capacity, 
            string power, string climate, string cabin)
        {
            return new Ford(model, bodyStyle, transmission, engine, capacity, power, climate, cabin);
        }
    }
}