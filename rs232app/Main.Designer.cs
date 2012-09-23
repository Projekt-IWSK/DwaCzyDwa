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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.inputToSendData = new System.Windows.Forms.RichTextBox();
			this.intputPing = new System.Windows.Forms.Button();
			this.inputSend = new System.Windows.Forms.Button();
			this.outputRecivedData = new System.Windows.Forms.RichTextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.cleanButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuOptions});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(645, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(38, 20);
			this.menuFile.Text = "Plik";
			// 
			// menuOptions
			// 
			this.menuOptions.Name = "menuOptions";
			this.menuOptions.Size = new System.Drawing.Size(50, 20);
			this.menuOptions.Text = "Opcje";
			this.menuOptions.Click += new System.EventHandler(this.menuOptions_Click);
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
			// intputPing
			// 
			this.intputPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.intputPing.Location = new System.Drawing.Point(486, 222);
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
			this.inputSend.Location = new System.Drawing.Point(405, 222);
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
			this.outputRecivedData.Size = new System.Drawing.Size(645, 261);
			this.outputRecivedData.TabIndex = 6;
			this.outputRecivedData.Text = "";
			this.outputRecivedData.TextChanged += new System.EventHandler(this.outputRecivedData_TextChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.outputRecivedData);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.cleanButton);
			this.splitContainer1.Panel2.Controls.Add(this.inputSend);
			this.splitContainer1.Panel2.Controls.Add(this.intputPing);
			this.splitContainer1.Panel2.Controls.Add(this.inputToSendData);
			this.splitContainer1.Size = new System.Drawing.Size(645, 522);
			this.splitContainer1.SplitterDistance = 261;
			this.splitContainer1.TabIndex = 7;
			// 
			// cleanButton
			// 
			this.cleanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cleanButton.Location = new System.Drawing.Point(567, 222);
			this.cleanButton.Name = "cleanButton";
			this.cleanButton.Size = new System.Drawing.Size(75, 23);
			this.cleanButton.TabIndex = 6;
			this.cleanButton.Text = "Czyść";
			this.cleanButton.UseVisualStyleBackColor = true;
			this.cleanButton.Click += new System.EventHandler(this.clean_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 546);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.RichTextBox inputToSendData;
        private System.Windows.Forms.Button intputPing;
        private System.Windows.Forms.Button inputSend;
		private System.Windows.Forms.RichTextBox outputRecivedData;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button cleanButton;
    }
}

