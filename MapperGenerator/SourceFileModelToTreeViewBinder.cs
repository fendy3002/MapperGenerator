using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapperGenerator
{
    public class SourceFileModelToTreeViewBinder
    {
        public void Bind(MapperGenerator.Library.Model.Source.FileModel model, Dictionary<TreeNode, object> sourceFileModelMap, TreeView treeFileModel)
        {
            treeFileModel.Nodes.Clear();

            sourceFileModelMap.Clear();
            var fileNode = new TreeNode("File");
            sourceFileModelMap.Add(fileNode, model);

            foreach (var ns in model.Namespaces)
            {
                var nsNode = new TreeNode(ns.Name);
                sourceFileModelMap.Add(nsNode, ns);

                foreach (var cs in ns.Classes)
                {
                    var csNode = new TreeNode(cs.Name);
                    sourceFileModelMap.Add(csNode, cs);

                    foreach (var ps in cs.Properties)
                    {
                        var psNode = new TreeNode(ps.Name);
                        sourceFileModelMap.Add(psNode, ps);

                        csNode.Nodes.Add(psNode);
                    }

                    nsNode.Nodes.Add(csNode);
                }

                fileNode.Nodes.Add(nsNode);
            }
            treeFileModel.Nodes.Add(fileNode);
            treeFileModel.SelectedNode = fileNode;
            treeFileModel.ExpandAll();
        }
    }
}
