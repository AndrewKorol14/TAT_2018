﻿namespace TaskDEV10
{
    /// <summary>
    /// Create car of certain brand
    /// </summary>
    public class Car
    {
        private string model;
        private int modelNumber;

        public Car(string model, int modelNumber)
        {
            this.model = model;
            this.modelNumber = modelNumber;
        }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int ModelNumber
        {
            get { return modelNumber; }
            set { modelNumber = value; }
        }

        /// <summary>
        /// Get the string for output
        /// </summary>
        /// <returns>String for output</returns>
        public override string ToString()
        {
            return "Model: " + model + " Quantity: " + modelNumber;
        }
    }
}