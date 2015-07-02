using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MapperGenerator.Library.Model.TemplateSource
{
    public class EntityModel
    {
        [XmlIgnore]
        public NamespaceModel Namespace = null;
        public StringCase Name = new StringCase();

        [XmlArray]
        public List<PropertyModel> Properties = new List<PropertyModel>();
        public override string ToString()
        {
            return Name.PascalCase;
        }
    }
}
