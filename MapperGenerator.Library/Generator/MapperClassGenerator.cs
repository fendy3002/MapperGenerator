using MapperGenerator.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Generator
{
    public class MapperClassGenerator
    {
        ClassCodeToTypeConverter ClassCodeToTypeConverter = new ClassCodeToTypeConverter();
        TypeToMapperGenerator TypeToMapperGenerator = new TypeToMapperGenerator();
        public string Generate(ConversionParam param)
        {
            string indent = "    ";
            string indent2 = "        ";
            string indent3 = "            ";

            SourceStructure structure = param.Structure;
            StringBuilder builder = new StringBuilder();
            Type convertedType = ClassCodeToTypeConverter.Generate(param);
            param.SourceClassName = convertedType.Name;

            builder.AppendLine(structure.ImportClause);
            builder.AppendLine();
            builder.AppendLine("namespace " + param.ConvertedNamespace);
            builder.AppendLine("{");
            builder.AppendLine(indent + 
                string.Format(
                    structure.ClassDeclarationFormat,
                    structure.SourceObjectName,
                    structure.DestinationObjectName,
                    param.SourceClassName,
                    param.ConvertedClassName
                )
            );
            builder.AppendLine("    {");
            builder.AppendLine(indent2 +
                string.Format(
                    structure.MethodDeclarationFormat,
                    structure.SourceObjectName,
                    structure.DestinationObjectName,
                    param.SourceClassName,
                    param.ConvertedClassName
                )
            );
            builder.AppendLine(indent2 + "{");

            builder.AppendLine(indent3 + 
                string.Format(
                    "{0} {1} = new {0}();",
                    param.ConvertedClassName,
                    structure.DestinationObjectName
                )
            );

            builder.AppendLine(TypeToMapperGenerator.Generate(param, convertedType));

            builder.AppendLine(indent3 +
                string.Format(
                    "return {0};",
                    structure.DestinationObjectName
                )
            );
            builder.AppendLine(indent2 + "}");
            builder.AppendLine("    }");
            builder.AppendLine("}");

            return builder.ToString();
        }
    }
}
