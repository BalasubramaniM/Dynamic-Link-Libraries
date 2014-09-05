using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperClass.Patterns; // Namespace to make use of RegexPattern class

namespace HClasses.HelperClasses
{
    public class RegexPatternClass
    {
        public void RegexPatternFunction()
        {
            RegexPattern.AlphabetPattern;       // Returns "Alphabet Pattern, used to test whether text contains only Alphabets"
            RegexPattern.AlphaNumericPattern;   // Returns "Alphabet Numeric Pattern, used to test whether text contains only Alphabets & Numbers from 0 - 9"
            RegexPattern.EmailPattern;          // Returns "Email Pattern, used to test whether text contains only email key words like @ etc.."
            RegexPattern.NoAlphabetPattern;     // Returns "No Alphabet Pattern, used to test whether text that doesn't contain Alphabets"
            RegexPattern.NumberPattern;         // Returns "Number Pattern, used to test whether text contains only Numbers i.e from 0-9"
        }
    }
}
