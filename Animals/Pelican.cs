using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Pelican:Bird
    {
       public int AverageSleepTime { get; set; }
        public Pelican(string name, int age, double weight, int flyingSpeed, string favoriteSong, int averageSleepTime):base(name, age, weight,flyingSpeed)
        {
            AverageSleepTime = averageSleepTime;
        }
        public override string stats()
        {
            return $"Namn: {Name}, Age: {Age}, Weight: {Weight} Flying speed: {FlyingSpeed}, Average Sleeping time: {AverageSleepTime}";
        }
    }

}
