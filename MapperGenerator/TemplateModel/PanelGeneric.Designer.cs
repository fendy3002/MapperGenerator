namespace MapperGenerator.TemplateModel
{
    partial class PanelGeneric
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
            this.panelEntityModel = new MapperGenerator.TemplateModel.PanelEntityModel();
            this.panelNamespaceModel = new MapperGenerator.TemplateModel.PanelNamespaceModel();
            this.panelFileModel = new MapperGenerator.TemplateModel.PanelFileModel();
            this.panelPropertyModel = new MapperGenerator.TemplateModel.PanelPropertyModel();
            this.SuspendLayout();
            // 
            // panelEntityModel
            // 
            this.panelEntityModel.Location = new System.Drawing.Point(3, 210);
            this.panelEntityModel.Name = "panelEntityModel";
            this.panelEntityModel.Size = new System.Drawing.Size(296, 234);
            this.panelEntityModel.TabIndex = 2;
            // 
            // panelNamespaceModel
            // 
            this.panelNamespaceModel.Location = new System.Drawing.Point(305, 3);
            this.panelNamespaceModel.Name = "panelNamespaceModel";
            this.panelNamespaceModel.Size = new System.Drawing.Size(296, 174);
            this.panelNamespaceModel.TabIndex = 1;
            // 
            // panelFileModel
            // 
            this.panelFileModel.Location = new System.Drawing.Point(3, 0);
            this.panelFileModel.Name = "panelFileModel";
            this.panelFileModel.Size = new System.Drawing.Size(296, 210);
            this.panelFileModel.TabIndex = 0;
            // 
            // panelPropertyModel
            // 
            this.panelPropertyModel.Location = new System.Drawing.Point(322, 183);
            this.panelPropertyModel.Name = "panelPropertyModel";
            this.panelPropertyModel.Size = new System.Drawing.Size(296, 219);
            this.panelPropertyModel.TabIndex = 3;
            // 
            // PanelGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panelPropertyModel);
            this.Controls.Add(this.panelEntityModel);
            this.Controls.Add(this.panelNamespaceModel);
            this.Controls.Add(this.panelFileModel);
            this.Name = "PanelGeneric";
            this.Size = new System.Drawing.Size(782, 496);
            this.ResumeLayout(false);

        }

        #endregion

        private PanelFileModel panelFileModel;
        private PanelNamespaceModel panelNamespaceModel;
        private PanelEntityModel panelEntityModel;
        private PanelPropertyModel panelPropertyModel;
    }
}
