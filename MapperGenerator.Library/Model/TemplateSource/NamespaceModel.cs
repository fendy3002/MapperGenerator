using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MapperGenerator.Library.Model.TemplateSource
{
    public class NamespaceModel
    {
        [XmlIgnore]
        public FileModel File = null;
        public StringCase Name = new StringCase();
        public List<EntityModel> Entities = new List<EntityModel>();
        public override string ToString()
        {
            return Name.PascalCase;
        }
    }
}
