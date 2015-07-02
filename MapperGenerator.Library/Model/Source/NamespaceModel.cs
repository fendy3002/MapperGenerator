using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Model.Source
{
    public class NamespaceModel
    {
        public string Name { get; set; }
        private List<ClassModel> classes = new List<ClassModel>();
        public IEnumerable<ClassModel> Classes
        {
            get { return classes; }
            set { classes = value.ToList(); }
        }
    }
}
