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
			this.inputSend = new System.Windows.Forms.Button();
			this.outputRecivedData = new System.Windows.Forms.RichTextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.outputRecivedDataHex = new System.Windows.Forms.RichTextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.options = new System.Windows.Forms.ToolStripButton();
			this.clean = new System.Windows.Forms.ToolStripButton();
			this.insertHexValue = new System.Windows.Forms.ToolStripButton();
			this.ping = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputToSendData
			// 
			this.inputToSendData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputToSendData.Location = new System.Drawing.Point(0, 0);
			this.inputToSendData.Name = "inputToSendData";
			this.inputToSendData.Size = new System.Drawing.Size(645, 257);
			this.inputToSendData.TabIndex = 3;
			this.inputToSendData.Text = "";
			// 
			// inputSend
			// 
			this.inputSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.inputSend.Location = new System.Drawing.Point(558, 222);
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
			this.outputRecivedData.Location = new System.Drawing.Point(3, 3);
			this.outputRecivedData.Name = "outputRecivedData";
			this.outputRecivedData.ReadOnly = true;
			this.outputRecivedData.Size = new System.Drawing.Size(631, 228);
			this.outputRecivedData.TabIndex = 6;
			this.outputRecivedData.Text = "";
			this.outputRecivedData.TextChanged += new System.EventHandler(this.outputRecivedData_TextChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.inputSend);
			this.splitContainer1.Panel2.Controls.Add(this.inputToSendData);
			this.splitContainer1.Size = new System.Drawing.Size(645, 521);
			this.splitContainer1.SplitterDistance = 260;
			this.splitContainer1.TabIndex = 7;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(645, 260);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.outputRecivedData);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(637, 234);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Tekstowo";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.outputRecivedDataHex);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(637, 234);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Heksadecymalnie";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// outputRecivedDataHex
			// 
			this.outputRecivedDataHex.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.outputRecivedDataHex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputRecivedDataHex.Location = new System.Drawing.Point(3, 3);
			this.outputRecivedDataHex.Name = "outputRecivedDataHex";
			this.outputRecivedDataHex.ReadOnly = true;
			this.outputRecivedDataHex.Size = new System.Drawing.Size(631, 228);
			this.outputRecivedDataHex.TabIndex = 7;
			this.outputRecivedDataHex.Text = "";
			this.outputRecivedDataHex.TextChanged += new System.EventHandler(this.outputRecivedData_TextChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options,
            this.clean,
            this.insertHexValue,
            this.ping});
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
			this.options.Text = "Ustawienia";
			this.options.Click += new System.EventHandler(this.options_Click);
			// 
			// clean
			// 
			this.clean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.clean.Image = ((System.Drawing.Image)(resources.GetObject("clean.Image")));
			this.clean.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.clean.Name = "clean";
			this.clean.Size = new System.Drawing.Size(23, 22);
			this.clean.Text = "Czyść ekran";
			this.clean.Click += new System.EventHandler(this.clean_Click);
			// 
			// insertHexValue
			// 
			this.insertHexValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.insertHexValue.Image = ((System.Drawing.Image)(resources.GetObject("insertHexValue.Image")));
			this.insertHexValue.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.insertHexValue.Name = "insertHexValue";
			this.insertHexValue.Size = new System.Drawing.Size(23, 22);
			this.insertHexValue.Text = "Wstaw symbol";
			this.insertHexValue.Click += new System.EventHandler(this.insertHexValue_Click);
			// 
			// ping
			// 
			this.ping.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ping.Image = ((System.Drawing.Image)(resources.GetObject("ping.Image")));
			this.ping.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ping.Name = "ping";
			this.ping.Size = new System.Drawing.Size(23, 22);
			this.ping.Text = "Ping - pong";
			this.ping.Click += new System.EventHandler(this.ping_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 546);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "RS232";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.RichTextBox inputToSendData;
        private System.Windows.Forms.Button inputSend;
		private System.Windows.Forms.RichTextBox outputRecivedData;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton options;
		private System.Windows.Forms.ToolStripButton clean;
		private System.Windows.Forms.ToolStripButton insertHexValue;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.RichTextBox outputRecivedDataHex;
		private System.Windows.Forms.ToolStripButton ping;
    }
}

