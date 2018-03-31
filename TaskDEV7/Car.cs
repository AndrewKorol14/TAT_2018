using System;
using System.Runtime.Serialization;

namespace TaskDEV7
{
    /// <summary>
    /// Describe abstract car of some brand
    /// </summary>
    [DataContract]
    [KnownType(typeof(BMW))]
    [KnownType(typeof(Ford))]
    [KnownType(typeof(Honda))]
    [KnownType(typeof(VAZ))]
    [KnownType(typeof(Tesla))]
    public abstract class Car: Object
    {
        public abstract string Model { get; set; }
        public abstract string BodyStyle { get; set; }
        public abstract string Transmission { get; set; }
        public abstract string Engine { get; set; }
        public abstract string Capacity { get; set; }
        public abstract string Power { get; set; }
        public abstract string Climate { get; set; }
        public abstract string Cabin { get; set; }
    }
}