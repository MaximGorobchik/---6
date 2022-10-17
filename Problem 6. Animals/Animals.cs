using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     abstract public class Animals
    {
        private string name;
        private int age;
        private string gender;

        public Animals(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input: " + value);
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if(value <= 0 || string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentException("Invalid age");
                }
                this.age = value;
            }

        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input: " + value);
                }
                this.gender = value;
            }
        }
     abstract public string ProduceSound();
    }
