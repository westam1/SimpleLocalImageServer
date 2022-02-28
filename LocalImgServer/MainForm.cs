using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocalImgServer {
	/// <summary> Main Form Software class. For now, all code will run from here. </summary>
	public partial class MainForm : Form {
		private const int LOG_MAX = 20;

		private HttpListener m_Svr;
		private BinaryWriter m_Log;
		private string m_ImgDir;
		private int m_DomainSize = 0;
		private readonly Queue<string> m_LBack = new Queue<string>();
		private readonly List<string> m_Images = new List<string>();

		/// <summary> Construct a new form </summary>
		public MainForm() {
			InitializeComponent();

			// Set up bare bones logging.
			m_Log = new BinaryWriter(File.Open("log.txt", FileMode.OpenOrCreate));
			m_Log.BaseStream.Position = 0;

			Log("Application started");

			// Set up and validate images directory
			m_ImgDir = Application.StartupPath + "\\" + "Images";
			if (!Directory.Exists(m_ImgDir)) {
				Directory.CreateDirectory(m_ImgDir);
			}

			// Check to make sure we can actually do our thing
			if (!HttpListener.IsSupported) {	// From MS Documentation
				Log("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
				BtnRun.Enabled = false;
				BtnRun.BackColor = Color.Red;
			}

			// Pre-populate DNS local name
			TbxAddr.Text = Dns.GetHostName();

			// Last, display files
			DisplayFiles();
		}
		/// <summary> When the Server form is closing, perform proper cleanup. </summary>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (m_Log != null) { m_Log.Close(); }
			if (m_Svr != null) { m_Svr.Stop(); }
		}

		/// <summary> Callback for incoming calls. Does the heavy lifting. </summary>
		/// <param name="result"> Async parameters. </param>
		public void ContextCallback(IAsyncResult result) {
			try {
				byte[] data = new byte[1000];
				string requestStr;
				int respLen = 0, valid;

				// Call EndGetContext to complete the asynchronous operation.
				HttpListenerContext context = m_Svr.EndGetContext(result);
				HttpListenerRequest request = context.Request;

				// Obtain a response object.
				HttpListenerResponse response = context.Response;

				// Construct a response.
				string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
				byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

				// Search for image record
				requestStr = m_ImgDir + "\\" + request.RawUrl.Substring(m_DomainSize);			// Note: Clunky but fast
				if (File.Exists(requestStr)) {
					using (BinaryReader reader = new BinaryReader(File.Open(requestStr, FileMode.Open))) {
						while (respLen < reader.BaseStream.Length) {
							valid = reader.Read(data, 0, data.Length);
							response.OutputStream.Write(data, 0, valid);
							respLen += valid;
						}
						response.OutputStream.Flush();
						response.OutputStream.Close();
					}
				}

				m_Svr.BeginGetContext(new AsyncCallback(ContextCallback), m_Svr);
			}
			catch (Exception ex) {
				Log("Async Callback encountered an error. " + ex.Message);
			}
		}
		/// <summary> Populate files listview with file names for user reference. Only called at startup. </summary>
		public void DisplayFiles() {
			string[] files = Directory.GetFiles(m_ImgDir);

			LvwFiles.BeginUpdate();
			LvwFiles.Items.Clear();
			m_Images.Clear();
			foreach (string file in files) {
				string rawName = file.Substring(file.LastIndexOf("\\") + 1);
				LvwFiles.Items.Add(new ListViewItem(rawName));
				m_Images.Add(rawName);

			}
			LvwFiles.EndUpdate();
		}

		/// <summary> Run Server/Stop Server button </summary>
		private void BtnRun_Click(object sender, EventArgs e) {
			if (m_Svr == null || !m_Svr.IsListening) {
				// Initialize and run server
				if (m_Svr != null) {
					m_Svr.Stop();
					m_Svr.Close();
				}
				m_Svr = new HttpListener();
				m_Svr.Prefixes.Clear();
				m_Svr.Prefixes.Add(LblServerPrefix.Text);
				m_Svr.Start();
				m_Svr.BeginGetContext(new AsyncCallback(ContextCallback), m_Svr);

				// Cosmetic
				BtnRun.BackColor = Color.Yellow;
				BtnRun.Text = "Stop Server";
				TbxAddr.Enabled = TbxDomain.Enabled = TbxPort.Enabled = false;
				m_DomainSize = TbxDomain.Text.Length + 2;

				// Logging
				Log("Server started with domain " + LblServerPrefix.Text);
			} else {
				m_Svr.Stop();

				// Cosmetic
				BtnRun.BackColor = Color.LightGreen;
				BtnRun.Text = "Run Server";
				TbxAddr.Enabled = TbxDomain.Enabled = TbxPort.Enabled = true;

				// Logging
				Log("Server stopped");
			}
		}
		/// <summary> Update server resource string on text change. </summary>
		private void ServerParam_TextChanged(object sender, EventArgs e) {
			IPAddress addr;
			int port;

			if (TryParse(TbxAddr, out addr) && TryParse(TbxPort, out port)) {
				LblServerPrefix.Text = "http://" + TbxAddr.Text + ":" + port.ToString() + "/" + TbxDomain.Text + "/";
			}
		}

		/// <summary> Barebones logging. This is ugly and inefficient but the server should be low-demand due to it's local nature. </summary>
		/// <param name="Text"> The string to be logged. </param>
		private void Log(string Text) {
			if (InvokeRequired) {
				BeginInvoke(new MethodInvoker(delegate () { Log(Text); }));
			} else {
				string output = "";

				Text = "[ " + DateTime.Now.ToString("hh:mm:ss") + " ]  " + Text + "\r\n";
				m_Log.Write(Text.ToCharArray());

				m_LBack.Enqueue(Text);
				if (m_LBack.Count > LOG_MAX) { m_LBack.Dequeue(); }

				foreach (string log in m_LBack) {
					output += log;
				}

				TbxLog.Text = output;
			}
		}
		/// <summary> Try to parse a value from a textbox. If parse fails, alert user. </summary>
		/// <typeparam name="T"> The type of the data being parsed. </typeparam>
		/// <param name="Tbx"> The textbox containing the string to be parsed. </param>
		/// <param name="Obj"> The return value, if parsing is successful. </param>
		/// <returns> True if the parse succeeded. Otherwise, returns false. </returns>
		private bool TryParse<T>(TextBox Tbx, out T Obj) {
			try {
				Tbx.BackColor = Color.White;

				if (typeof(T) == typeof(IPAddress)) {
					IPAddress[] addrs = Dns.GetHostAddresses(Tbx.Text);

					if (addrs.Length != 0) {
						int ipv4Addr = -1;
						for (int i = 0; i < addrs.Length; i++) {
							if (addrs[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
								ipv4Addr = i;
							}
						}

						if (ipv4Addr != -1) {
							Obj = (T)Convert.ChangeType(addrs[ipv4Addr], typeof(T));
						} else {
							Obj = (T)Convert.ChangeType(IPAddress.Parse(Tbx.Text), typeof(T));
						}
					} else {
						Obj = (T)Convert.ChangeType(IPAddress.Parse(Tbx.Text), typeof(T));
					}
				} else {
					Obj = (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(null, CultureInfo.InvariantCulture, Tbx.Text);
				}

				return true;
			}
			catch {
				Tbx.BackColor = Color.Red;
			}
			Obj = default;
			return false;
		}
	}
}