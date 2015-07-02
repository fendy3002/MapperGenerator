using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Model.Source
{
    public class ClassModel
    {
        public string Name { get; set; }
        private List<PropertyModel> properties = new List<PropertyModel>();
        public IEnumerable<PropertyModel> Properties
        {
            get { return properties; }
            set { properties = value.ToList(); }
        }
    }
}
