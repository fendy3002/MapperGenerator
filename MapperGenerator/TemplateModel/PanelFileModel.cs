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
    public delegate void NamespaceDoubleClickHandler(NamespaceModel ns);
    public partial class PanelFileModel : UserControl
    {
        public PanelFileModel()
        {
            InitializeComponent();
        }

        BindingSource bsImports = new BindingSource();
        BindingSource bsNamespace = new BindingSource();

        FileModel model;
        public event NamespaceDoubleClickHandler NamespaceDoubleClick;
        public void SetModel(FileModel model)
        {
            if (model != null)
            {
                this.model = model;
                bsImports.DataSource = model.Imports;
                bsNamespace.DataSource = model.Namespaces;
            }
            else
            {
                this.model = null;
                bsImports.DataSource = null;
                bsNamespace.DataSource = null;
            }

            bsImports.ResetBindings(false);
            bsNamespace.ResetBindings(false);

            listNamespaces.DisplayMember = "Name.PascalCase";
            listImports.DataSource = bsImports;
            listNamespaces.DataSource = bsNamespace;
        }
        
        private void listNamespaces_DoubleClick(object sender, EventArgs e)
        {
            if (NamespaceDoubleClick != null)
            {
                NamespaceDoubleClick(bsNamespace.Current as NamespaceModel);
            }
        }
    }
}
