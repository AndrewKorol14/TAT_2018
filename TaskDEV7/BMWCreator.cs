namespace TaskDEV7
{
    /// <summary>
    /// Describe creator of 'BMW' cars
    /// </summary>
    class BMWCreator: Creator
    {
        /// <summary>
        /// Create new car of brand 'BMW'
        /// </summary>
        /// <returns>Car of brand 'BMW'</returns>
        public override Car CreateCar(string model, string bodyStyle, string transmission, string engine, string capacity, 
            string power, string climate, string cabin)
        {
            return new BMW(model, bodyStyle, transmission, engine, capacity, power, climate, cabin);
        }
    }
}