using MapperGenerator.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Converter
{
    public class FileModelToTemplateFileModel
    {
        public FileModelToTemplateFileModel(SourceStructure sourceStructure)
        {
            this.sourceStructure = sourceStructure;
            PropertyModelRenderer = new PropertyModelRenderer(sourceStructure);
        }
        SourceStructure sourceStructure = null;
        PropertyModelRenderer PropertyModelRenderer = null;

        PascalToStringCase PascalToStringCase = new PascalToStringCase();
        public Model.TemplateSource.FileModel Convert(Model.Source.FileModel source)
        {
            Model.TemplateSource.FileModel result = new Model.TemplateSource.FileModel();
            result.FileModelSource = source;
            result.Imports = source.Imports.ToList();
            result.Namespaces = source.Namespaces.Select(k =>
            {
                var each = Convert(k);
                each.File = result;
                return each;
            }).ToList();

            return result;
        }

        public Model.TemplateSource.NamespaceModel Convert(Model.Source.NamespaceModel source)
        {
            Model.TemplateSource.NamespaceModel result = new Model.TemplateSource.NamespaceModel();
            result.Name = PascalToStringCase.Convert(source.Name);
            result.Entities = source.Classes.Select(k =>
            {
                var each = Convert(k);
                each.Namespace = result;
                return each;
            }).ToList();

            return result;
        }

        public Model.TemplateSource.EntityModel Convert(Model.Source.ClassModel source)
        {
            Model.TemplateSource.EntityModel result = new Model.TemplateSource.EntityModel();
            result.Name = PascalToStringCase.Convert(source.Name);
            result.Properties = source.Properties.Select(k => {
                var each = Convert(k);
                each.Entity = result;
                return each;
            }).ToList();

            return result;
        }

        public Model.TemplateSource.PropertyModel Convert(Model.Source.PropertyModel source)
        {
            Model.TemplateSource.PropertyModel result = new Model.TemplateSource.PropertyModel();
            result.Name = PascalToStringCase.Convert(source.Name);
            result.TypeName = source.TypeName;

            result.SetAccessor = source.SetAccessor;
            result.GetAccessor = source.GetAccessor;
            result.HasGetAccess = source.HasGetAccess;
            result.HasSetAccess = source.HasSetAccess;
            result.Modifier = source.Modifier;
            result.Render = PropertyModelRenderer.Convert(result);

            return result;
        }
    }
}
