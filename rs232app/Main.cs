using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using rs232app.AppEnum;

namespace rs232app
{
    //TODO: _usedPort.WriteTimeout = 100;
    //TODO: _usedPort.ReadTimeout = 100;

    public partial class Main : Form
    {
        private SerialPort _usedPort;
        private bool _waitForPingResponse = false;
        private BackgroundWorker timeoutWorker;

        private delegate void NoResponseHandler();
        private event NoResponseHandler NoResponseFromDevice;

        public Main()
        {
            InitializeComponent();
            _usedPort = new SerialPort();
            new Settings(this).ShowDialog(this);

			_usedPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            this.NoResponseFromDevice += new NoResponseHandler(NoResponseFromDeviceEvent);
            timeoutWorker = new BackgroundWorker();
            timeoutWorker.WorkerSupportsCancellation = true;
            timeoutWorker.DoWork += new DoWorkEventHandler(WaitForResponse);
		}

        #region User Interface Events
        private void menuOptions_Click(object sender, EventArgs e)
        {
            new Settings(this).Show(this);
        }

        private void intputPing_Click(object sender, EventArgs e)
        {          
            _usedPort.Write(Set.Default.PingRequestMessage);
            NotifyPingSend();
        }

        private void inputSend_Click(object sender, EventArgs e)
        {
            String message = inputToSendData.Text;

            //Adding Stop symbol to the message
            //TODO: _usedPort.NewLine
            byte[] endSymbols = BitConverter.GetBytes((int)Enum.Parse(typeof(StopSymbol), Enum.GetName(typeof(StopSymbol), Set.Default.StopSymbol)));
            for (int i = endSymbols.Length - 1; i >= 0; i--)
            {
                if (endSymbols[i] != 0)
                    message += (char)endSymbols[i];
            }             
            _usedPort.Write(message);
            //TODO: add notification for user that data was sent(in output box)
        }
        #endregion

		#region RS232 events
		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            if (indata.Equals(Set.Default.PingRequestMessage))
            {
                sp.Write(Set.Default.PingResponseMessage);
            }
            else if (indata.Equals(Set.Default.PingResponseMessage))
            {
                NotifyPingResponse();
            }
            else
            {
                outputRecivedData.Text += indata;
            }
		}


        private void WaitForResponse(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            DateTime timeout = DateTime.Now.AddMilliseconds(Set.Default.PingTimeout);

            while ((DateTime.Now < timeout) || (worker.CancellationPending == true))
            {}
            
            e.Cancel = true;

            if (!worker.CancellationPending)
                RaiseEventOnUIThread(NoResponseFromDevice, null);
               
        }
		#endregion

        #region Custom events
        private void RaiseEventOnUIThread(Delegate theEvent, object[] args)
        {
            foreach (Delegate d in theEvent.GetInvocationList())
            {
                ISynchronizeInvoke syncer = d.Target as ISynchronizeInvoke;
                if (syncer == null)
                {
                    d.DynamicInvoke(args);
                }
                else
                {
                    syncer.BeginInvoke(d, args);  // cleanup omitted
                }
            }
        }

        void NoResponseFromDeviceEvent()
        {
            _waitForPingResponse = false;
        }
        #endregion

        #region Notifications
        public void NotifyPingSend()
        {
            if (!_waitForPingResponse)
            {
                _waitForPingResponse = true;
                timeoutWorker.RunWorkerAsync();
            }
        }

        public void NotifyPingResponse()
        {
            if (_waitForPingResponse)
            {
                _waitForPingResponse = false;
                timeoutWorker.CancelAsync();
            }
        }

        public void NotifySettingsChanged()
        {
            _usedPort.Close();
            _usedPort.PortName = Set.Default.PortName;
            _usedPort.Parity = Set.Default.Parity;
            _usedPort.Handshake = Set.Default.Handshake;
            _usedPort.StopBits = Set.Default.StopBits;
            _usedPort.BaudRate = Set.Default.DataSpeed;
            _usedPort.DataBits = Set.Default.NumberOfDataBits;
            _usedPort.Open();
        }
        #endregion

    }
}
