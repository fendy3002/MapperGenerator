using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapperGenerator
{
    public class TemplateFileModelToTreeViewBinder
    {
        public void Bind(MapperGenerator.Library.Model.TemplateSource.FileModel model, Dictionary<TreeNode, object> templateFileModelMap, TreeView treeFileTemplateModel)
        {
            treeFileTemplateModel.Nodes.Clear();

            templateFileModelMap.Clear();
            var fileNode = new TreeNode("File");
            templateFileModelMap.Add(fileNode, model);

            foreach (var ns in model.Namespaces)
            {
                var nsNode = new TreeNode(ns.Name.PascalCase);
                templateFileModelMap.Add(nsNode, ns);

                foreach (var cs in ns.Entities)
                {
                    var csNode = new TreeNode(cs.Name.PascalCase);
                    templateFileModelMap.Add(csNode, cs);

                    foreach (var ps in cs.Properties)
                    {
                        var psNode = new TreeNode(ps.Name.PascalCase);
                        templateFileModelMap.Add(psNode, ps);

                        csNode.Nodes.Add(psNode);
                    }

                    nsNode.Nodes.Add(csNode);
                }

                fileNode.Nodes.Add(nsNode);
            }
            treeFileTemplateModel.Nodes.Add(fileNode);
            treeFileTemplateModel.SelectedNode = fileNode;
            treeFileTemplateModel.ExpandAll();
        }
    }
}
