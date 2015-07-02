using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapperGenerator.Library.Model.Source;

namespace MapperGenerator.SourceModel
{
    public partial class PanelGeneric : UserControl
    {
        public PanelGeneric()
        {
            InitializeComponent();
            panelFileModel.Dock = DockStyle.Fill;
            panelNamespaceModel.Dock = DockStyle.Fill;
            panelClassModel.Dock = DockStyle.Fill;
            panelPropertyModel.Dock = DockStyle.Fill;
        }

        public void SetModel(object model)
        {
            HideAll();
            if (model is FileModel)
            {
                panelFileModel.Visible = true;
                panelFileModel.SetModel(model as FileModel);
            }
            else if (model is NamespaceModel)
            {
                panelNamespaceModel.Visible = true;
                panelNamespaceModel.SetModel(model as NamespaceModel);
            }
            else if (model is ClassModel)
            {
                panelClassModel.Visible = true;
                panelClassModel.SetModel(model as ClassModel);
            }
            else if (model is PropertyModel)
            {
                panelPropertyModel.Visible = true;
                panelPropertyModel.SetModel(model as PropertyModel);
            }
        }

        private void HideAll()
        {
            panelFileModel.Visible = false;
            panelNamespaceModel.Visible = false;
            panelClassModel.Visible = false;
            panelPropertyModel.Visible = false;
        }
    }
}
