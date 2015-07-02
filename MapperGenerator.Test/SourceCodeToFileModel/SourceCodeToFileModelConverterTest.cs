using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MapperGenerator.Library.Model.Source;
using MapperGenerator.Library.Generator;

namespace MapperGenerator.Test.SourceCodeToFileModel
{
    [TestClass]
    public class SourceCodeToFileModelConverterTest
    {
        [TestMethod]
        public void TestNormal()
        {
            string source = @"using System;
            using System.Collections.Generic;
            using System.Text;
            namespace Test.Tester.Testing
            {
                public class Model
                {
                    public string Name { get; set; }
                    public string GetOnlyName { get { return Name; } }
                    public string SetOnlyName { set { Name = value; } }

                    public int Age { get; set; }
                    public Undefined UndefinedProperty { get; set; }
                }
                public class Model2
                {
                    public decimal Number { get; set; }
                }
            }

            namespace Test.Tester.Testing3
            {
                public class Model2
                {
                    public decimal Number2 { get; set; }
                }
            }";

            SourceCodeToFileModelConverter converter = new SourceCodeToFileModelConverter();
            Write(converter.Convert(source));
        }

        [TestMethod]
        public void TestNoNamespace()
        {
            string source = @"using System;
            using System.Collections.Generic;
            using System.Text;

            public class Model
            {
                public string Name { get; set; }
                public string GetOnlyName { get { return Name; } }
                public string SetOnlyName { set { Name = value; } }

                public int Age { get; set; }
                public Undefined UndefinedProperty { get; set; }
            }
            public class Model2
            {
                public decimal Number { get; set; }
            }

            namespace Test.Tester.Testing3
            {
                public class Model2
                {
                    public decimal Number2 { get; set; }
                }
            }";

            SourceCodeToFileModelConverter converter = new SourceCodeToFileModelConverter();
            Write(converter.Convert(source));
        }


        private void Write(FileModel model)
        {
            Console.WriteLine("USING:");
            foreach (string import in model.Imports)
            {
                Console.WriteLine("    " + import);
            }
            Console.WriteLine("NAMESPACES: ");
            foreach (var ns in model.Namespaces)
            {
                Console.WriteLine("    " + ns.Name);
                Console.WriteLine("    CLASSES: ");
                foreach (var cs in ns.Classes)
                {
                    Console.WriteLine("        " + cs.Name);
                    Console.WriteLine("        PROPERTIES:");
                    foreach (var ps in cs.Properties)
                    {
                        Console.WriteLine("            " + 
                            ps.Modifier + " " + 
                            ps.TypeName + " " +
                            ps.Name + " ");

                        Console.WriteLine("                GET ACCESSOR: " + ps.HasGetAccess + " " + ps.GetAccessor);
                        Console.WriteLine("                SET ACCESSOR: " + ps.HasSetAccess + " " + ps.SetAccessor);
                    }
                }
            }
        }
    }
}
