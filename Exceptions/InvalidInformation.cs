using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class InvalidInformation: ApplicationException
    {
        public InvalidInformation(string message = "Invalid information"): base(message)
        {

        }
    }
}
