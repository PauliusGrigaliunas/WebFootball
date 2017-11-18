using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    [Serializable()]
    class IsTooShortException: Exception
    {

        public IsTooShortException()
        : base("Team names must be at least 4 charachters long ")
        {
        }

        public IsTooShortException(string message)
        : base("name is too short of " + message + ". Team names must be at least 4 charachters long ")
        {
        }

        public IsTooShortException(string message, Exception inner)
        : base("name is too short of " + message + ". Team names must be at least 4 charachters long ", inner)
        {
        }

        protected IsTooShortException(System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
