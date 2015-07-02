using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Converter
{
    public class PascalToUnderscore
    {
        public string Convert(string pascalString)
        {
            return Convert(pascalString, true);
        }
        public string Convert(string pascalString, bool toLower)
        {
            string underscoreString = Regex.Replace(pascalString,
                "[a-z][A-Z]",
                m =>
                    m.Value[0] + "_" +
                    (toLower ? char.ToLower(m.Value[1]) : char.ToUpper(m.Value[1])));

            return (toLower ? char.ToLower(underscoreString[0]) : underscoreString[0]) + underscoreString.Substring(1);
        }

        public string ConvertLower(string pascalString)
        {
            string underscoreString = Regex.Replace(pascalString,
                "[a-z][A-Z]",
                m =>
                    m.Value[0] + "_" + m.Value[1] );

            return underscoreString.ToLower();
        }
        public string ConvertUpper(string pascalString)
        {
            string underscoreString = Regex.Replace(pascalString,
                "[a-z][A-Z]",
                m =>
                    m.Value[0] + "_" + m.Value[1]);

            return underscoreString.ToUpper();
        }
    }
}
