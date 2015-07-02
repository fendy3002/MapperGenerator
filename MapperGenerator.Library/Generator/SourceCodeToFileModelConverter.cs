using MapperGenerator.Library.Model.Source;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Generator
{
    public class SourceCodeToFileModelConverter
    {
        public FileModel Convert(string code)
        {
            FileModel result = new FileModel();
            SyntaxTree tree = CSharpSyntaxTree.ParseText(code);

            var root = (CompilationUnitSyntax)tree.GetRoot();
            result.Imports = GetImport(root);
            result.Namespaces = GetNamespace(root);

            return result;
        }

        private IEnumerable<string> GetImport(CompilationUnitSyntax root)
        {
            List<string> result = new List<string>();

            foreach (var import in root.Usings)
            {
                result.Add(import.Name.ToFullString());
            }

            return result;
        }

        private IEnumerable<NamespaceModel> GetNamespace(CompilationUnitSyntax root)
        {
            List<NamespaceModel> result = new List<NamespaceModel>();

            foreach (NamespaceDeclarationSyntax ns in root.Members.OfType<NamespaceDeclarationSyntax>())
            {
                NamespaceModel model = new NamespaceModel();
                model.Name = ns.Name.ToFullString().Trim();
                model.Classes = GetClass(ns, root);

                result.Add(model);
            }
            if (root.Members.Any(k => k is ClassDeclarationSyntax))
            {
                NamespaceModel blankNs = new NamespaceModel();
                blankNs.Name = "";

                blankNs.Classes = GetClass(root.Members.OfType<ClassDeclarationSyntax>(), root);

                result.Add(blankNs);
            }

            return result;
        }

        private IEnumerable<ClassModel> GetClass(NamespaceDeclarationSyntax ns, CompilationUnitSyntax root)
        {
            return GetClass(ns.DescendantNodes().OfType<ClassDeclarationSyntax>(), root);
        }

        private IEnumerable<ClassModel> GetClass(IEnumerable<ClassDeclarationSyntax> classes, CompilationUnitSyntax root)
        {
            List<ClassModel> result = new List<ClassModel>();

            foreach (ClassDeclarationSyntax cs in classes)
            {
                ClassModel classModel = new ClassModel();
                classModel.Name = cs.Identifier.ToFullString().Trim();
                classModel.Properties = GetProperty(cs, root);

                result.Add(classModel);
            }

            return result;
        }

        private IEnumerable<PropertyModel> GetProperty(ClassDeclarationSyntax cs, CompilationUnitSyntax root)
        {
            List<PropertyModel> result = new List<PropertyModel>();

            foreach (PropertyDeclarationSyntax ps in cs.DescendantNodes().OfType<PropertyDeclarationSyntax>())
            {
                PropertyModel prop = new PropertyModel();
                prop.Name = ps.Identifier.ToFullString().Trim();
                prop.Modifier = ps.Modifiers.ToFullString().Trim();
                prop.TypeName = ps.Type.ToFullString().Trim();
                foreach (var accessor in ps.AccessorList.Accessors)
                {
                    if (accessor.Keyword.ValueText == "set")
                    {
                        prop.HasSetAccess = true;
                        if (accessor.Body != null)
                        {
                            prop.SetAccessor = accessor.Body.ToFullString();
                        }
                    }

                    if (accessor.Keyword.ValueText == "get")
                    {
                        prop.HasGetAccess = true;
                        if (accessor.Body != null)
                        {
                            prop.GetAccessor = accessor.Body.ToFullString();
                        }
                    }
                }

                result.Add(prop);
            }

            return result;
        }
    }
}
