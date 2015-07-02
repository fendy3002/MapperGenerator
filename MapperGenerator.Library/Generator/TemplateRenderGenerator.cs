using MapperGenerator.Library.Model;
using MapperGenerator.Library.Model.TemplateSource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Generator
{
    public class TemplateRenderGenerator
    {
        public TemplateRenderGenerator (SourceStructure sourceStructure)
	    {
            this.sourceStructure = sourceStructure;
	    }
        private SourceStructure sourceStructure;
        public TemplateRenderModel Render(FileModel fileModel)
        {
            TemplateRenderModel result = new TemplateRenderModel();
            result.Structure = sourceStructure;
            result.FileModel = fileModel;

            StringBuilder templateBuilder = new StringBuilder();
            templateBuilder.Append("group Group1;");
            templateBuilder.Append("RenderFile(file) ::= <<");
            templateBuilder.Append(sourceStructure.FileTemplate);
            templateBuilder.Append(">>");
            templateBuilder.Append("RenderNamespace(namespace) ::= <<");
            templateBuilder.Append(sourceStructure.NamespaceTemplate);
            templateBuilder.Append(">>");
            templateBuilder.Append("RenderEntity(entity) ::= <<");
            templateBuilder.Append(sourceStructure.EntityTemplate);
            templateBuilder.Append(">>");


            using (TextReader sr = new StringReader(templateBuilder.ToString()))
            {
                Antlr3.ST.StringTemplateGroup groups = new Antlr3.ST.StringTemplateGroup(sr, typeof(Antlr3.ST.Language.TemplateLexer));

                Antlr3.ST.StringTemplate template = groups.GetInstanceOf("RenderFile");
                template.SetAttribute("file", fileModel);

                result.Result = template.ToString();
            }

            return result;
        }
    }
}
