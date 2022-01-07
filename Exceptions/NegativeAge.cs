using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class NegativeAge: InvalidInformation
    {
        public NegativeAge(string message = "The age should be a positive number."): base(message)
        {

        }
    }
}
