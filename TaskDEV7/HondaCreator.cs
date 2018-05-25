namespace TaskDEV7
{
    /// <summary>
    /// Describe creator of 'Honda' cars
    /// </summary>
    class HondaCreator : Creator
    {
        /// <summary>
        /// Create new car of brand 'Honda'
        /// </summary>
        /// <returns>Car of brand 'Honda'</returns>
        public override Car CreateCar(string model, string bodyStyle, string transmission, string engine, 
            string capacity, string power, string climate, string cabin)
        {
            return new Honda(model, bodyStyle, transmission, engine, capacity, power, climate, cabin);
        }
    }
}