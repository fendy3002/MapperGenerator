using MapperGenerator.Library.Data;
using MapperGenerator.Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapperGenerator
{
    public partial class FormAppSetting : Form
    {
        public FormAppSetting()
        {
            InitializeComponent();
        }
        XmlData<AppSetting> xmlData = new XmlData<AppSetting>();
        AppSetting appSetting = null;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            appSetting.ProfilePath = textLocation.Text;
            xmlData.Save(appSetting);
            this.Close();
        }

        private void btnBrowseLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textLocation.Text = dialog.SelectedPath;
            }
            dialog.Dispose();
        }

        private void FormAppSetting_Load(object sender, EventArgs e)
        {
            this.appSetting = xmlData.Load();
            textLocation.Text = this.appSetting.ProfilePath;
        }

    }
}
