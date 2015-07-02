namespace MapperGenerator
{
    partial class FormStructureManagement
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
            this.listStructure = new System.Windows.Forms.ListBox();
            this.btnAddStructure = new System.Windows.Forms.Button();
            this.btnRemoveStructure = new System.Windows.Forms.Button();
            this.groupStructure = new System.Windows.Forms.GroupBox();
            this.panelAddRemoveStructure = new System.Windows.Forms.FlowLayoutPanel();
            this.tableStructure = new System.Windows.Forms.TableLayoutPanel();
            this.textFileTemplate = new System.Windows.Forms.TextBox();
            this.textNamespaceTemplate = new System.Windows.Forms.TextBox();
            this.textEntityTemplate = new System.Windows.Forms.TextBox();
            this.textDefaultPropertyTemplate = new System.Windows.Forms.TextBox();
            this.gridPropertyTemplate = new System.Windows.Forms.DataGridView();
            this.textName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.btnRemoveRule = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelStructure = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelStructureAction = new System.Windows.Forms.Panel();
            this.btnCancelStructure = new System.Windows.Forms.Button();
            this.btnSaveStructure = new System.Windows.Forms.Button();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Template = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupStructure.SuspendLayout();
            this.panelAddRemoveStructure.SuspendLayout();
            this.tableStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPropertyTemplate)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelStructure.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelStructureAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // listStructure
            // 
            this.listStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStructure.FormattingEnabled = true;
            this.listStructure.Location = new System.Drawing.Point(3, 48);
            this.listStructure.Name = "listStructure";
            this.listStructure.Size = new System.Drawing.Size(158, 416);
            this.listStructure.TabIndex = 0;
            this.listStructure.DoubleClick += new System.EventHandler(this.listStructure_DoubleClick);
            // 
            // btnAddStructure
            // 
            this.btnAddStructure.AutoSize = true;
            this.btnAddStructure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStructure.Location = new System.Drawing.Point(3, 3);
            this.btnAddStructure.Name = "btnAddStructure";
            this.btnAddStructure.Size = new System.Drawing.Size(36, 23);
            this.btnAddStructure.TabIndex = 1;
            this.btnAddStructure.Text = "Add";
            this.btnAddStructure.UseVisualStyleBackColor = true;
            this.btnAddStructure.Click += new System.EventHandler(this.btnAddStructure_Click);
            // 
            // btnRemoveStructure
            // 
            this.btnRemoveStructure.AutoSize = true;
            this.btnRemoveStructure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveStructure.Location = new System.Drawing.Point(45, 3);
            this.btnRemoveStructure.Name = "btnRemoveStructure";
            this.btnRemoveStructure.Size = new System.Drawing.Size(57, 23);
            this.btnRemoveStructure.TabIndex = 2;
            this.btnRemoveStructure.Text = "Remove";
            this.btnRemoveStructure.UseVisualStyleBackColor = true;
            this.btnRemoveStructure.Click += new System.EventHandler(this.btnRemoveStructure_Click);
            // 
            // groupStructure
            // 
            this.groupStructure.Controls.Add(this.listStructure);
            this.groupStructure.Controls.Add(this.panelAddRemoveStructure);
            this.groupStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupStructure.Location = new System.Drawing.Point(0, 0);
            this.groupStructure.Name = "groupStructure";
            this.groupStructure.Size = new System.Drawing.Size(164, 467);
            this.groupStructure.TabIndex = 3;
            this.groupStructure.TabStop = false;
            this.groupStructure.Text = "Structure";
            // 
            // panelAddRemoveStructure
            // 
            this.panelAddRemoveStructure.Controls.Add(this.btnAddStructure);
            this.panelAddRemoveStructure.Controls.Add(this.btnRemoveStructure);
            this.panelAddRemoveStructure.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddRemoveStructure.Location = new System.Drawing.Point(3, 16);
            this.panelAddRemoveStructure.Name = "panelAddRemoveStructure";
            this.panelAddRemoveStructure.Size = new System.Drawing.Size(158, 32);
            this.panelAddRemoveStructure.TabIndex = 0;
            // 
            // tableStructure
            // 
            this.tableStructure.ColumnCount = 4;
            this.tableStructure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableStructure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStructure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableStructure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStructure.Controls.Add(this.gridPropertyTemplate, 1, 6);
            this.tableStructure.Controls.Add(this.textFileTemplate, 1, 1);
            this.tableStructure.Controls.Add(this.textNamespaceTemplate, 1, 2);
            this.tableStructure.Controls.Add(this.textEntityTemplate, 1, 3);
            this.tableStructure.Controls.Add(this.textDefaultPropertyTemplate, 1, 4);
            this.tableStructure.Controls.Add(this.textName, 1, 0);
            this.tableStructure.Controls.Add(this.label4, 0, 4);
            this.tableStructure.Controls.Add(this.label3, 0, 3);
            this.tableStructure.Controls.Add(this.label2, 0, 2);
            this.tableStructure.Controls.Add(this.label1, 0, 1);
            this.tableStructure.Controls.Add(this.label9, 0, 0);
            this.tableStructure.Controls.Add(this.flowLayoutPanel1, 1, 5);
            this.tableStructure.Controls.Add(this.label8, 0, 5);
            this.tableStructure.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableStructure.Location = new System.Drawing.Point(0, 48);
            this.tableStructure.Name = "tableStructure";
            this.tableStructure.RowCount = 7;
            this.tableStructure.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStructure.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStructure.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStructure.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStructure.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStructure.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStructure.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStructure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStructure.Size = new System.Drawing.Size(696, 757);
            this.tableStructure.TabIndex = 4;
            // 
            // textFileTemplate
            // 
            this.tableStructure.SetColumnSpan(this.textFileTemplate, 3);
            this.textFileTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.textFileTemplate.Location = new System.Drawing.Point(123, 29);
            this.textFileTemplate.Multiline = true;
            this.textFileTemplate.Name = "textFileTemplate";
            this.textFileTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textFileTemplate.Size = new System.Drawing.Size(570, 120);
            this.textFileTemplate.TabIndex = 2;
            // 
            // textNamespaceTemplate
            // 
            this.tableStructure.SetColumnSpan(this.textNamespaceTemplate, 3);
            this.textNamespaceTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNamespaceTemplate.Location = new System.Drawing.Point(123, 155);
            this.textNamespaceTemplate.Multiline = true;
            this.textNamespaceTemplate.Name = "textNamespaceTemplate";
            this.textNamespaceTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNamespaceTemplate.Size = new System.Drawing.Size(570, 120);
            this.textNamespaceTemplate.TabIndex = 3;
            // 
            // textEntityTemplate
            // 
            this.tableStructure.SetColumnSpan(this.textEntityTemplate, 3);
            this.textEntityTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEntityTemplate.Location = new System.Drawing.Point(123, 281);
            this.textEntityTemplate.Multiline = true;
            this.textEntityTemplate.Name = "textEntityTemplate";
            this.textEntityTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEntityTemplate.Size = new System.Drawing.Size(570, 120);
            this.textEntityTemplate.TabIndex = 5;
            // 
            // textDefaultPropertyTemplate
            // 
            this.tableStructure.SetColumnSpan(this.textDefaultPropertyTemplate, 3);
            this.textDefaultPropertyTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDefaultPropertyTemplate.Location = new System.Drawing.Point(123, 407);
            this.textDefaultPropertyTemplate.Multiline = true;
            this.textDefaultPropertyTemplate.Name = "textDefaultPropertyTemplate";
            this.textDefaultPropertyTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDefaultPropertyTemplate.Size = new System.Drawing.Size(570, 120);
            this.textDefaultPropertyTemplate.TabIndex = 7;
            // 
            // gridPropertyTemplate
            // 
            this.gridPropertyTemplate.AllowUserToAddRows = false;
            this.gridPropertyTemplate.AllowUserToDeleteRows = false;
            this.gridPropertyTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPropertyTemplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataType,
            this.Template});
            this.tableStructure.SetColumnSpan(this.gridPropertyTemplate, 3);
            this.gridPropertyTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPropertyTemplate.Location = new System.Drawing.Point(123, 568);
            this.gridPropertyTemplate.Name = "gridPropertyTemplate";
            this.gridPropertyTemplate.RowHeadersVisible = false;
            this.gridPropertyTemplate.RowTemplate.Height = 60;
            this.gridPropertyTemplate.Size = new System.Drawing.Size(570, 186);
            this.gridPropertyTemplate.TabIndex = 15;
            // 
            // textName
            // 
            this.tableStructure.SetColumnSpan(this.textName, 3);
            this.textName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textName.Location = new System.Drawing.Point(123, 3);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(570, 20);
            this.textName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Default Property Template";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entity Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Namespace Template";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Template";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnAddRule);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveRule);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 533);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(3, 3);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(75, 23);
            this.btnAddRule.TabIndex = 18;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.Location = new System.Drawing.Point(84, 3);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRule.TabIndex = 19;
            this.btnRemoveRule.Text = "Remove";
            this.btnRemoveRule.UseVisualStyleBackColor = true;
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Property Template";
            // 
            // panelStructure
            // 
            this.panelStructure.AutoScroll = true;
            this.panelStructure.Controls.Add(this.tableStructure);
            this.panelStructure.Controls.Add(this.panel1);
            this.panelStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStructure.Location = new System.Drawing.Point(164, 0);
            this.panelStructure.Name = "panelStructure";
            this.panelStructure.Size = new System.Drawing.Size(713, 435);
            this.panelStructure.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 48);
            this.panel1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tips:";
            // 
            // panelStructureAction
            // 
            this.panelStructureAction.Controls.Add(this.btnCancelStructure);
            this.panelStructureAction.Controls.Add(this.btnSaveStructure);
            this.panelStructureAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStructureAction.Location = new System.Drawing.Point(164, 435);
            this.panelStructureAction.Name = "panelStructureAction";
            this.panelStructureAction.Size = new System.Drawing.Size(713, 32);
            this.panelStructureAction.TabIndex = 5;
            // 
            // btnCancelStructure
            // 
            this.btnCancelStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelStructure.Location = new System.Drawing.Point(626, 6);
            this.btnCancelStructure.Name = "btnCancelStructure";
            this.btnCancelStructure.Size = new System.Drawing.Size(75, 23);
            this.btnCancelStructure.TabIndex = 1;
            this.btnCancelStructure.Text = "Cancel";
            this.btnCancelStructure.UseVisualStyleBackColor = true;
            this.btnCancelStructure.Click += new System.EventHandler(this.btnCancelStructure_Click);
            // 
            // btnSaveStructure
            // 
            this.btnSaveStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStructure.Location = new System.Drawing.Point(545, 6);
            this.btnSaveStructure.Name = "btnSaveStructure";
            this.btnSaveStructure.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStructure.TabIndex = 0;
            this.btnSaveStructure.Text = "Save";
            this.btnSaveStructure.UseVisualStyleBackColor = true;
            this.btnSaveStructure.Click += new System.EventHandler(this.btnSaveStructure_Click);
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "Data Type";
            this.DataType.Name = "DataType";
            // 
            // Template
            // 
            this.Template.DataPropertyName = "Template";
            this.Template.HeaderText = "Template";
            this.Template.Name = "Template";
            this.Template.Width = 450;
            // 
            // FormStructureManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 467);
            this.Controls.Add(this.panelStructure);
            this.Controls.Add(this.panelStructureAction);
            this.Controls.Add(this.groupStructure);
            this.Name = "FormStructureManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structure Manager";
            this.Load += new System.EventHandler(this.FormStructureManagement_Load);
            this.groupStructure.ResumeLayout(false);
            this.panelAddRemoveStructure.ResumeLayout(false);
            this.panelAddRemoveStructure.PerformLayout();
            this.tableStructure.ResumeLayout(false);
            this.tableStructure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPropertyTemplate)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelStructure.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelStructureAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listStructure;
        private System.Windows.Forms.Button btnAddStructure;
        private System.Windows.Forms.Button btnRemoveStructure;
        private System.Windows.Forms.GroupBox groupStructure;
        private System.Windows.Forms.FlowLayoutPanel panelAddRemoveStructure;
        private System.Windows.Forms.TableLayoutPanel tableStructure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFileTemplate;
        private System.Windows.Forms.TextBox textNamespaceTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEntityTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDefaultPropertyTemplate;
        private System.Windows.Forms.Panel panelStructure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridPropertyTemplate;
        private System.Windows.Forms.Panel panelStructureAction;
        private System.Windows.Forms.Button btnCancelStructure;
        private System.Windows.Forms.Button btnSaveStructure;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemoveRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Template;
    }
}