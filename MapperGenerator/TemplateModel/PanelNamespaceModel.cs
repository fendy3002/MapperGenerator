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
    public delegate void EntityDoubleClickHandler(EntityModel fs);
    public partial class PanelNamespaceModel : UserControl
    {
        public PanelNamespaceModel()
        {
            InitializeComponent();
        }

        BindingSource bsClasses = new BindingSource();

        NamespaceModel model;
        public event EntityDoubleClickHandler EntityDoubleClick;
        public void SetModel(NamespaceModel model)
        {
            this.model = model;
            if (model != null)
            {
                textName.Text = model.Name.PascalCase;
                bsClasses.DataSource = model.Entities;
            }
            else
            {
                textName.Text = "";
                bsClasses.DataSource = null;
            }

            bsClasses.ResetBindings(false);
            listClasses.DisplayMember = "Name.PascalCase";
            listClasses.ValueMember = "Name.PascalCase";
            listClasses.DataSource = bsClasses;
        }
        
        private void listNamespaces_DoubleClick(object sender, EventArgs e)
        {
            if (EntityDoubleClick != null)
            {
                EntityDoubleClick(bsClasses.Current as EntityModel);
            }
        }
    }
}
