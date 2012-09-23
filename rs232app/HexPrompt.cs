using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rs232app
{
	public partial class HexPrompt : Form
	{
		public byte? b;

		public HexPrompt()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TextBox box = textBox1;
			try
			{
				b = Byte.Parse(box.Text, System.Globalization.NumberStyles.HexNumber);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message);
			}
		}
	}
}
