using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace JobBoard.Exceptions
{
    public class NegativeSalaryException : Exception
    {
        public NegativeSalaryException(string message) : base(message)
        {
        }
    }
}

