using BMG.Common.Collection;
using MapperGenerator.Library.Converter;
using MapperGenerator.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Generator
{
    public class TypeToMapperGenerator
    {
        static TypeToMapperGenerator()
        {
            PrimitiveTypes.Add("int", typeof(int).Name);
            PrimitiveTypes.Add("int?", typeof(int).Name);
            PrimitiveTypes.Add("long", typeof(long).Name);
            PrimitiveTypes.Add("long?", typeof(long?).Name);
            PrimitiveTypes.Add("Int64", typeof(long?).Name);
            PrimitiveTypes.Add("Int64?", typeof(long?).Name);
            PrimitiveTypes.Add("object", typeof(object).Name);
        }
        public static SafeDictionary<string, string> PrimitiveTypes = new SafeDictionary<string, string>(new Dictionary<string, string>());

        string indent3 = "            ";
        PascalToUnderscore PascalToUnderscore = new PascalToUnderscore();

        public string Generate(ConversionParam param, Type type)
        {
            if (type == null)
            {
                return "";
            }

            SourceStructure structure = param.Structure;
            StringBuilder builder = new StringBuilder();
            IEnumerable<PropertyInfo> properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo prop in properties)
            {
                bool isFound = false;
                foreach (MapTypeRule typeRule in structure.MapTypeRule)
                {
                    string primitiveType = PrimitiveTypes.Get(typeRule.DataType, typeRule.DataType);
                    if (primitiveType.Equals(prop.PropertyType.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        builder.Append(indent3);
                        builder.AppendFormat(
                            typeRule.Assignment + " = " + typeRule.Conversion,
                            structure.SourceObjectName,
                            structure.DestinationObjectName,
                            param.SourceClassName,
                            param.ConvertedClassName,
                            prop.Name,
                            PascalToUnderscore.Convert(prop.Name)
                            );
                        builder.AppendLine(";");
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    builder.Append(indent3);
                    builder.AppendFormat(
                            structure.DefaultAssignmentRuleConversion + " = " + structure.DefaultRuleConversion,
                            structure.SourceObjectName,
                            structure.DestinationObjectName,
                            param.SourceClassName,
                            param.ConvertedClassName,
                            prop.Name,
                            PascalToUnderscore.Convert(prop.Name)
                            );
                    builder.AppendLine(";");
                }
            }
            return builder.ToString();
        }
    }
}
