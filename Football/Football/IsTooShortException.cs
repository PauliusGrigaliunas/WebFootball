using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class IsTooShortException: Exception
    {

        public IsTooShortException()
        : base("Team name is too short ")
        {
        }



        public IsTooShortException(string message)
        : base("Team name is too short ")
        {
        }

        public IsTooShortException(string message, Exception inner)
        : base("Team name is too short ", inner)
        {
        }
    }
}
