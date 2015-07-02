using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Converter
{
    public class PascalToCamelCase
    {
        public string Convert(string pascalString)
        {
            if (string.IsNullOrWhiteSpace(pascalString) || pascalString.Length == 1)
            {
                return pascalString;
            }
            else
            {
                return char.ToLower(pascalString[0]) + pascalString.Substring(1);
            }
        }
    }
}
