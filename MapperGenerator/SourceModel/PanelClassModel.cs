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
    public delegate void PropertyDoubleClickHandler(PropertyModel ps);
    public partial class PanelClassModel : UserControl
    {
        public PanelClassModel()
        {
            InitializeComponent();
        }

        BindingSource bsProperties = new BindingSource();

        ClassModel model;
        public event PropertyDoubleClickHandler PropertyDoubleClick;
        public void SetModel(ClassModel model)
        {
            this.model = model;
            if (model != null)
            {
                textName.Text = model.Name;
                bsProperties.DataSource = model.Properties;
            }
            else
            {
                textName.Text = "";
                bsProperties.DataSource = null;
            }

            bsProperties.ResetBindings(false);

            listProperties.DisplayMember = "Name";
            listProperties.ValueMember = "Name";
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
