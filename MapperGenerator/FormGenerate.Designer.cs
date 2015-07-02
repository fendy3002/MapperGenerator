namespace MapperGenerator
{
    partial class FormGenerate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboStructure = new System.Windows.Forms.ComboBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSourceNext = new System.Windows.Forms.Button();
            this.tabPreprocess = new System.Windows.Forms.TabPage();
            this.tablePreprocess = new System.Windows.Forms.TableLayoutPanel();
            this.splitPreprocess = new System.Windows.Forms.SplitContainer();
            this.treeFileModel = new System.Windows.Forms.TreeView();
            this.panelDisplaySource = new MapperGenerator.SourceModel.PanelGeneric();
            this.splitTemplate = new System.Windows.Forms.SplitContainer();
            this.treeFileTemplateModel = new System.Windows.Forms.TreeView();
            this.panelDisplayTemplate = new MapperGenerator.TemplateModel.PanelGeneric();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerateTemplate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPreprocessBack = new System.Windows.Forms.Button();
            this.btnPreprocessNext = new System.Windows.Forms.Button();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.textResult = new System.Windows.Forms.TextBox();
            this.panelResultAction = new System.Windows.Forms.Panel();
            this.btnResultBack = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPreprocess.SuspendLayout();
            this.tablePreprocess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPreprocess)).BeginInit();
            this.splitPreprocess.Panel1.SuspendLayout();
            this.splitPreprocess.Panel2.SuspendLayout();
            this.splitPreprocess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTemplate)).BeginInit();
            this.splitTemplate.Panel1.SuspendLayout();
            this.splitTemplate.Panel2.SuspendLayout();
            this.splitTemplate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.panelResultAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // textClass
            // 
            this.textClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textClass.Location = new System.Drawing.Point(3, 3);
            this.textClass.Multiline = true;
            this.textClass.Name = "textClass";
            this.textClass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textClass.Size = new System.Drawing.Size(889, 384);
            this.textClass.TabIndex = 0;
            this.textClass.WordWrap = false;
            this.textClass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textResult_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Structure";
            // 
            // comboStructure
            // 
            this.comboStructure.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStructure.FormattingEnabled = true;
            this.comboStructure.Location = new System.Drawing.Point(0, 13);
            this.comboStructure.Name = "comboStructure";
            this.comboStructure.Size = new System.Drawing.Size(883, 21);
            this.comboStructure.TabIndex = 2;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSource);
            this.tabMain.Controls.Add(this.tabPreprocess);
            this.tabMain.Controls.Add(this.tabResult);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(903, 452);
            this.tabMain.TabIndex = 2;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.textClass);
            this.tabSource.Controls.Add(this.panel1);
            this.tabSource.Location = new System.Drawing.Point(4, 22);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(895, 426);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "Source Class";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSourceNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 36);
            this.panel1.TabIndex = 1;
            // 
            // btnSourceNext
            // 
            this.btnSourceNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceNext.Location = new System.Drawing.Point(811, 9);
            this.btnSourceNext.Name = "btnSourceNext";
            this.btnSourceNext.Size = new System.Drawing.Size(75, 23);
            this.btnSourceNext.TabIndex = 0;
            this.btnSourceNext.Text = "Next";
            this.btnSourceNext.UseVisualStyleBackColor = true;
            this.btnSourceNext.Click += new System.EventHandler(this.btnSourceNext_Click);
            // 
            // tabPreprocess
            // 
            this.tabPreprocess.Controls.Add(this.tablePreprocess);
            this.tabPreprocess.Controls.Add(this.panel2);
            this.tabPreprocess.Location = new System.Drawing.Point(4, 22);
            this.tabPreprocess.Name = "tabPreprocess";
            this.tabPreprocess.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreprocess.Size = new System.Drawing.Size(895, 426);
            this.tabPreprocess.TabIndex = 1;
            this.tabPreprocess.Text = "Pre-Processed";
            this.tabPreprocess.UseVisualStyleBackColor = true;
            // 
            // tablePreprocess
            // 
            this.tablePreprocess.ColumnCount = 1;
            this.tablePreprocess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePreprocess.Controls.Add(this.splitPreprocess, 0, 0);
            this.tablePreprocess.Controls.Add(this.splitTemplate, 0, 2);
            this.tablePreprocess.Controls.Add(this.panel3, 0, 1);
            this.tablePreprocess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePreprocess.Location = new System.Drawing.Point(3, 3);
            this.tablePreprocess.Name = "tablePreprocess";
            this.tablePreprocess.RowCount = 3;
            this.tablePreprocess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePreprocess.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePreprocess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePreprocess.Size = new System.Drawing.Size(889, 389);
            this.tablePreprocess.TabIndex = 3;
            // 
            // splitPreprocess
            // 
            this.splitPreprocess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPreprocess.Location = new System.Drawing.Point(3, 3);
            this.splitPreprocess.Name = "splitPreprocess";
            // 
            // splitPreprocess.Panel1
            // 
            this.splitPreprocess.Panel1.Controls.Add(this.treeFileModel);
            // 
            // splitPreprocess.Panel2
            // 
            this.splitPreprocess.Panel2.Controls.Add(this.panelDisplaySource);
            this.splitPreprocess.Size = new System.Drawing.Size(883, 149);
            this.splitPreprocess.SplitterDistance = 338;
            this.splitPreprocess.TabIndex = 2;
            // 
            // treeFileModel
            // 
            this.treeFileModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFileModel.Location = new System.Drawing.Point(0, 0);
            this.treeFileModel.Name = "treeFileModel";
            this.treeFileModel.Size = new System.Drawing.Size(338, 149);
            this.treeFileModel.TabIndex = 0;
            this.treeFileModel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFileModel_AfterSelect);
            // 
            // panelDisplaySource
            // 
            this.panelDisplaySource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplaySource.Location = new System.Drawing.Point(0, 0);
            this.panelDisplaySource.Name = "panelDisplaySource";
            this.panelDisplaySource.Size = new System.Drawing.Size(541, 149);
            this.panelDisplaySource.TabIndex = 0;
            this.panelDisplaySource.Visible = false;
            // 
            // splitTemplate
            // 
            this.splitTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTemplate.Location = new System.Drawing.Point(3, 236);
            this.splitTemplate.Name = "splitTemplate";
            // 
            // splitTemplate.Panel1
            // 
            this.splitTemplate.Panel1.Controls.Add(this.treeFileTemplateModel);
            // 
            // splitTemplate.Panel2
            // 
            this.splitTemplate.Panel2.Controls.Add(this.panelDisplayTemplate);
            this.splitTemplate.Size = new System.Drawing.Size(883, 150);
            this.splitTemplate.SplitterDistance = 330;
            this.splitTemplate.TabIndex = 4;
            // 
            // treeFileTemplateModel
            // 
            this.treeFileTemplateModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFileTemplateModel.Location = new System.Drawing.Point(0, 0);
            this.treeFileTemplateModel.Name = "treeFileTemplateModel";
            this.treeFileTemplateModel.Size = new System.Drawing.Size(330, 150);
            this.treeFileTemplateModel.TabIndex = 0;
            this.treeFileTemplateModel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFileTemplateModel_AfterSelect);
            // 
            // panelDisplayTemplate
            // 
            this.panelDisplayTemplate.AutoScroll = true;
            this.panelDisplayTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayTemplate.Location = new System.Drawing.Point(0, 0);
            this.panelDisplayTemplate.Name = "panelDisplayTemplate";
            this.panelDisplayTemplate.Size = new System.Drawing.Size(549, 150);
            this.panelDisplayTemplate.TabIndex = 0;
            this.panelDisplayTemplate.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerateTemplate);
            this.panel3.Controls.Add(this.comboStructure);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 72);
            this.panel3.TabIndex = 3;
            // 
            // btnGenerateTemplate
            // 
            this.btnGenerateTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateTemplate.Location = new System.Drawing.Point(745, 40);
            this.btnGenerateTemplate.Name = "btnGenerateTemplate";
            this.btnGenerateTemplate.Size = new System.Drawing.Size(135, 23);
            this.btnGenerateTemplate.TabIndex = 3;
            this.btnGenerateTemplate.Text = "Generate Template";
            this.btnGenerateTemplate.UseVisualStyleBackColor = true;
            this.btnGenerateTemplate.Click += new System.EventHandler(this.btnGenerateTemplate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDownload);
            this.panel2.Controls.Add(this.btnPreprocessBack);
            this.panel2.Controls.Add(this.btnPreprocessNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 31);
            this.panel2.TabIndex = 1;
            // 
            // btnPreprocessBack
            // 
            this.btnPreprocessBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreprocessBack.Location = new System.Drawing.Point(635, 5);
            this.btnPreprocessBack.Name = "btnPreprocessBack";
            this.btnPreprocessBack.Size = new System.Drawing.Size(75, 23);
            this.btnPreprocessBack.TabIndex = 1;
            this.btnPreprocessBack.Text = "Back";
            this.btnPreprocessBack.UseVisualStyleBackColor = true;
            this.btnPreprocessBack.Click += new System.EventHandler(this.btnPreprocessBack_Click);
            // 
            // btnPreprocessNext
            // 
            this.btnPreprocessNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreprocessNext.Location = new System.Drawing.Point(811, 5);
            this.btnPreprocessNext.Name = "btnPreprocessNext";
            this.btnPreprocessNext.Size = new System.Drawing.Size(75, 23);
            this.btnPreprocessNext.TabIndex = 0;
            this.btnPreprocessNext.Text = "Finish";
            this.btnPreprocessNext.UseVisualStyleBackColor = true;
            this.btnPreprocessNext.Click += new System.EventHandler(this.btnPreprocessNext_Click);
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.textResult);
            this.tabResult.Controls.Add(this.panelResultAction);
            this.tabResult.Location = new System.Drawing.Point(4, 22);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabResult.Size = new System.Drawing.Size(895, 426);
            this.tabResult.TabIndex = 2;
            this.tabResult.Text = "Result";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // textResult
            // 
            this.textResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textResult.Location = new System.Drawing.Point(3, 3);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(889, 386);
            this.textResult.TabIndex = 1;
            this.textResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textResult_KeyUp);
            // 
            // panelResultAction
            // 
            this.panelResultAction.Controls.Add(this.btnResultBack);
            this.panelResultAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultAction.Location = new System.Drawing.Point(3, 389);
            this.panelResultAction.Name = "panelResultAction";
            this.panelResultAction.Size = new System.Drawing.Size(889, 34);
            this.panelResultAction.TabIndex = 0;
            // 
            // btnResultBack
            // 
            this.btnResultBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultBack.Location = new System.Drawing.Point(809, 6);
            this.btnResultBack.Name = "btnResultBack";
            this.btnResultBack.Size = new System.Drawing.Size(75, 23);
            this.btnResultBack.TabIndex = 0;
            this.btnResultBack.Text = "Back";
            this.btnResultBack.UseVisualStyleBackColor = true;
            this.btnResultBack.Click += new System.EventHandler(this.btnResultBack_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(716, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download Xml";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // FormGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 452);
            this.Controls.Add(this.tabMain);
            this.Name = "FormGenerate";
            this.Text = "Generate";
            this.Load += new System.EventHandler(this.FormGenerate_Load);
            this.tabMain.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPreprocess.ResumeLayout(false);
            this.tablePreprocess.ResumeLayout(false);
            this.splitPreprocess.Panel1.ResumeLayout(false);
            this.splitPreprocess.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPreprocess)).EndInit();
            this.splitPreprocess.ResumeLayout(false);
            this.splitTemplate.Panel1.ResumeLayout(false);
            this.splitTemplate.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTemplate)).EndInit();
            this.splitTemplate.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            this.tabResult.PerformLayout();
            this.panelResultAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboStructure;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TabPage tabPreprocess;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSourceNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPreprocessBack;
        private System.Windows.Forms.Button btnPreprocessNext;
        private System.Windows.Forms.SplitContainer splitPreprocess;
        private System.Windows.Forms.TreeView treeFileModel;
        private SourceModel.PanelGeneric panelDisplaySource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGenerateTemplate;
        private System.Windows.Forms.SplitContainer splitTemplate;
        private System.Windows.Forms.TableLayoutPanel tablePreprocess;
        private System.Windows.Forms.TreeView treeFileTemplateModel;
        private System.Windows.Forms.Panel panelResultAction;
        private System.Windows.Forms.Button btnResultBack;
        private System.Windows.Forms.TextBox textResult;
        private TemplateModel.PanelGeneric panelDisplayTemplate;
        private System.Windows.Forms.Button btnDownload;
    }
}