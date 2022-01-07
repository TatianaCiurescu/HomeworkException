using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class InvalidName: InvalidInformation
    {
        public InvalidName(string message = "The name should have at least 2 characters."): base(message)
        {

        }
    }
}
