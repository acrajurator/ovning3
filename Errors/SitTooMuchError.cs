using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Errors
{
    class SitTooMuchError : UserError
    {
        public override string UEMessage()
        {
            return "You have been sitting down too long, take a walk!...Error!";
        }
    }
}