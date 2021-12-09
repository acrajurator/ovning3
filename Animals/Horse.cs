using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Horse : Animal
    {

        public int Price { get; set; }
        public Horse(string name, int age, double weight, int price) : base(name, age, weight)
        {
            Price = price;
        }


        public override string DoSound()
        {
            return "hueheueueu!";
        }
        public override string stats()
        {
            return $"Namn: {Name}, Age: {Age}, Weight: {Weight} Price: {Price}";
        }
    }
}
