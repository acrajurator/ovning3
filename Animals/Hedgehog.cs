using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Hedgehog : Animal
    {

        public int NumberOfSpikes { get; set; }
        public Hedgehog(string name, int age, double weight, int numberOfSpikes) : base(name, age, weight)
        {
            NumberOfSpikes = numberOfSpikes;
        }
        public override string DoSound()
        {
            return "aarrrrrrrrr!";
        }
        public override string stats()
        {
            return $"Namn: {Name}, Age: {Age}, Weight: {Weight} Number of Spikes: {NumberOfSpikes}";
        }
    }
}
