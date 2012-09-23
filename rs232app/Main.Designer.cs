namespace rs232app
{
    partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.inputToSendData = new System.Windows.Forms.RichTextBox();
			this.intputPing = new System.Windows.Forms.Button();
			this.inputSend = new System.Windows.Forms.Button();
			this.outputRecivedData = new System.Windows.Forms.RichTextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.options = new System.Windows.Forms.ToolStripButton();
			this.clean = new System.Windows.Forms.ToolStripButton();
			this.insertHexValue = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputToSendData
			// 
			this.inputToSendData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputToSendData.Location = new System.Drawing.Point(0, 0);
			this.inputToSendData.Name = "inputToSendData";
			this.inputToSendData.Size = new System.Drawing.Size(645, 269);
			this.inputToSendData.TabIndex = 3;
			this.inputToSendData.Text = "";
			// 
			// intputPing
			// 
			this.intputPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.intputPing.Location = new System.Drawing.Point(558, 234);
			this.intputPing.Name = "intputPing";
			this.intputPing.Size = new System.Drawing.Size(75, 23);
			this.intputPing.TabIndex = 4;
			this.intputPing.Text = "Ping";
			this.intputPing.UseVisualStyleBackColor = true;
			this.intputPing.Click += new System.EventHandler(this.intputPing_Click);
			// 
			// inputSend
			// 
			this.inputSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.inputSend.Location = new System.Drawing.Point(477, 234);
			this.inputSend.Name = "inputSend";
			this.inputSend.Size = new System.Drawing.Size(75, 23);
			this.inputSend.TabIndex = 5;
			this.inputSend.Text = "Wyślij";
			this.inputSend.UseVisualStyleBackColor = true;
			this.inputSend.Click += new System.EventHandler(this.inputSend_Click);
			// 
			// outputRecivedData
			// 
			this.outputRecivedData.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.outputRecivedData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputRecivedData.Location = new System.Drawing.Point(0, 0);
			this.outputRecivedData.Name = "outputRecivedData";
			this.outputRecivedData.ReadOnly = true;
			this.outputRecivedData.Size = new System.Drawing.Size(645, 273);
			this.outputRecivedData.TabIndex = 6;
			this.outputRecivedData.Text = "";
			this.outputRecivedData.TextChanged += new System.EventHandler(this.outputRecivedData_TextChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.outputRecivedData);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.inputSend);
			this.splitContainer1.Panel2.Controls.Add(this.intputPing);
			this.splitContainer1.Panel2.Controls.Add(this.inputToSendData);
			this.splitContainer1.Size = new System.Drawing.Size(645, 546);
			this.splitContainer1.SplitterDistance = 273;
			this.splitContainer1.TabIndex = 7;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options,
            this.clean,
            this.insertHexValue});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(645, 25);
			this.toolStrip1.TabIndex = 8;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// options
			// 
			this.options.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.options.Image = ((System.Drawing.Image)(resources.GetObject("options.Image")));
			this.options.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.options.Name = "options";
			this.options.Size = new System.Drawing.Size(23, 22);
			this.options.Text = "toolStripButton1";
			this.options.Click += new System.EventHandler(this.options_Click);
			// 
			// clean
			// 
			this.clean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.clean.Image = ((System.Drawing.Image)(resources.GetObject("clean.Image")));
			this.clean.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.clean.Name = "clean";
			this.clean.Size = new System.Drawing.Size(23, 22);
			this.clean.Text = "toolStripButton2";
			this.clean.Click += new System.EventHandler(this.clean_Click);
			// 
			// insertHexValue
			// 
			this.insertHexValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.insertHexValue.Image = ((System.Drawing.Image)(resources.GetObject("insertHexValue.Image")));
			this.insertHexValue.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.insertHexValue.Name = "insertHexValue";
			this.insertHexValue.Size = new System.Drawing.Size(23, 22);
			this.insertHexValue.Text = "toolStripButton3";
			this.insertHexValue.Click += new System.EventHandler(this.insertHexValue_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 546);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Main";
			this.Text = "RS232";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.RichTextBox inputToSendData;
        private System.Windows.Forms.Button intputPing;
        private System.Windows.Forms.Button inputSend;
		private System.Windows.Forms.RichTextBox outputRecivedData;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton options;
		private System.Windows.Forms.ToolStripButton clean;
		private System.Windows.Forms.ToolStripButton insertHexValue;
    }
}

