using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class IsEqualException : Exception
    {
        //private string text = "Team names must be different ";
        //public string GetText { get { return text; } }

        public IsEqualException()
        : base("Team names must be different ")
        {
        }



        public IsEqualException(string message)
        : base(message + "Team names must be different ")
        {
        }

        public IsEqualException(string message, Exception inner)
        : base(message + "Team names must be different ", inner)
        {
        }
    }
}
