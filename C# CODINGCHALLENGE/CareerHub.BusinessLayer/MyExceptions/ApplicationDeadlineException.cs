using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exceptions/DatabaseConnectionException.cs
using System;

namespace JobBoard.Exceptions
{
    public class ApplicationDeadlineException : Exception
    {
        public ApplicationDeadlineException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

