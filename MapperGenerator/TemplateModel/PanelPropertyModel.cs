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
                textRender.Text = model.Render;
                textModifier.Text = model.Modifier;
                textName.Text = model.Name.PascalCase;
                textType.Text = model.TypeName;
                checkHasGet.Checked = model.HasGetAccess;
                checkHasSet.Checked = model.HasSetAccess;
            }
            else
            {
                textRender.Text = "";
                textModifier.Text = "";
                textName.Text = "";
                textType.Text = "";
                checkHasGet.Checked = false;
                checkHasSet.Checked = false;
            }
        }

        private void textRender_TextChanged(object sender, EventArgs e)
        {
            model.Render = textRender.Text;
        }

        private void textModifier_TextChanged(object sender, EventArgs e)
        {
            model.Modifier = textModifier.Text;
        }

        private void textType_TextChanged(object sender, EventArgs e)
        {
            model.TypeName = textType.Text;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            model.Name.PascalCase = textName.Text;
        }
    }
}
