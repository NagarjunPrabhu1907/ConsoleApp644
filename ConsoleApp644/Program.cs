using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SimpleProgram
{
    
    class Person
    {
        // Private fields
        private string firstName;
        private string lastName;
        private int age;

        // Public properties with get and set accessors
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age cannot be negative.");
            }
        }

        // Constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Public method
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person person1 = new Person("John", "Doe", 30);

            // Access the properties and methods of the person object
            person1.FirstName = "Jane";
            person1.Age = -25; // This will trigger the age validation message

            // Display the person's information
            person1.DisplayInfo();
        }
    }
}

