namespace TaskDEV7
{
    /// <summary>
    /// Describe abstract car creator 
    /// </summary>
    abstract class Creator
    {
        public abstract Car CreateCar(string model, string bodyStyle, string transmission, string engine,string capacity, 
            string power, string climate, string cabin);
    }
}