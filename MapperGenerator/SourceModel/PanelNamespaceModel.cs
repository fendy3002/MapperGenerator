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
    public delegate void ClassDoubleClickHandler(ClassModel fs);
    public partial class PanelNamespaceModel : UserControl
    {
        public PanelNamespaceModel()
        {
            InitializeComponent();
        }

        BindingSource bsClasses = new BindingSource();

        NamespaceModel model;
        public event ClassDoubleClickHandler ClassDoubleClick;
        public void SetModel(NamespaceModel model)
        {
            this.model = model;
            if (model != null)
            {
                textName.Text = model.Name;
                bsClasses.DataSource = model.Classes;
            }
            else
            {
                textName.Text = "";
                bsClasses.DataSource = null;
            }

            bsClasses.ResetBindings(false);
            listClasses.DisplayMember = "Name";
            listClasses.ValueMember = "Name";
            listClasses.DataSource = bsClasses;
        }
        
        private void listNamespaces_DoubleClick(object sender, EventArgs e)
        {
            if (ClassDoubleClick != null)
            {
                ClassDoubleClick(bsClasses.Current as ClassModel);
            }
        }
    }
}
