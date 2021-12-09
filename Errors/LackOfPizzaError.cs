using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Errors
{
    class LackOfPizzaError : UserError
    {
        public override string UEMessage()
        {
            return "Too long time since last pizza. This fired an Error!";
        }
    }
}