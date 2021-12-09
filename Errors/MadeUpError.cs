using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.Errors
{
    class MadeUpError : UserError
    {
        public override string UEMessage()
        {
            return "You did some made up mistake. This fired an error!";
        }
    }
}