using MapperGenerator.Library.Converter;
using MapperGenerator.Library.Data;
using MapperGenerator.Library.Generator;
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
using System.Xml.Serialization;

namespace MapperGenerator
{
    public partial class FormGenerate : Form
    {
        public FormGenerate()
        {
            InitializeComponent();
        }
        //MapperClassGenerator MapperClassGenerator = new MapperClassGenerator();
        List<SourceStructure> SourceStructures = new List<SourceStructure>();
        SourceStructure SelectedStructure
        {
            get
            {
                return bsStructureList.Current as SourceStructure;
            }
        }
        BindingSource bsStructureList = new BindingSource();
        StructureLoader StructureLoader = new StructureLoader();
        XmlData<AppSetting> appSettingXml = new XmlData<AppSetting>();

        Dictionary<TreeNode, object> sourceFileModelMap = new Dictionary<TreeNode, object>();
        MapperGenerator.Library.Model.Source.FileModel sourceFileModel = null;
        Dictionary<TreeNode, object> templateFileModelMap = new Dictionary<TreeNode, object>();
        MapperGenerator.Library.Model.TemplateSource.FileModel templateFileModel = null;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ConversionParam param = new ConversionParam();

            param.SourceClassCode = textClass.Text;
            param.Structure = bsStructureList.Current as SourceStructure;
            //textResult.Text = MapperClassGenerator.Generate(param);
        }

        private void FormGenerate_Load(object sender, EventArgs e)
        {
            this.SourceStructures.AddRange(StructureLoader.Load(appSettingXml.Load()));

            bsStructureList.DataSource = SourceStructures;
            comboStructure.DisplayMember = "Name";
            comboStructure.DataSource = bsStructureList;
            bsStructureList.ResetBindings(false);
        }

        private void textResult_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.Control & e.KeyCode == Keys.A)
            {
                textBox.SelectAll();
            }
            else if (e.Control & e.KeyCode == Keys.Back)
            {
                SendKeys.SendWait("^+{LEFT}{BACKSPACE}");
            }
        }

        private void treeFileModel_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = treeFileModel.SelectedNode;
            if (selectedNode != null)
            {
                var selectedObject = sourceFileModelMap[selectedNode];
                panelDisplaySource.SetModel(selectedObject);
            }
        }

        private void treeFileTemplateModel_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = treeFileTemplateModel.SelectedNode;
            if (selectedNode != null)
            {
                var selectedObject = templateFileModelMap[selectedNode];
                panelDisplayTemplate.SetModel(selectedObject);
            }
        }

        private void btnSourceNext_Click(object sender, EventArgs e)
        {
            SourceCodeToFileModelConverter converter = new SourceCodeToFileModelConverter();
            MapperGenerator.Library.Model.Source.FileModel model = converter.Convert(textClass.Text);

            this.sourceFileModel = model;
            new SourceFileModelToTreeViewBinder().Bind(model, sourceFileModelMap, treeFileModel);
            tabMain.SelectedTab = tabPreprocess;
            panelDisplaySource.Visible = true;
        }

        private void btnPreprocessBack_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabSource;
        }

        private void btnPreprocessNext_Click(object sender, EventArgs e)
        {
            if (templateFileModel == null)
            {
                MessageBox.Show("Generate the template first");
            }
            else
            {
                var renderResult = new TemplateRenderGenerator(SelectedStructure).Render(templateFileModel);
                textResult.Text = renderResult.Result;
                tabMain.SelectedTab = tabResult;
            }
        }

        private void btnGenerateTemplate_Click(object sender, EventArgs e)
        {
            if (SelectedStructure != null)
            {
                FileModelToTemplateFileModel converter = new FileModelToTemplateFileModel(SelectedStructure);
                var templateFileModel = converter.Convert(sourceFileModel);
                this.templateFileModel = templateFileModel;
                new TemplateFileModelToTreeViewBinder().Bind(templateFileModel, templateFileModelMap, treeFileTemplateModel);
                panelDisplayTemplate.Visible = true;
            }
        }

        private void btnResultBack_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabPreprocess;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (templateFileModel == null)
            {
                MessageBox.Show("Generate the template first");
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = "template.xml";
                dialog.Filter = "XML File (*.xml)|*.xml";
                var dialogResult = dialog.ShowDialog();
                if (dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(MapperGenerator.Library.Model.TemplateSource.FileModel));
                    
                    using (FileStream file = new FileStream(dialog.FileName, FileMode.Create))
                    {
                        serializer.Serialize(file, templateFileModel);
                    }
                }                
            }
        }
    }
}
