using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Wolf : Animal
    {

        public string PackName { get; set; }
        public Wolf(string name, int age, double weight, string packName) : base(name, age, weight)
        {
            PackName = packName;
        }
        public override string DoSound()
        {
            return "awuuuuuuuuuuu!";
        }
        public override string stats()
        {
            return $"Namn: {Name}, Age: {Age}, Weight: {Weight} Belongs to the pack: {PackName}";
        }
    }
}
