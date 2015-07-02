using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Converter
{
    public class PascalToSentenceCase
    {
        public PascalToSentenceCase()
        {
            this.culture = CultureInfo.InvariantCulture;
        }
        public PascalToSentenceCase(CultureInfo culture)
        {
            this.culture = culture;
        }
        CultureInfo culture;
        public string Convert(string pascalString)
        {
            return culture.TextInfo.ToTitleCase(pascalString);
        }
    }
}
