using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MapperGenerator.Library.Model.Source
{
    public class FileModel
    {
        private List<string> imports = new List<string>();
        public IEnumerable<string> Imports
        {
            get { return imports; }
            set { imports = value.ToList(); }
        }

        private List<NamespaceModel> namespaces = new List<NamespaceModel>();
        public IEnumerable<NamespaceModel> Namespaces
        {
            get { return namespaces; }
            set { namespaces = value.ToList(); }
        }
    }
}
