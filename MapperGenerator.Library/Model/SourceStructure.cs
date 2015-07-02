using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Model
{
    public class SourceStructure
    {
        public string Name { get; set; }

        List<PropertyTemplate> propertyTemplate = new List<PropertyTemplate>();
        public List<PropertyTemplate> PropertyTemplate
        {
            get { return propertyTemplate; }
            set { propertyTemplate = value; }
        }

        private string fileTemplate =
            "$file.Imports:{import |using $import$;" + "\r\n" +
            "}$" + "\r\n" +
            "\r\n" +
            "$file.Namespaces:{namespace |$RenderNamespace(namespace)$\r\n}$"
            ;
        public string FileTemplate
        {
            get { return fileTemplate; }
            set { fileTemplate = value; }
        }

        private string namespaceTemplate =
            "namespace $namespace.Name.PascalCase$" + "\r\n" +
            "{" + "\r\n" +
            "$namespace.Entities:{entity |$RenderEntity(entity)$\r\n}$" + "\r\n" +
            "}"
            ;
        public string NamespaceTemplate
        {
            get { return namespaceTemplate; }
            set { namespaceTemplate = value; }
        }

        private string entityTemplate =
            "    public class $entity.Name.PascalCase$" + "\r\n" +
            "    {" + "\r\n" +
            "        public void Do($entity.Name.PascalCase$ source)" + "\r\n" +
            "        {" + "\r\n" +
            "$entity.Properties:{property |$property.Render$\r\n}$" + "\r\n" +
            "        }" + "\r\n" +
            "    }"
            ;
        public string EntityTemplate
        {
            get { return entityTemplate; }
            set { entityTemplate = value; }
        }

        private string defaultPropertyTemplate = "            result.$property.Name.PascalCase$ = source.$property.Name.PascalCase$";
        public string DefaultPropertyTemplate
        {
            get { return defaultPropertyTemplate; }
            set { defaultPropertyTemplate = value; }
        }

        public string GetPropertyTemplate(string propertyType)
        {
            string result = "";
            var template = propertyTemplate.Where(k => k.DataType.Equals(propertyType, StringComparison.OrdinalIgnoreCase));
            if (template.Any())
            {
                result = template.First().Template;
            }
            else
            {
                result = DefaultPropertyTemplate;
            }
            return result;
        }
    }
}
