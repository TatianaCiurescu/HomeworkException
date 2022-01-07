using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
     public class InvalidAge: InvalidInformation
    {
        public InvalidAge(string message= "The age should be a number between 0 and 100"): base(message)
        {

        }
    }
}
