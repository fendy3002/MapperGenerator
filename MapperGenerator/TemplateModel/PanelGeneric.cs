using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapperGenerator.Library.Model.TemplateSource;

namespace MapperGenerator.TemplateModel
{
    public partial class PanelGeneric : UserControl
    {
        public PanelGeneric()
        {
            InitializeComponent();
            panelFileModel.Dock = DockStyle.Top;
            panelNamespaceModel.Dock = DockStyle.Top;
            panelEntityModel.Dock = DockStyle.Top;
            panelPropertyModel.Dock = DockStyle.Top;
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
            else if (model is EntityModel)
            {
                panelEntityModel.Visible = true;
                panelEntityModel.SetModel(model as EntityModel);
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
            panelEntityModel.Visible = false;
            panelPropertyModel.Visible = false;
        }
    }
}
