using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Animals
{
    class Wolfman : Wolf, IPerson
    {

        public Wolfman(string name, int age, double weight, string packName ):base(name, age, weight, packName)
        {
        }
        public string Talk()
        {
            return "neee men tjena graben!";
        }
    }
}
