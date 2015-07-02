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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        XmlData<AppSetting> xmlData = new XmlData<AppSetting>();
        FormAppSetting formAppSetting = null;
        FormStructureManagement formStructureManagement = null;
        FormGenerate formGenerate = null;

        private void structureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formStructureManagement == null || formStructureManagement.IsDisposed)
            {
                formStructureManagement = new FormStructureManagement();
                formStructureManagement.MdiParent = this;
                formStructureManagement.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void appToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formAppSetting == null || formAppSetting.IsDisposed)
            {
                formAppSetting = new FormAppSetting();
                formAppSetting.MdiParent = this;
                formAppSetting.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                AppSetting setting = xmlData.Load();
                if (setting == null)
                {
                    xmlData.Save(new AppSetting());
                }
            }
            catch
            {
                xmlData.Save(new AppSetting());
            }
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formGenerate == null || formGenerate.IsDisposed)
            {
                formGenerate = new FormGenerate();
                formGenerate.MdiParent = this;
                formGenerate.Show();
            }
        }
    }
}
