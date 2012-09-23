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
			this.actSave = new System.Windows.Forms.Button();
			this.actCancel = new System.Windows.Forms.Button();
			this.inputParity = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.inputStopBits = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.inputStopSymbol = new System.Windows.Forms.ComboBox();
			this.inputDataIOControl = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.inputPortSelection = new System.Windows.Forms.ComboBox();
			this.inputDataSpeed = new System.Windows.Forms.ComboBox();
			this.inputNumberOfDataBits = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pongTimeoutInput = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.pongTimeoutInput)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Port:";
			this.label1.UseWaitCursor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Prędkość:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Ilość bitów danych:";
			// 
			// actSave
			// 
			this.actSave.Location = new System.Drawing.Point(12, 238);
			this.actSave.Name = "actSave";
			this.actSave.Size = new System.Drawing.Size(75, 23);
			this.actSave.TabIndex = 11;
			this.actSave.Text = "Zapisz";
			this.actSave.UseVisualStyleBackColor = true;
			this.actSave.Click += new System.EventHandler(this.inputSave_Click);
			// 
			// actCancel
			// 
			this.actCancel.Location = new System.Drawing.Point(199, 239);
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
			this.inputParity.Location = new System.Drawing.Point(152, 91);
			this.inputParity.Name = "inputParity";
			this.inputParity.Size = new System.Drawing.Size(122, 21);
			this.inputParity.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Parzystość:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Bity stopu:";
			// 
			// inputStopBits
			// 
			this.inputStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputStopBits.FormattingEnabled = true;
			this.inputStopBits.Location = new System.Drawing.Point(152, 118);
			this.inputStopBits.Name = "inputStopBits";
			this.inputStopBits.Size = new System.Drawing.Size(122, 21);
			this.inputStopBits.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Znak stopu:";
			// 
			// inputStopSymbol
			// 
			this.inputStopSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputStopSymbol.FormattingEnabled = true;
			this.inputStopSymbol.Location = new System.Drawing.Point(152, 145);
			this.inputStopSymbol.Name = "inputStopSymbol";
			this.inputStopSymbol.Size = new System.Drawing.Size(122, 21);
			this.inputStopSymbol.TabIndex = 20;
			// 
			// inputDataIOControl
			// 
			this.inputDataIOControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputDataIOControl.FormattingEnabled = true;
			this.inputDataIOControl.Location = new System.Drawing.Point(152, 172);
			this.inputDataIOControl.Name = "inputDataIOControl";
			this.inputDataIOControl.Size = new System.Drawing.Size(122, 21);
			this.inputDataIOControl.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 175);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "Kontrola transmisji:";
			// 
			// inputPortSelection
			// 
			this.inputPortSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputPortSelection.FormattingEnabled = true;
			this.inputPortSelection.Location = new System.Drawing.Point(152, 10);
			this.inputPortSelection.Name = "inputPortSelection";
			this.inputPortSelection.Size = new System.Drawing.Size(122, 21);
			this.inputPortSelection.TabIndex = 23;
			// 
			// inputDataSpeed
			// 
			this.inputDataSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputDataSpeed.FormattingEnabled = true;
			this.inputDataSpeed.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200"});
			this.inputDataSpeed.Location = new System.Drawing.Point(152, 37);
			this.inputDataSpeed.Name = "inputDataSpeed";
			this.inputDataSpeed.Size = new System.Drawing.Size(122, 21);
			this.inputDataSpeed.TabIndex = 24;
			// 
			// inputNumberOfDataBits
			// 
			this.inputNumberOfDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputNumberOfDataBits.FormattingEnabled = true;
			this.inputNumberOfDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
			this.inputNumberOfDataBits.Location = new System.Drawing.Point(152, 64);
			this.inputNumberOfDataBits.Name = "inputNumberOfDataBits";
			this.inputNumberOfDataBits.Size = new System.Drawing.Size(122, 21);
			this.inputNumberOfDataBits.TabIndex = 25;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 201);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Czas oczekiwania na pong:";
			// 
			// pongTimeoutInput
			// 
			this.pongTimeoutInput.Location = new System.Drawing.Point(152, 199);
			this.pongTimeoutInput.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.pongTimeoutInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.pongTimeoutInput.Name = "pongTimeoutInput";
			this.pongTimeoutInput.Size = new System.Drawing.Size(120, 20);
			this.pongTimeoutInput.TabIndex = 27;
			this.pongTimeoutInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 273);
			this.Controls.Add(this.pongTimeoutInput);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.inputNumberOfDataBits);
			this.Controls.Add(this.inputDataSpeed);
			this.Controls.Add(this.inputPortSelection);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.inputDataIOControl);
			this.Controls.Add(this.inputStopSymbol);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.inputStopBits);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.inputParity);
			this.Controls.Add(this.actCancel);
			this.Controls.Add(this.actSave);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Settings";
			this.Text = "Ustawienia";
			((System.ComponentModel.ISupportInitialize)(this.pongTimeoutInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button actSave;
        private System.Windows.Forms.Button actCancel;
        private System.Windows.Forms.ComboBox inputParity;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inputStopBits;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox inputStopSymbol;
		private System.Windows.Forms.ComboBox inputDataIOControl;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox inputPortSelection;
		private System.Windows.Forms.ComboBox inputDataSpeed;
		private System.Windows.Forms.ComboBox inputNumberOfDataBits;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown pongTimeoutInput;
    }
}