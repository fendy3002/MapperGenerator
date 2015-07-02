using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MapperGenerator.Library.Model.TemplateSource
{
    public class PropertyModel
    {
        [XmlIgnore]
        public EntityModel Entity = null;

        public StringCase Name = new StringCase();
        [XmlAttribute]
        public string TypeName = "";

        [XmlAttribute]
        public string Render = "";

        [XmlAttribute]
        public bool HasSetAccess = false;
        [XmlAttribute]
        public string SetAccessor = "";

        [XmlAttribute]
        public bool HasGetAccess = false;
        [XmlAttribute]
        public string GetAccessor = "";

        [XmlAttribute]
        public string Modifier = "";
        public override string ToString()
        {
            return Name.PascalCase;
        }
    }
}
