using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Model
{
    public class PropertyTemplate
    {
        public string DataType { get; set; }
        private string template = "            result.$property.Name.PascalCase$ = source.$property.Name.PascalCase$";
        public string Template
        {
            get { return template; }
            set { template = value; }
        }
    }
}
