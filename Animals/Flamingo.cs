using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Flamingo:Bird
    {

        public int AmountOfFriends { get; set; }
        public Flamingo(string name, int age, double weight, int flyingSpeed, int amountOfFriends): base(name, age, weight, flyingSpeed)
        {
            AmountOfFriends = amountOfFriends;
        }
        public override string stats()
        {
            return $"Namn: {Name}, Age: {Age}, Weight: {Weight} Flying speed: {FlyingSpeed}, Amount of friends: {AmountOfFriends}";
        }
    }
}
