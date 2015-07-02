using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Model.Source
{
    public class PropertyModel
    {
        public string Name { get; set; }
        public string TypeName { get; set; }

        public bool HasSetAccess { get; set; }
        public string SetAccessor { get; set; }

        public bool HasGetAccess { get; set; }
        public string GetAccessor { get; set; }

        public string Modifier { get; set; }
    }
}
