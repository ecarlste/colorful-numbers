using System;
using System.Collections;
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
            string stringyNumber = number.ToString();
            int digits = stringyNumber.Length;

            // if there are more than 10 digits in the number then it cannot be colorful
            if (digits > 10)
            {
                return false;
            }

            // if there is a zero contained in the number then we also know it can't be colorful
            if (stringyNumber.Contains('0'))
            {
                return false;
            }

            // split the string into 1 character elements and then convert the list to a HashSet of ints
            List<char> test = new List<char>(stringyNumber.ToList());
            HashSet<int> products = new HashSet<int>(test.ConvertAll<int>(x => (int)x));

            // before continuing we want to know that we found no duplicate products
            if (digits != products.Count)
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}
