namespace MapperGenerator.TemplateModel
{
    partial class PanelPropertyModel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.textModifier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkHasGet = new System.Windows.Forms.CheckBox();
            this.checkHasSet = new System.Windows.Forms.CheckBox();
            this.textRender = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.7027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.29729F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textModifier, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkHasGet, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkHasSet, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textRender, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 218);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // textName
            // 
            this.textName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textName.Location = new System.Drawing.Point(85, 3);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(208, 20);
            this.textName.TabIndex = 3;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Modifier";
            // 
            // textType
            // 
            this.textType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textType.Location = new System.Drawing.Point(85, 29);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(208, 20);
            this.textType.TabIndex = 8;
            this.textType.TextChanged += new System.EventHandler(this.textType_TextChanged);
            // 
            // textModifier
            // 
            this.textModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textModifier.Location = new System.Drawing.Point(85, 55);
            this.textModifier.Name = "textModifier";
            this.textModifier.Size = new System.Drawing.Size(208, 20);
            this.textModifier.TabIndex = 9;
            this.textModifier.TextChanged += new System.EventHandler(this.textModifier_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Render";
            // 
            // checkHasGet
            // 
            this.checkHasGet.AutoSize = true;
            this.checkHasGet.Location = new System.Drawing.Point(85, 192);
            this.checkHasGet.Name = "checkHasGet";
            this.checkHasGet.Size = new System.Drawing.Size(65, 17);
            this.checkHasGet.TabIndex = 10;
            this.checkHasGet.Text = "Has Get";
            this.checkHasGet.UseVisualStyleBackColor = true;
            // 
            // checkHasSet
            // 
            this.checkHasSet.AutoSize = true;
            this.checkHasSet.Location = new System.Drawing.Point(85, 169);
            this.checkHasSet.Name = "checkHasSet";
            this.checkHasSet.Size = new System.Drawing.Size(64, 17);
            this.checkHasSet.TabIndex = 11;
            this.checkHasSet.Text = "Has Set";
            this.checkHasSet.UseVisualStyleBackColor = true;
            // 
            // textRender
            // 
            this.textRender.Dock = System.Windows.Forms.DockStyle.Top;
            this.textRender.Location = new System.Drawing.Point(85, 81);
            this.textRender.Multiline = true;
            this.textRender.Name = "textRender";
            this.textRender.Size = new System.Drawing.Size(208, 82);
            this.textRender.TabIndex = 13;
            this.textRender.TextChanged += new System.EventHandler(this.textRender_TextChanged);
            // 
            // PanelPropertyModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PanelPropertyModel";
            this.Size = new System.Drawing.Size(296, 218);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textModifier;
        private System.Windows.Forms.CheckBox checkHasGet;
        private System.Windows.Forms.CheckBox checkHasSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRender;
    }
}
