using MapperGenerator.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Converter
{
    public class PropertyModelRenderer
    {
        public PropertyModelRenderer(SourceStructure sourceStructure)
        {
            this.sourceStructure = sourceStructure;
        }
        SourceStructure sourceStructure = null;
        public string Convert(Model.TemplateSource.PropertyModel source)
        {
            string result = "";
            string templateString = sourceStructure.GetPropertyTemplate(source.TypeName);

            Antlr3.ST.StringTemplate template = new Antlr3.ST.StringTemplate();
            template.Template = templateString;
            template.SetAttribute("property", source);

            result = template.ToString();
            return result;
        }
    }
}
