using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Model
{
    public class TemplateRenderModel
    {
        public MapperGenerator.Library.Model.TemplateSource.FileModel FileModel { get; set; }
        public string Result { get; set; }
        public SourceStructure Structure { get; set; }
    }
}
