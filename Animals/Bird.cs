using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Bird : Animal
    {
        public virtual int FlyingSpeed { get; set; }

        public Bird(string name, int age, double weight, int flyingSpeed):base(name,age,weight)
        {
            FlyingSpeed = flyingSpeed;
        }
        public override string DoSound()
        {
            return "pruup!";
        }


        public override string stats()
        {
            return $"Namn: {Name}, Age: {Age}, Weight: {Weight} Flying speed: {FlyingSpeed}";
        }

    }
}
