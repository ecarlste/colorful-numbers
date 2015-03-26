using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulNumberLibrary
{
    public class ColorfulNumber
    {
        public Boolean IsColorful(long number)
        {
            // if there are more than 10 digits in the number then it cannot be colorful
            if (number.ToString().Length > 10)
            {
                return false;
            }

            // if there is a zero contained in the number then we also know it can't be colorful
            if (number.ToString().Contains('0'))
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}
