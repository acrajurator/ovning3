using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3
{
    class PersonHandler
    {

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        public void SetFName(Person pers, string fName)
        {
            pers.Fname = fName;
        }
        public void SetLName(Person pers, string lName)
        {
            pers.Lname = lName;
        }
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            var pers = new Person();
            pers.Age = age;
            pers.Height = height;
            pers.Weight = weight;
            pers.Fname = fName;
            pers.Lname = lName;
            return pers;
        }
    }
}
