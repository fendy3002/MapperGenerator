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
    public partial class PanelPropertyModel : UserControl
    {
        public PanelPropertyModel()
        {
            InitializeComponent();
        }

        PropertyModel model;
        public void SetModel(PropertyModel model)
        {
            this.model = model;
            if (model != null)
            {
                textModifier.Text = model.Modifier;
                textName.Text = model.Name;
                textType.Text = model.TypeName;
                checkHasGet.Checked = model.HasGetAccess;
                checkHasSet.Checked = model.HasSetAccess;
            }
            else
            {
                textModifier.Text = "";
                textName.Text = "";
                textType.Text = "";
                checkHasGet.Checked = false;
                checkHasSet.Checked = false;
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            model.Name = textName.Text;
            model.Modifier = textModifier.Text;
            model.TypeName = textType.Text;
        }
    }
}
