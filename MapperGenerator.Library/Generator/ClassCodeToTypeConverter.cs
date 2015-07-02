using MapperGenerator.Library.Model;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Generator
{
    public class ClassCodeToTypeConverter
    {
        public Type Generate(ConversionParam param)
        {
            Dictionary<string, string> compilerProviderOptions = new Dictionary<string, string>
            {
                {"CompilerVersion", "v4.0"}
            };
            CSharpCodeProvider provider = new CSharpCodeProvider(compilerProviderOptions);
            CompilerParameters compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };
            compilerParams.ReferencedAssemblies.Add("System.Core.dll");
            compilerParams.ReferencedAssemblies.Add("Microsoft.CSharp.dll");

            StringBuilder source = new StringBuilder();
            source.AppendLine(param.SourceClassCode);
            //source.AppendLine("public class TypeReturner{");
            //source.AppendLine("    public Type Get(){");
            //source.AppendLine("        return typeof(" + param.SourceNamespace + "." + param.SourceClassName + ");");
            //source.AppendLine("    }");
            //source.AppendLine("}");

            CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, source.ToString());
            if (results.Errors.Count > 0)
            {
                return null;
            }
            else
            {
                Assembly assembly = results.CompiledAssembly;
                if (assembly.GetTypes().Count() == 0)
                {
                    return null;
                }
                Type classType = assembly.GetTypes().First();
                param.SourceClassName = classType.Name;
                return classType;

                //object compiledObject = assembly.CreateInstance("TypeReturner");
                //MethodInfo compiledMethod = compiledObject.GetType().GetMethod("Get");

                //return (Type)compiledMethod.Invoke(compiledObject, null);
            }
        }
    }
}
