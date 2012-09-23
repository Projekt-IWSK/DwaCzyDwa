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
	public partial class Main : Form
	{
		#region Members
		private SerialPort _usedPort;
		
		private bool isWaitingForPong = false;
		private bool isWaitingForDSR = false;

		//Timery
		System.Timers.Timer pingResponseTimeoutTimer;
		System.Timers.Timer sendTimeoutTimer;

		private delegate void NoResponseHandler();
		private event NoResponseHandler NoResponseFromDevice;
		private event NoResponseHandler NoDtrDsrResponseFromDevice;
		#endregion

		/// <summary>
		/// Tutaj inicjalizujemy podstawowe obiekty i podpinamy customowe eventy. Nic ciekawego.
		/// </summary>
		public Main()
		{
			InitializeComponent();
			//Obiekt reprezentujący port COM.
			_usedPort = new SerialPort();

			//Podpinanie custom eventów etc.
			_usedPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
			this.NoResponseFromDevice += new NoResponseHandler(NotifyNoPingResponse);
			this.NoDtrDsrResponseFromDevice += new NoResponseHandler(NotifyNoResponseFromDevice);
			
			//Tworzenie timerów.
			pingResponseTimeoutTimer = new System.Timers.Timer();
			pingResponseTimeoutTimer.Elapsed += new System.Timers.ElapsedEventHandler(pingTimer_Elapsed);

			sendTimeoutTimer = new System.Timers.Timer();
			sendTimeoutTimer.Elapsed += new System.Timers.ElapsedEventHandler(sendTimer_Elapsed);

			//Wczytanie ustawień domyślnych.
			NotifySettingsChanged();
			//new Settings(this).ShowDialog(this);
		}

		#region User Interface Events	
		/// <summary>
		/// Wciśnięty został przycisk edycji ustawień.
		/// </summary>
		void menuOptions_Click(object sender, EventArgs e)
		{
			new Settings(this).ShowDialog(this);
		}

		/// <summary>
		/// Wciśnięty został przycisk pingowania. Założyłem, że można wysłać tylko jeden ping (chyba
		/// że odebrano ponga lub upłynął czas oczekiwania).
		/// </summary>		
		void intputPing_Click(object sender, EventArgs e)
		{
			//Czy czekamy na ponga?
			if (!isWaitingForPong)
			{
				//Wyślij pinga.
				SendMessage(Set.Default.PingRequestMessage);
				NotifyPingRequestSend();
			}
		}

		/// <summary>
		/// Wciśnięty został przycisk wysyłania danych.
		/// </summary>
		void inputSend_Click(object sender, EventArgs e)
		{
			SendMessage(inputToSendData.Text);
			NotifyMessageSend(inputToSendData.Text);
			inputToSendData.Text = "";
		}

		/// <summary>
		/// Wciśnięty został przycisk czyszczenia okna.
		/// </summary>
		void clean_Click(object sender, EventArgs e)
		{
			outputRecivedData.Text = "";
		}

		/// <summary>
		/// Fix przewijający okno outputu na ostatni wiersz. ;)
		/// </summary>
		void outputRecivedData_TextChanged(object sender, EventArgs e)
		{
			RichTextBox box = sender as RichTextBox;
			box.ScrollToCaret();
		}
		#endregion

		#region RS232 events
		/// <summary>
		/// W buforze znajdują się dane do odczytania.
		/// </summary>
		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			SerialPort sp = (SerialPort)sender;
			string indata = "";

			//Trzeba wybrać odpowiednią metodę do odczytu danych w zależności od wybranego symbolu stopu.
			try
			{
				if (Set.Default.StopSymbol == StopSymbol.None)
				{
					indata = sp.ReadExisting();
				}
				else
				{
					indata = sp.ReadLine();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			//Czy odebraliśmy ping?
			if (indata.Contains(Set.Default.PingRequestMessage))
			{
				NotifyPingRequestReceive();
				SendMessage(Set.Default.PingResponseMessage);
				NotifyPingResponseSend();
			}
			//Czy odebraliśmy pong, na który czekaliśmy?
			else if (indata.Equals(Set.Default.PingResponseMessage) && isWaitingForPong)
			{
				NotifyPingResponseReceive();
			}
			//Odebraliśmy zwykłe dane.
			else
			{
				NotifyMessageReceive(indata);
			}
		}
		#endregion

		#region Custom events
		/// <summary>
		/// Metoda pomocnicza, umożliwiająca aktywację eventów w głównym wątku.
		/// </summary>
		void RaiseEventOnUIThread(Delegate theEvent, object[] args)
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

		/// <summary>
		/// Upłynął czas oczekiwania na pong.
		/// </summary>
		void pingTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			pingResponseTimeoutTimer.Stop();

			//Czy dalej czekamy na odpowiedź?
			if (isWaitingForPong)
			{
				RaiseEventOnUIThread(NoResponseFromDevice, null);
			}
		}

		/// <summary>
		/// Upłynął czas oczekiwania na wysłanie danych (oczekiwania na gotowość drugiego urządzenia).
		/// Wykorzystywane tylko w trybie DSR / DTR.
		/// </summary>
		void sendTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			sendTimeoutTimer.Stop();
			
			//Czy ciągle czekamy na gotowośćdrugiego urządzenia?
			if (isWaitingForDSR)
			{
				RaiseEventOnUIThread(NoDtrDsrResponseFromDevice, null);
			}

		}
		#endregion

		#region Notifications
		
		#region Ping notifications
		void NotifyPingRequestSend()
		{
			isWaitingForPong = true;
			pingResponseTimeoutTimer.Start();
			NotifyIOMessageOnOutput("PING", false);
		}

		void NotifyPingResponseReceive()
		{
			isWaitingForPong = false;
			pingResponseTimeoutTimer.Stop();
			NotifyIOMessageOnOutput("PONG", true);
		}		
		
		void NotifyPingRequestReceive()
		{
			NotifyIOMessageOnOutput("PING", true);
		}

		void NotifyPingResponseSend()
		{
			NotifyIOMessageOnOutput("PONG", false);
		}

		void NotifyNoPingResponse()
		{
			isWaitingForPong = false;
			NotifyErrorOnOutput("BRAK ODPOWIEDZI NA PING");
		}
		#endregion
		
		#region Message notifications
		void NotifyNoResponseFromDevice()
		{
			isWaitingForDSR = false;
			NotifyErrorOnOutput("Urządzenie nie jest gotowe do odbioru (timeout)");
		}
		
		void NotifyMessageSend(string msg)
		{
			NotifyIOMessageOnOutput(msg, false);
		}

		void NotifyMessageReceive(string msg)
		{
			NotifyIOMessageOnOutput(msg, true);
		}

		void NotifyIOMessageOnOutput(string msg, bool isInput = false)
		{
			if (isInput)
			{
				outputRecivedData.SelectionColor = System.Drawing.Color.Blue;
				this.outputRecivedData.AppendText("(receive):");
			}
			else
			{
				outputRecivedData.SelectionColor = System.Drawing.Color.Green;
				this.outputRecivedData.AppendText("(send):");
			}
			outputRecivedData.SelectionColor = System.Drawing.Color.Black;
			this.outputRecivedData.AppendText(msg + Environment.NewLine);
		}

		void NotifyErrorOnOutput(string msg)
		{
			outputRecivedData.SelectionColor = System.Drawing.Color.Red;
			this.outputRecivedData.AppendText("(error):");
			outputRecivedData.SelectionColor = System.Drawing.Color.Black;
			this.outputRecivedData.AppendText(msg);
			if (!msg.EndsWith(Environment.NewLine))
				this.outputRecivedData.AppendText(Environment.NewLine);
		}
		#endregion

		public void NotifySettingsChanged()
		{
			this.Text = "RS232";
			inputSend.Enabled = true;
			intputPing.Enabled = true;
			try
			{
				_usedPort.Close();
				_usedPort.PortName = Set.Default.PortName;
				_usedPort.Parity = Set.Default.Parity;
				_usedPort.StopBits = Set.Default.StopBits;
				_usedPort.BaudRate = Set.Default.DataSpeed;
				_usedPort.DataBits = Set.Default.NumberOfDataBits;

				switch ((Set.Default.StopSymbol))
				{
					case StopSymbol.CR:
						_usedPort.NewLine = "\r";
						break;
					case StopSymbol.LF:
						_usedPort.NewLine = "\n";
						break;
					case StopSymbol.CRLF:
						_usedPort.NewLine = "\r\n";
						break;
					case StopSymbol.None:
						_usedPort.NewLine = "\0";
						break;
				}

				switch ((Set.Default.DataIOControl))
				{
					case DataIOControl.None:
						_usedPort.Handshake = Handshake.None;
						break;
					case DataIOControl.RTS_CTS:
						_usedPort.Handshake = Handshake.RequestToSend;
						break;
					case DataIOControl.DTR_DSR:
						_usedPort.Handshake = Handshake.None;
						_usedPort.DtrEnable = true;
						break;
					case DataIOControl.Program:
						_usedPort.Handshake = Handshake.XOnXOff;
						break;
				}

				_usedPort.ReadTimeout = 10000;
				_usedPort.WriteTimeout = 10000;
				_usedPort.Open();

				//
				pingResponseTimeoutTimer.Interval = Set.Default.PingTimeout;
				sendTimeoutTimer.Interval = 1000;
				this.Text += " - " + Set.Default.PortName;
			}
			catch (Exception ex)
			{
				NotifyErrorOnOutput("Ustawienia są nieprawidłowe");
				NotifyErrorOnOutput(ex.Message);
				inputSend.Enabled = false;
				intputPing.Enabled = false;
			}
		}
		#endregion
		
		void SendMessage(string msg)
		{
			//Dla trybu DTR_DSR.
			if (Set.Default.DataIOControl == DataIOControl.DTR_DSR)
			{
				//Nasze urządzenie nie jest gotowe do odbioru danych - teraz nadaje.
				_usedPort.DtrEnable = false;
				//Flaga oczekiwania na gotowość drugiego urządzenia.
				isWaitingForDSR = true;
				sendTimeoutTimer.Start();

				//Czekamy na wysłanie danych, lub na timeout.
				while (isWaitingForDSR)
				{
					if (_usedPort.DsrHolding == true)
					{
						//Klient jest gotowy.
						sendTimeoutTimer.Stop();
						try
						{
							if (Set.Default.StopSymbol == StopSymbol.None)
							{
								_usedPort.Write(msg);
							}
							else
							{
								_usedPort.WriteLine(msg);
							}
						}
						catch (Exception ex)
						{
							NotifyErrorOnOutput(ex.Message);
						}
						break;
					}
				}

				//Możemy znowu czytać.
				_usedPort.DtrEnable = true;
				//Nie czekamy na gotowość drugiego urządzenia.
				isWaitingForDSR = false;
			}
			else
			{
				//Trochę się powtarzam, ale co tam. ;)
				try
				{
					if (Set.Default.StopSymbol == StopSymbol.None)
					{
						_usedPort.Write(msg);
					}
					else
					{
						_usedPort.WriteLine(msg);
					}
				}
				catch (Exception ex)
				{
					NotifyErrorOnOutput(ex.Message);
				}
			}
		}
	}
}
