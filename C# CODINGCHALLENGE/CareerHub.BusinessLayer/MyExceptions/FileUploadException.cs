using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace JobBoard.Exceptions
{
    public class FileUploadException : Exception
    {
        public FileUploadException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

