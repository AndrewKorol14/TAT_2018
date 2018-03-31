namespace TaskDEV7
{
    /// <summary>
    /// Describe creator of 'Tesla' cars
    /// </summary>
    class TeslaCreator : Creator
    {
        /// <summary>
        /// Create new car of brand 'Tesla'
        /// </summary>
        /// <returns>Car of brand 'Tesla'</returns>
        public override Car CreateCar(string model, string bodyStyle, string transmission, string engine, string capacity, 
            string power, string climate, string cabin)
        {
            return new Tesla(model, bodyStyle, transmission, engine, capacity, power, climate, cabin);
        }
    }
}