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
    public partial class Settings : Form
    {
        Main _parent;

        public Settings(Main parent)
        {
            InitializeComponent();

            #region Initialization of controles values
            _parent = parent;

            //Initialize available ports and select current used
            foreach (string s in SerialPort.GetPortNames())
                inputPortSelection.Items.Add(s);
            inputPortSelection.SelectedItem = Set.Default.PortName;

            //Initialize parity, handshake and stop bits
            foreach (string s in Enum.GetNames(typeof(Parity)))
                inputParity.Items.Add(s);
            inputParity.SelectedItem = Enum.GetName(typeof(Parity), Set.Default.Parity);

            foreach (string s in Enum.GetNames(typeof(StopBits)))
                inputStopBits.Items.Add(s);
            inputStopBits.SelectedItem = Enum.GetName(typeof(StopBits), Set.Default.StopBits);

			foreach (string s in Enum.GetNames(typeof(StopSymbol)))
				inputStopSymbol.Items.Add(s);
			inputStopSymbol.SelectedItem = Enum.GetName(typeof(StopSymbol), Set.Default.StopSymbol);

			foreach (string s in Enum.GetNames(typeof(DataIOControl)))
				inputDataIOControl.Items.Add(s);
			inputDataIOControl.SelectedItem = Enum.GetName(typeof(DataIOControl), Set.Default.DataIOControl);

            //Initialize textboxes
			inputDataSpeed.SelectedItem = Set.Default.DataSpeed.ToString();
            
			inputNumberOfDataBits.SelectedItem = Set.Default.NumberOfDataBits.ToString();

			pongTimeoutInput.Value = Set.Default.PingTimeout;


			echoEnabledInput.Checked = Set.Default.EchoEnabled;
            #endregion
        }

        #region User Interface Events
        private void inputSave_Click(object sender, EventArgs e)
        {
            this.SaveNewSettingsValues();
            _parent.NotifySettingsChanged();
            if (this.Modal == true)
                this.Close();
        }

        private void inputCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Logic
        private void SaveNewSettingsValues()
        {
            Set.Default.PortName = inputPortSelection.SelectedItem.ToString();
            Set.Default.Parity = (Parity)Enum.Parse(typeof(Parity), inputParity.SelectedItem.ToString());
            Set.Default.StopBits = (StopBits)Enum.Parse(typeof(StopBits), inputStopBits.SelectedItem.ToString());
            Set.Default.DataSpeed = Convert.ToInt32(inputDataSpeed.SelectedItem);
			Set.Default.NumberOfDataBits = Convert.ToInt32(inputNumberOfDataBits.SelectedItem);
            Set.Default.StopSymbol = (StopSymbol)Enum.Parse(typeof(StopSymbol), inputStopSymbol.SelectedItem.ToString());
			Set.Default.DataIOControl = (DataIOControl)Enum.Parse(typeof(DataIOControl), inputDataIOControl.SelectedItem.ToString());
			Set.Default.PingTimeout = (int)pongTimeoutInput.Value;
			Set.Default.EchoEnabled =echoEnabledInput.Checked;
			Set.Default.Save();
        }
        #endregion
    }
}
