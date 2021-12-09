using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Swan:Bird
    {

        public bool HasPartner { get; set; }
        public Swan(string name, int age, double weight, int flyingSpeed, bool hasPartner):base(name,age,weight,flyingSpeed)
        {
            HasPartner = hasPartner;
        }
        public override string stats()
        {
            return $"Namn: {Name}, Age: {Age}, Weight: {Weight} Flying speed: {FlyingSpeed}, Has partner: {HasPartner}";
        }
    }
}
