using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Model
{
    public class ConversionParam
    {
        public string ConvertedNamespace { get; set; }
        public string ConvertedClassName { get; set; }
        public string SourceClassName { get; set; }
        public string SourceClassCode { get; set; }
        public Type ClassType { get; set; }
        public SourceStructure Structure { get; set; }

    }
}
