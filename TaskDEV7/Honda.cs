using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TaskDEV7
{
    /// <summary>
    /// Describe car of brand 'Honda'
    /// </summary>
    [DataContract]
    public class Honda: Car
    {
        [DataMember]
        private string model;
        [DataMember]
        private string bodyStyle;
        [DataMember]
        private string transmission;
        [DataMember]
        private string engine;
        [DataMember]
        private string capacity;
        [DataMember]
        private string power;
        [DataMember]
        private string climate;
        [DataMember]
        private string cabin;

        public Honda(string model, string bodyStyle, string transmission, string engine, string capacity, string power, 
            string climate, string cabin)
        {
            this.model = model;
            this.bodyStyle = bodyStyle;
            this.transmission = transmission;
            this.engine = engine;
            this.capacity = capacity;
            this.power = power;
            this.climate = climate;
            this.cabin = cabin;
        }

        //[DataMember]
        public override string Model
        {
            get { return model; }
            set { model = value; }
        }

        //[DataMember]
        public override string BodyStyle
        {
            get { return bodyStyle; }
            set { bodyStyle = value; }
        }

        //[DataMember]
        public override string Transmission
        {
            get { return transmission; }
            set { transmission = value; }
        }

        //[DataMember]
        public override string Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        //[DataMember]
        public override string Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        [DataMember]
        public override string Power
        {
            get { return power; }
            set { power = value; }
        }

        //[DataMember]
        public override string Climate
        {
            get { return climate; }
            set { climate = value; }
        }

        [DataMember]
        public override string Cabin
        {
            get { return cabin; }
            set { cabin = value; }
        }
    }
}
