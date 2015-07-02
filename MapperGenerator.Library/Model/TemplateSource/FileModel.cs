using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MapperGenerator.Library.Model.TemplateSource
{
    [XmlRoot(Namespace = "http://MapperGenerator/Library/Model/TemplateSource")]
    public class FileModel
    {
        [XmlIgnore]
        public MapperGenerator.Library.Model.Source.FileModel FileModelSource = null;
        public List<string> Imports = new List<string>();
        public List<NamespaceModel> Namespaces = new List<NamespaceModel>();
    }
}
