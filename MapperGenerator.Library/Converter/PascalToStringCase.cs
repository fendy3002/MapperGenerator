using MapperGenerator.Library.Model.TemplateSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Converter
{
    public class PascalToStringCase
    {
        PascalToCamelCase PascalToCamelCase = new PascalToCamelCase();
        PascalToUnderscore PascalToUnderscore = new PascalToUnderscore();
        PascalToSentenceCase PascalToSentenceCase = new PascalToSentenceCase();
        public StringCase Convert(string pascalCase)
        {
            StringCase result = new StringCase();

            result.PascalCase = pascalCase;
            result.CamelCase = PascalToCamelCase.Convert(pascalCase);
            result.UnderscoreLowerCase = PascalToUnderscore.ConvertLower(pascalCase);
            result.UnderscoreUpperCase = PascalToUnderscore.ConvertUpper(pascalCase);
            result.SentenceCase = PascalToSentenceCase.Convert(pascalCase);

            return result;
        }
    }
}
