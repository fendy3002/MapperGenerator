using MapperGenerator.Library.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Data
{
    public class StructureLoader
    {
        XmlData<SourceStructure> sourceStructureXml = new XmlData<SourceStructure>();
        public IEnumerable<SourceStructure> Load(AppSetting AppSetting)
        {
            List<SourceStructure> result = new List<SourceStructure>();
            if (Directory.Exists(AppSetting.ProfilePath))
            {
                IEnumerable<string> fileNames = System.IO.Directory.GetFiles(AppSetting.ProfilePath);
                foreach (string fileName in fileNames)
                {
                    sourceStructureXml.FilePath = fileName;
                    result.Add(sourceStructureXml.Load());
                }
            }
            return result;
        }
    }
}
