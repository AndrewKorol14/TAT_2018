using System;
using System.Runtime.Serialization;

namespace TaskDEV8
{
    /// <summary>
    /// Create user
    /// </summary>
    [DataContract]
    public class User
    {
        [DataMember]
        public String firstName;
        [DataMember]
        public String lastName;
        [DataMember]
        public String gender;
        [DataMember]
        public int age;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public User(String firstName, String lastName, String gender, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + ", " + gender + ", " + age;
        }
    }
}