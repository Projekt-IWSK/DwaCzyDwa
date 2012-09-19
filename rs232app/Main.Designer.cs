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
            this.outputRecivedData = new System.Windows.Forms.RichTextBox();
            this.inputToSendData = new System.Windows.Forms.RichTextBox();
            this.intputPing = new System.Windows.Forms.Button();
            this.inputSend = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            // outputRecivedData
            // 
            this.outputRecivedData.Location = new System.Drawing.Point(12, 47);
            this.outputRecivedData.Name = "outputRecivedData";
            this.outputRecivedData.ReadOnly = true;
            this.outputRecivedData.Size = new System.Drawing.Size(606, 309);
            this.outputRecivedData.TabIndex = 2;
            this.outputRecivedData.Text = "";
            // 
            // inputToSendData
            // 
            this.inputToSendData.Location = new System.Drawing.Point(12, 362);
            this.inputToSendData.Name = "inputToSendData";
            this.inputToSendData.Size = new System.Drawing.Size(606, 125);
            this.inputToSendData.TabIndex = 3;
            this.inputToSendData.Text = "";
            // 
            // intputPing
            // 
            this.intputPing.Location = new System.Drawing.Point(452, 511);
            this.intputPing.Name = "intputPing";
            this.intputPing.Size = new System.Drawing.Size(75, 23);
            this.intputPing.TabIndex = 4;
            this.intputPing.Text = "Ping";
            this.intputPing.UseVisualStyleBackColor = true;
            this.intputPing.Click += new System.EventHandler(this.intputPing_Click);
            // 
            // inputSend
            // 
            this.inputSend.Location = new System.Drawing.Point(533, 511);
            this.inputSend.Name = "inputSend";
            this.inputSend.Size = new System.Drawing.Size(75, 23);
            this.inputSend.TabIndex = 5;
            this.inputSend.Text = "Wyślij";
            this.inputSend.UseVisualStyleBackColor = true;
            this.inputSend.Click += new System.EventHandler(this.inputSend_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 546);
            this.Controls.Add(this.inputSend);
            this.Controls.Add(this.intputPing);
            this.Controls.Add(this.inputToSendData);
            this.Controls.Add(this.outputRecivedData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.RichTextBox outputRecivedData;
        private System.Windows.Forms.RichTextBox inputToSendData;
        private System.Windows.Forms.Button intputPing;
        private System.Windows.Forms.Button inputSend;
    }
}

