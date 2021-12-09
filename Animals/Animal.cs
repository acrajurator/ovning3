using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3
{
    abstract class Animal
    {

        public virtual string Name { get; set; }

        public virtual int Age { get; set; }

        public virtual double Weight { get; set; }
        public Animal (string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public abstract string stats();
        public abstract string DoSound();

    }
}
