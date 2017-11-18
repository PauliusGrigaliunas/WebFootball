using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class IsEqualException : Exception
    {

        public IsEqualException()
        {
        }

        public IsEqualException(string message)
        : base("Team names must be different ")
        {
        }

        public IsEqualException(string message, Exception inner)
        : base("Team names must be different ", inner)
        {
        }
    }
}
