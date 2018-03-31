namespace TaskDEV7
{
    /// <summary>
    /// Describe creator of 'VAZ' cars
    /// </summary>
    class VAZCreator : Creator
    {
        /// <summary>
        /// Create new car of brand 'VAZ'
        /// </summary>
        /// <returns>Car of brand 'VAZ'</returns>
        public override Car CreateCar(string model, string bodyStyle, string transmission, string engine, string capacity, 
            string power, string climate, string cabin)
        {
            return new VAZ(model, bodyStyle, transmission, engine, capacity, power, climate, cabin);
        }
    }
}