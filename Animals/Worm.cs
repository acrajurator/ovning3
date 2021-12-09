using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Worm : Animal
    {

        public int BodyParts { get; set; }
        public Worm(string name, int age, double weight, int bodyParts) : base(name, age, weight)
        {
            BodyParts = bodyParts;
        }
        public override string DoSound()
        {
            return "ssSsssSss!";
        }
        public override string stats()
        {
            return $"Namn: {Name}, Age: {Age}, Weight: {Weight} Bodyparts: {BodyParts}";
        }
    }
}
