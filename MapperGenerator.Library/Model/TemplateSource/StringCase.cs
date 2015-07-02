using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Model.TemplateSource
{
    public class StringCase
    {
        public string UnderscoreUpperCase = "";
        public string UnderscoreLowerCase = "";
        public string CamelCase = "";
        public string PascalCase = "";
        public string SentenceCase = "";

        public override string ToString()
        {
            return this.PascalCase;
        }
    }
}
