using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public static class StringExtensions
    {

        public static string CapitalizeFirst(this string input)
        {
            if(input is not "")
            {
                return char.ToUpper(input[0]) + input.Substring(1);
            }
            else
            {
                return null!;
            }
            
        }
    }
}
