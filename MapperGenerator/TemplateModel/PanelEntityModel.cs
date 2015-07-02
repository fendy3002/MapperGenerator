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
    public delegate void PropertyDoubleClickHandler(PropertyModel ps);
    public partial class PanelEntityModel : UserControl
    {
        public PanelEntityModel()
        {
            InitializeComponent();
        }

        BindingSource bsProperties = new BindingSource();

        EntityModel model;
        public event PropertyDoubleClickHandler PropertyDoubleClick;
        public void SetModel(EntityModel model)
        {
            this.model = model;
            if (model != null)
            {
                textName.Text = model.Name.PascalCase;
                bsProperties.DataSource = model.Properties;
            }
            else
            {
                textName.Text = "";
                bsProperties.DataSource = null;
            }

            bsProperties.ResetBindings(false);

            listProperties.DisplayMember = "Name.PascalCase";
            listProperties.ValueMember = "Name.PascalCase";
            listProperties.DataSource = bsProperties;
        }
        
        private void listNamespaces_DoubleClick(object sender, EventArgs e)
        {
            if (PropertyDoubleClick != null)
            {
                PropertyDoubleClick(bsProperties.Current as PropertyModel);
            }
        }
    }
}
