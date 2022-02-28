
namespace LocalImgServer {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.GbxConfig = new System.Windows.Forms.GroupBox();
			this.TlpConfig = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TbxAddr = new System.Windows.Forms.TextBox();
			this.TbxPort = new System.Windows.Forms.TextBox();
			this.TbxDomain = new System.Windows.Forms.TextBox();
			this.BtnRun = new System.Windows.Forms.Button();
			this.LvwFiles = new System.Windows.Forms.ListView();
			this.CmhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TbxLog = new System.Windows.Forms.TextBox();
			this.LblServerPrefix = new System.Windows.Forms.TextBox();
			this.TlpMain.SuspendLayout();
			this.GbxConfig.SuspendLayout();
			this.TlpConfig.SuspendLayout();
			this.SuspendLayout();
			// 
			// TlpMain
			// 
			this.TlpMain.ColumnCount = 2;
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpMain.Controls.Add(this.GbxConfig, 0, 0);
			this.TlpMain.Controls.Add(this.LvwFiles, 1, 0);
			this.TlpMain.Controls.Add(this.TbxLog, 0, 1);
			this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpMain.Location = new System.Drawing.Point(0, 0);
			this.TlpMain.Name = "TlpMain";
			this.TlpMain.RowCount = 2;
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpMain.Size = new System.Drawing.Size(628, 325);
			this.TlpMain.TabIndex = 0;
			// 
			// GbxConfig
			// 
			this.GbxConfig.Controls.Add(this.TlpConfig);
			this.GbxConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GbxConfig.Location = new System.Drawing.Point(3, 3);
			this.GbxConfig.Name = "GbxConfig";
			this.GbxConfig.Size = new System.Drawing.Size(308, 134);
			this.GbxConfig.TabIndex = 0;
			this.GbxConfig.TabStop = false;
			this.GbxConfig.Text = "Server Config";
			// 
			// TlpConfig
			// 
			this.TlpConfig.ColumnCount = 2;
			this.TlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpConfig.Controls.Add(this.label1, 0, 0);
			this.TlpConfig.Controls.Add(this.label2, 0, 1);
			this.TlpConfig.Controls.Add(this.label3, 0, 2);
			this.TlpConfig.Controls.Add(this.TbxAddr, 1, 0);
			this.TlpConfig.Controls.Add(this.TbxPort, 1, 1);
			this.TlpConfig.Controls.Add(this.TbxDomain, 1, 2);
			this.TlpConfig.Controls.Add(this.BtnRun, 0, 4);
			this.TlpConfig.Controls.Add(this.LblServerPrefix, 0, 3);
			this.TlpConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpConfig.Location = new System.Drawing.Point(3, 16);
			this.TlpConfig.Margin = new System.Windows.Forms.Padding(0);
			this.TlpConfig.Name = "TlpConfig";
			this.TlpConfig.RowCount = 5;
			this.TlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TlpConfig.Size = new System.Drawing.Size(302, 115);
			this.TlpConfig.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Network Address:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Port";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Domain";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TbxAddr
			// 
			this.TbxAddr.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TbxAddr.Location = new System.Drawing.Point(154, 3);
			this.TbxAddr.Name = "TbxAddr";
			this.TbxAddr.Size = new System.Drawing.Size(145, 20);
			this.TbxAddr.TabIndex = 4;
			this.TbxAddr.Text = "127.0.0.1";
			this.TbxAddr.TextChanged += new System.EventHandler(this.ServerParam_TextChanged);
			// 
			// TbxPort
			// 
			this.TbxPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TbxPort.Location = new System.Drawing.Point(154, 26);
			this.TbxPort.Name = "TbxPort";
			this.TbxPort.Size = new System.Drawing.Size(145, 20);
			this.TbxPort.TabIndex = 5;
			this.TbxPort.Text = "8080";
			this.TbxPort.TextChanged += new System.EventHandler(this.ServerParam_TextChanged);
			// 
			// TbxDomain
			// 
			this.TbxDomain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TbxDomain.Location = new System.Drawing.Point(154, 49);
			this.TbxDomain.Name = "TbxDomain";
			this.TbxDomain.Size = new System.Drawing.Size(145, 20);
			this.TbxDomain.TabIndex = 6;
			this.TbxDomain.Text = "ImgSvr";
			this.TbxDomain.TextChanged += new System.EventHandler(this.ServerParam_TextChanged);
			// 
			// BtnRun
			// 
			this.BtnRun.BackColor = System.Drawing.Color.LightGreen;
			this.TlpConfig.SetColumnSpan(this.BtnRun, 2);
			this.BtnRun.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRun.Location = new System.Drawing.Point(3, 92);
			this.BtnRun.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(296, 23);
			this.BtnRun.TabIndex = 7;
			this.BtnRun.Text = "Run Server";
			this.BtnRun.UseVisualStyleBackColor = false;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// LvwFiles
			// 
			this.LvwFiles.BackColor = System.Drawing.SystemColors.Control;
			this.LvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CmhName});
			this.LvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LvwFiles.FullRowSelect = true;
			this.LvwFiles.GridLines = true;
			this.LvwFiles.HideSelection = false;
			this.LvwFiles.Location = new System.Drawing.Point(317, 3);
			this.LvwFiles.Name = "LvwFiles";
			this.TlpMain.SetRowSpan(this.LvwFiles, 2);
			this.LvwFiles.Size = new System.Drawing.Size(308, 319);
			this.LvwFiles.TabIndex = 1;
			this.LvwFiles.UseCompatibleStateImageBehavior = false;
			this.LvwFiles.View = System.Windows.Forms.View.Details;
			// 
			// CmhName
			// 
			this.CmhName.Text = "Image Files";
			this.CmhName.Width = 270;
			// 
			// TbxLog
			// 
			this.TbxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TbxLog.Location = new System.Drawing.Point(3, 143);
			this.TbxLog.Multiline = true;
			this.TbxLog.Name = "TbxLog";
			this.TbxLog.ReadOnly = true;
			this.TbxLog.Size = new System.Drawing.Size(308, 179);
			this.TbxLog.TabIndex = 2;
			// 
			// LblServerPrefix
			// 
			this.LblServerPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TlpConfig.SetColumnSpan(this.LblServerPrefix, 2);
			this.LblServerPrefix.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblServerPrefix.Location = new System.Drawing.Point(3, 72);
			this.LblServerPrefix.Name = "LblServerPrefix";
			this.LblServerPrefix.ReadOnly = true;
			this.LblServerPrefix.Size = new System.Drawing.Size(296, 13);
			this.LblServerPrefix.TabIndex = 8;
			this.LblServerPrefix.Text = "http://127.0.0.1:8080/ImgSvr/";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 325);
			this.Controls.Add(this.TlpMain);
			this.Name = "MainForm";
			this.Text = "Simple Local Image Server";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.TlpMain.ResumeLayout(false);
			this.TlpMain.PerformLayout();
			this.GbxConfig.ResumeLayout(false);
			this.TlpConfig.ResumeLayout(false);
			this.TlpConfig.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TlpMain;
		private System.Windows.Forms.GroupBox GbxConfig;
		private System.Windows.Forms.TableLayoutPanel TlpConfig;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TbxAddr;
		private System.Windows.Forms.TextBox TbxPort;
		private System.Windows.Forms.TextBox TbxDomain;
		private System.Windows.Forms.Button BtnRun;
		private System.Windows.Forms.ListView LvwFiles;
		private System.Windows.Forms.TextBox TbxLog;
		private System.Windows.Forms.ColumnHeader CmhName;
		private System.Windows.Forms.TextBox LblServerPrefix;
	}
}

