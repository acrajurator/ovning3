using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3
{
    class Person
    {
        private int age;
        private string lName;
        private string fName;
        public double Height { get; set; }


        public double Weight { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age needs to be higher than 0");
                }
            }
        }

        public string Fname
        {
            get { return fName; }
            set
            {
                if (1 < value.Length && 11 > value.Length)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("First name needs to be between 2 and 10 signs");
                }
            }
        }

        public string Lname
        {
            get { return lName; }
            set
            {
                if (2 < value.Length && 16 > value.Length)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("Last name needs to be between 3 and 15 signs");
                }
            }
        }

    }
}
