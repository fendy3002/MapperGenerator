using MapperGenerator.Library.Data;
using MapperGenerator.Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapperGenerator
{
    public partial class FormStructureManagement : Form
    {
        public FormStructureManagement()
        {
            InitializeComponent();
        }

        bool isAdd = false;
        BindingSource bsListStructure = new BindingSource();
        BindingSource bsPropertyTemplate = new BindingSource();
        AppSetting AppSetting = null;
        XmlData<AppSetting> appSettingXml = new XmlData<AppSetting>();
        XmlData<SourceStructure> sourceStructureXml = new XmlData<SourceStructure>();
        
        StructureLoader StructureLoader = new StructureLoader();
        List<SourceStructure> sourceStructures = new List<SourceStructure>();
        private SourceStructure CurrentSourceStructure
        {
            get
            {
                return bsListStructure.Current as SourceStructure;
            }
        }

        private void FormStructureManagement_Load(object sender, EventArgs e)
        {
            this.AppSetting = appSettingXml.Load();
            LoadStructure();

            EditMode(false);
            bsListStructure.DataSource = sourceStructures;
            bsListStructure.CurrentChanged += bsListStructure_CurrentChanged;
            listStructure.DataSource = bsListStructure;
            listStructure.DisplayMember = "Name";
            gridPropertyTemplate.AutoGenerateColumns = false;
            gridPropertyTemplate.DataSource = bsPropertyTemplate;
        }

        void bsListStructure_CurrentChanged(object sender, EventArgs e)
        {
            if (bsListStructure.Current != null)
            {
                SetStructure(bsListStructure.Current as SourceStructure);
            }
        }

        private void LoadStructure()
        {
            if (Directory.Exists(AppSetting.ProfilePath))
            {
                this.sourceStructures.AddRange(StructureLoader.Load(AppSetting));
                bsListStructure.DataSource = sourceStructures;
                bsListStructure.ResetBindings(false);

                if (bsListStructure.Count > 0)
                {
                    bsListStructure.MoveFirst();
                    SetStructure(bsListStructure.Current as SourceStructure);
                }
            }
            else
            {
                Directory.CreateDirectory(AppSetting.ProfilePath);
            }
        }

        private void EditMode(bool isEdit)
        {
            if (isEdit)
            {
                tableStructure.Enabled = true;
                panelStructureAction.Enabled = true;

                groupStructure.Enabled = false;
            }
            else
            {
                tableStructure.Enabled = false;
                panelStructureAction.Enabled = false;

                groupStructure.Enabled = true;
            }
        }

        private void btnSaveStructure_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Name must not empty");
                return;
            }

            if (sourceStructures.Any(k => k != CurrentSourceStructure && k.Name.Equals(CurrentSourceStructure.Name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Existing name exists");
                return;
            }
            string currentName = CurrentSourceStructure.Name;
            AppendInputTo(CurrentSourceStructure);
            sourceStructureXml.FilePath = AppSetting.ProfilePath + "\\" + CurrentSourceStructure.Name + ".xml";
            sourceStructureXml.Save(CurrentSourceStructure);

            if (!string.IsNullOrWhiteSpace(currentName) && !currentName.Equals(CurrentSourceStructure.Name, StringComparison.OrdinalIgnoreCase) )
            {
                File.Delete(AppSetting.ProfilePath + "\\" + currentName + ".xml");
            }
            bsListStructure.ResetBindings(false);
            EditMode(false);
        }

        private void SetStructure(SourceStructure source)
        {
            textName.Text = source.Name;
            textFileTemplate.Text = source.FileTemplate;
            textNamespaceTemplate.Text = source.NamespaceTemplate;
            textEntityTemplate.Text = source.EntityTemplate;
            textDefaultPropertyTemplate.Text = source.DefaultPropertyTemplate;
            
            bsPropertyTemplate.DataSource = source.PropertyTemplate;
            gridPropertyTemplate.DataSource = bsPropertyTemplate;
            bsPropertyTemplate.ResetBindings(false);
        }

        private void AppendInputTo(SourceStructure source)
        {
            source.Name = textName.Text;
            source.FileTemplate = textFileTemplate.Text;
            source.NamespaceTemplate = textNamespaceTemplate.Text;
            source.EntityTemplate = textEntityTemplate.Text;
            source.DefaultPropertyTemplate = textDefaultPropertyTemplate.Text;
        }

        private void listStructure_DoubleClick(object sender, EventArgs e)
        {
            EditMode(true);
        }

        private void btnCancelStructure_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                bsListStructure.RemoveCurrent();
                bsListStructure.ResetBindings(false);
                if (bsListStructure.Count > 0)
                {
                    bsListStructure.MoveFirst();
                }
            }

            EditMode(false);
            SetStructure(CurrentSourceStructure);
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            CurrentSourceStructure.PropertyTemplate.Add(new PropertyTemplate());
            bsPropertyTemplate.ResetBindings(false);
        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {
            if (bsPropertyTemplate.Current != null)
            {
                bsPropertyTemplate.RemoveCurrent();
            }
        }

        private void btnAddStructure_Click(object sender, EventArgs e)
        {
            SourceStructure structure = new SourceStructure();
            sourceStructures.Add(structure);
            bsListStructure.ResetBindings(false);
            bsListStructure.MoveLast();
            SetStructure(structure);
            EditMode(true);
            isAdd = true;
        }

        private void btnRemoveStructure_Click(object sender, EventArgs e)
        {
            if (bsListStructure.Current != null)
            {
                if (MessageBox.Show("Are you sure? The action cannot be undone.", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    File.Delete(AppSetting.ProfilePath + "\\" + CurrentSourceStructure.Name + ".xml");
                    bsListStructure.RemoveCurrent();
                    bsListStructure.ResetBindings(false);
                }
            }
        }
    }
}
