using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace rs232app
{
    public partial class Main : Form
    {
        private SerialPort _usedPort;

        public Main()
        {
            InitializeComponent();
            _usedPort = new SerialPort();
            new Settings(this).ShowDialog(this);

			_usedPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);		
		}

        #region User Interface Events
        private void menuOptions_Click(object sender, EventArgs e)
        {
            new Settings(this).Show(this);
        }

        private void intputPing_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void inputSend_Click(object sender, EventArgs e)
        {
            _usedPort.Write(inputToSendData.Text);
            //TODO: add notification for user that data was sent(in output box)
        }
        #endregion

		#region RS232 events
		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region Notifications
		public void NotifySettingsChanged()
        {
            _usedPort.PortName = Set.Default.PortName;
            _usedPort.Parity = Set.Default.Parity;
            _usedPort.Handshake = Set.Default.Handshake;
            _usedPort.StopBits = Set.Default.StopBits;
            _usedPort.BaudRate = Set.Default.DataSpeed;
            _usedPort.DataBits = Set.Default.NumberOfDataBits;
        }
        #endregion

    }
}
