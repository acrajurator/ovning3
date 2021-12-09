using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Dog : Animal
    {

        public string FavoriteFood { get; set; }
        public Dog(string name, int age, double weight, string favoriteFood) : base(name, age, weight)
        {
            FavoriteFood = favoriteFood;
   
        }
        public override string DoSound()
        {
           return "woof!";
        }
        public string ValfriString()
        {
            return "Valfri string!";
        }
        public override string stats()
        {
            return $"Namn: {Name}, Age: {Age}, Weight: {Weight} Favorite food: {FavoriteFood}";
        }
    }
}
