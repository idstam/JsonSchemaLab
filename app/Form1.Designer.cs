namespace JsonSchemaLab
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSchemaLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblJsonLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSchema = new JsonSchemaLab.TabbedRichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnLoadSchema = new System.Windows.Forms.ToolStripButton();
            this.btnPasteSchema = new System.Windows.Forms.ToolStripButton();
            this.btnSaveSchema = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtJson = new JsonSchemaLab.TabbedRichTextBox();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnOpenJson = new System.Windows.Forms.ToolStripButton();
            this.btnPasteJson = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnValidate = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSchemaLine,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblJsonLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(962, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Schema line:";
            // 
            // lblSchemaLine
            // 
            this.lblSchemaLine.Name = "lblSchemaLine";
            this.lblSchemaLine.Size = new System.Drawing.Size(13, 17);
            this.lblSchemaLine.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(792, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "...";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel3.Text = "Json line:";
            // 
            // lblJsonLine
            // 
            this.lblJsonLine.Name = "lblJsonLine";
            this.lblJsonLine.Size = new System.Drawing.Size(13, 17);
            this.lblJsonLine.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSchema);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer1.Size = new System.Drawing.Size(962, 488);
            this.splitContainer1.SplitterDistance = 496;
            this.splitContainer1.TabIndex = 2;
            // 
            // txtSchema
            // 
            this.txtSchema.AcceptsTab = true;
            this.txtSchema.ConvertTabToSpaces = false;
            this.txtSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchema.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchema.Location = new System.Drawing.Point(0, 25);
            this.txtSchema.Name = "txtSchema";
            this.txtSchema.Size = new System.Drawing.Size(496, 463);
            this.txtSchema.TabIndex = 0;
            this.txtSchema.TabSize = 4;
            this.txtSchema.Text = "Paste Schema here...";
            this.txtSchema.WordWrap = false;
            this.txtSchema.SelectionChanged += new System.EventHandler(this.txtSchema_SelectionChanged);
            this.txtSchema.TextChanged += new System.EventHandler(this.txtSchema_TextChanged);
            this.txtSchema.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSchema_KeyUp);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadSchema,
            this.btnPasteSchema,
            this.btnSaveSchema});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(496, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnLoadSchema
            // 
            this.btnLoadSchema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadSchema.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadSchema.Image")));
            this.btnLoadSchema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadSchema.Name = "btnLoadSchema";
            this.btnLoadSchema.Size = new System.Drawing.Size(23, 22);
            this.btnLoadSchema.Text = "toolStripButton1";
            this.btnLoadSchema.ToolTipText = "Load Schema from file";
            this.btnLoadSchema.Click += new System.EventHandler(this.btnLoadSchema_Click);
            // 
            // btnPasteSchema
            // 
            this.btnPasteSchema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPasteSchema.Image = ((System.Drawing.Image)(resources.GetObject("btnPasteSchema.Image")));
            this.btnPasteSchema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPasteSchema.Name = "btnPasteSchema";
            this.btnPasteSchema.Size = new System.Drawing.Size(23, 22);
            this.btnPasteSchema.Text = "toolStripButton1";
            this.btnPasteSchema.ToolTipText = "Paste Schema";
            this.btnPasteSchema.Click += new System.EventHandler(this.btnPasteSchema_Click);
            // 
            // btnSaveSchema
            // 
            this.btnSaveSchema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveSchema.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSchema.Image")));
            this.btnSaveSchema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveSchema.Name = "btnSaveSchema";
            this.btnSaveSchema.Size = new System.Drawing.Size(23, 22);
            this.btnSaveSchema.Text = "Save Schema";
            this.btnSaveSchema.Click += new System.EventHandler(this.btnSaveSchema_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtJson);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtError);
            this.splitContainer2.Size = new System.Drawing.Size(462, 463);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 2;
            // 
            // txtJson
            // 
            this.txtJson.AcceptsTab = true;
            this.txtJson.ConvertTabToSpaces = false;
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJson.Location = new System.Drawing.Point(0, 0);
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(462, 266);
            this.txtJson.TabIndex = 1;
            this.txtJson.TabSize = 4;
            this.txtJson.Text = "Paste Json here...";
            this.txtJson.SelectionChanged += new System.EventHandler(this.txtJson_SelectionChanged);
            // 
            // txtError
            // 
            this.txtError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtError.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.Location = new System.Drawing.Point(0, 0);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(462, 193);
            this.txtError.TabIndex = 0;
            this.txtError.Text = "";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenJson,
            this.btnPasteJson});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(462, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnOpenJson
            // 
            this.btnOpenJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenJson.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenJson.Image")));
            this.btnOpenJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenJson.Name = "btnOpenJson";
            this.btnOpenJson.Size = new System.Drawing.Size(23, 22);
            this.btnOpenJson.Text = "toolStripButton1";
            this.btnOpenJson.ToolTipText = "Load Json from file";
            this.btnOpenJson.Click += new System.EventHandler(this.btnOpenJson_Click);
            // 
            // btnPasteJson
            // 
            this.btnPasteJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPasteJson.Image = ((System.Drawing.Image)(resources.GetObject("btnPasteJson.Image")));
            this.btnPasteJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPasteJson.Name = "btnPasteJson";
            this.btnPasteJson.Size = new System.Drawing.Size(23, 22);
            this.btnPasteJson.Text = "toolStripButton2";
            this.btnPasteJson.ToolTipText = "Paste Json";
            this.btnPasteJson.Click += new System.EventHandler(this.btnPasteJson_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnValidate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnValidate
            // 
            this.btnValidate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnValidate.Image = ((System.Drawing.Image)(resources.GetObject("btnValidate.Image")));
            this.btnValidate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(23, 22);
            this.btnValidate.Text = "toolStripButton1";
            this.btnValidate.ToolTipText = "Validate";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 559);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "JsonSchema Lab";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private TabbedRichTextBox txtSchema;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnValidate;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnLoadSchema;
        private System.Windows.Forms.ToolStripButton btnPasteSchema;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnOpenJson;
        private System.Windows.Forms.ToolStripButton btnPasteJson;
        private System.Windows.Forms.ToolStripButton btnSaveSchema;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSchemaLine;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private TabbedRichTextBox txtJson;
        private System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblJsonLine;
    }
}

