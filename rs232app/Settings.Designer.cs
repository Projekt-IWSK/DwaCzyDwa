namespace rs232app
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDataSpeed = new System.Windows.Forms.TextBox();
            this.inputNumberOfDataBits = new System.Windows.Forms.TextBox();
            this.inputPortSelection = new System.Windows.Forms.ListBox();
            this.actSave = new System.Windows.Forms.Button();
            this.actCancel = new System.Windows.Forms.Button();
            this.inputParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputHandshake = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputStopBits = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prędkość:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ilość bitów danych:";
            // 
            // inputDataSpeed
            // 
            this.inputDataSpeed.Location = new System.Drawing.Point(143, 142);
            this.inputDataSpeed.Name = "inputDataSpeed";
            this.inputDataSpeed.Size = new System.Drawing.Size(62, 20);
            this.inputDataSpeed.TabIndex = 8;
            // 
            // inputNumberOfDataBits
            // 
            this.inputNumberOfDataBits.Location = new System.Drawing.Point(143, 168);
            this.inputNumberOfDataBits.Name = "inputNumberOfDataBits";
            this.inputNumberOfDataBits.Size = new System.Drawing.Size(62, 20);
            this.inputNumberOfDataBits.TabIndex = 9;
            // 
            // inputPortSelection
            // 
            this.inputPortSelection.FormattingEnabled = true;
            this.inputPortSelection.Location = new System.Drawing.Point(143, 24);
            this.inputPortSelection.Name = "inputPortSelection";
            this.inputPortSelection.Size = new System.Drawing.Size(129, 95);
            this.inputPortSelection.TabIndex = 10;
            // 
            // actSave
            // 
            this.actSave.Location = new System.Drawing.Point(257, 525);
            this.actSave.Name = "actSave";
            this.actSave.Size = new System.Drawing.Size(75, 23);
            this.actSave.TabIndex = 11;
            this.actSave.Text = "Zapisz";
            this.actSave.UseVisualStyleBackColor = true;
            this.actSave.Click += new System.EventHandler(this.inputSave_Click);
            // 
            // actCancel
            // 
            this.actCancel.Location = new System.Drawing.Point(338, 526);
            this.actCancel.Name = "actCancel";
            this.actCancel.Size = new System.Drawing.Size(75, 22);
            this.actCancel.TabIndex = 12;
            this.actCancel.Text = "Anuluj";
            this.actCancel.UseVisualStyleBackColor = true;
            this.actCancel.Click += new System.EventHandler(this.inputCancel_Click);
            // 
            // inputParity
            // 
            this.inputParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputParity.FormattingEnabled = true;
            this.inputParity.Location = new System.Drawing.Point(143, 198);
            this.inputParity.Name = "inputParity";
            this.inputParity.Size = new System.Drawing.Size(106, 21);
            this.inputParity.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Parzystość:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Handshake";
            // 
            // inputHandshake
            // 
            this.inputHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputHandshake.FormattingEnabled = true;
            this.inputHandshake.Location = new System.Drawing.Point(143, 233);
            this.inputHandshake.Name = "inputHandshake";
            this.inputHandshake.Size = new System.Drawing.Size(106, 21);
            this.inputHandshake.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bity stopu:";
            // 
            // inputStopBits
            // 
            this.inputStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputStopBits.FormattingEnabled = true;
            this.inputStopBits.Location = new System.Drawing.Point(143, 271);
            this.inputStopBits.Name = "inputStopBits";
            this.inputStopBits.Size = new System.Drawing.Size(106, 21);
            this.inputStopBits.TabIndex = 18;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 558);
            this.Controls.Add(this.inputStopBits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputHandshake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputParity);
            this.Controls.Add(this.actCancel);
            this.Controls.Add(this.actSave);
            this.Controls.Add(this.inputPortSelection);
            this.Controls.Add(this.inputNumberOfDataBits);
            this.Controls.Add(this.inputDataSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputDataSpeed;
        private System.Windows.Forms.TextBox inputNumberOfDataBits;
        private System.Windows.Forms.ListBox inputPortSelection;
        private System.Windows.Forms.Button actSave;
        private System.Windows.Forms.Button actCancel;
        private System.Windows.Forms.ComboBox inputParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inputHandshake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inputStopBits;
    }
}