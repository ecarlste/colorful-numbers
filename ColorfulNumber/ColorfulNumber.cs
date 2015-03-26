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
            int digitCount = stringyNumber.Length;

            // if there are more than 10 digitCount in the number then it cannot be colorful
            if (digitCount > 10)
            {
                return false;
            }

            // if there is a 0 or 1 contained in the number then we also know it can't be colorful
            if (stringyNumber.Contains('0') || stringyNumber.Contains('1'))
            {
                return false;
            }

            // split the string into 1 character elements and then convert the list to a HashSet of ints
            List<char> digitsAsChar = new List<char>(stringyNumber.ToList());
            List<int> digits = digitsAsChar.ConvertAll<int>(x => (int)Char.GetNumericValue(x));
            HashSet<int> products = new HashSet<int>(digits);

            // before continuing we want to know that we found no duplicate products
            int productCount = products.Count;
            if (digitCount != productCount)
            {
                return false;
            }

            // traverse the list using sublist sizes between 2 and n-1 where n is the size of lengh of the original number
            for (int subListSize = 2; subListSize < digitCount; subListSize++)
            {
                // grab every sublist possible in order, of the size subListSize
                for (int subListStart = 0; subListStart < digitCount - subListSize; subListStart++)
                {
                    // take the sublist and compute the product of all the digitCount together
                    int product = 1;
                    foreach (int digit in digits.GetRange(subListStart, subListSize))
                    {
                        product *= digit;
                    }

                    // once we compute the product insert it into the HashSet and check if the HashSet size has changed
                    products.Add(product);
                    if (products.Count == productCount)
                    {
                        return false;
                    }
                    // if we successfully added a product to our HashSet then increment productCount
                    productCount++;
                }
            }

            return true;
        }
    }
}
