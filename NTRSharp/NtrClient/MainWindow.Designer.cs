﻿namespace NewNtrClient
{
	partial class MainWindow
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
            this.ContentTable = new System.Windows.Forms.TableLayoutPanel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.autoProcs = new System.Windows.Forms.CheckBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonMemregions = new System.Windows.Forms.Button();
            this.buttonDumpAll = new System.Windows.Forms.Button();
            this.cbEditModeLittleEndian = new System.Windows.Forms.CheckBox();
            this.buttonEditModeWriteHex = new System.Windows.Forms.Button();
            this.txtEditModeDecimal = new System.Windows.Forms.TextBox();
            this.txtEditModeHex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEditModeWriteDecimal = new System.Windows.Forms.Button();
            this.buttonEditModeRead = new System.Windows.Forms.Button();
            this.cmbEditModeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditModeAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDumpMemoryConsole = new System.Windows.Forms.Button();
            this.buttonDumpMemoryFile = new System.Windows.Forms.Button();
            this.txtDumpMemAddrLength = new System.Windows.Forms.TextBox();
            this.txtDumpMemAddrStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonBaseHelp = new System.Windows.Forms.Button();
            this.buttonBaseClipboardPaste = new System.Windows.Forms.Button();
            this.buttonBaseClipboardCopy = new System.Windows.Forms.Button();
            this.buttonUseBaseCode = new System.Windows.Forms.Button();
            this.txtBaseCode = new System.Windows.Forms.TextBox();
            this.buttonCreateBaseCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaseLength = new System.Windows.Forms.TextBox();
            this.txtBaseAddress = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPointer = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEditorLength = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEditorOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonEditorCreate = new System.Windows.Forms.Button();
            this.buttonEditorUse = new System.Windows.Forms.Button();
            this.buttonEditorHelp = new System.Windows.Forms.Button();
            this.buttonEditorEncrypt = new System.Windows.Forms.Button();
            this.buttonEditorDecrypt = new System.Windows.Forms.Button();
            this.txtEditorAddress = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEditorBase = new System.Windows.Forms.TextBox();
            this.txtEditorByte = new System.Windows.Forms.TextBox();
            this.cmbMemlayout = new System.Windows.Forms.ComboBox();
            this.cmbProcesses = new System.Windows.Forms.ComboBox();
            this.buttonProcesses = new System.Windows.Forms.Button();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnecttrueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectfalseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorkDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ContentTable.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentTable
            // 
            this.ContentTable.ColumnCount = 1;
            this.ContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContentTable.Controls.Add(this.txtOutput, 0, 0);
            this.ContentTable.Controls.Add(this.ContentPanel, 0, 1);
            this.ContentTable.Controls.Add(this.pgbProgress, 0, 2);
            this.ContentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTable.Location = new System.Drawing.Point(0, 24);
            this.ContentTable.Name = "ContentTable";
            this.ContentTable.RowCount = 3;
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.34829F));
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.65171F));
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContentTable.Size = new System.Drawing.Size(758, 578);
            this.ContentTable.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(752, 319);
            this.txtOutput.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.autoProcs);
            this.ContentPanel.Controls.Add(this.portBox);
            this.ContentPanel.Controls.Add(this.tabControl1);
            this.ContentPanel.Controls.Add(this.cmbMemlayout);
            this.ContentPanel.Controls.Add(this.cmbProcesses);
            this.ContentPanel.Controls.Add(this.buttonProcesses);
            this.ContentPanel.Controls.Add(this.txtIpAddress);
            this.ContentPanel.Controls.Add(this.buttonConnect);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(3, 325);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(752, 232);
            this.ContentPanel.TabIndex = 1;
            // 
            // autoProcs
            // 
            this.autoProcs.AutoSize = true;
            this.autoProcs.Checked = true;
            this.autoProcs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoProcs.Location = new System.Drawing.Point(215, 12);
            this.autoProcs.Name = "autoProcs";
            this.autoProcs.Size = new System.Drawing.Size(47, 17);
            this.autoProcs.TabIndex = 8;
            this.autoProcs.Text = "auto";
            this.autoProcs.UseVisualStyleBackColor = true;
            // 
            // portBox
            // 
            this.portBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.portBox.Location = new System.Drawing.Point(118, 8);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(38, 23);
            this.portBox.TabIndex = 2;
            this.portBox.Text = "8000";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 195);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonMemregions);
            this.tabPage1.Controls.Add(this.buttonDumpAll);
            this.tabPage1.Controls.Add(this.cbEditModeLittleEndian);
            this.tabPage1.Controls.Add(this.buttonEditModeWriteHex);
            this.tabPage1.Controls.Add(this.txtEditModeDecimal);
            this.tabPage1.Controls.Add(this.txtEditModeHex);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.buttonEditModeWriteDecimal);
            this.tabPage1.Controls.Add(this.buttonEditModeRead);
            this.tabPage1.Controls.Add(this.cmbEditModeType);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtEditModeAddress);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonDumpMemoryConsole);
            this.tabPage1.Controls.Add(this.buttonDumpMemoryFile);
            this.tabPage1.Controls.Add(this.txtDumpMemAddrLength);
            this.tabPage1.Controls.Add(this.txtDumpMemAddrStart);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 164);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonMemregions
            // 
            this.buttonMemregions.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemregions.Location = new System.Drawing.Point(570, 49);
            this.buttonMemregions.Name = "buttonMemregions";
            this.buttonMemregions.Size = new System.Drawing.Size(168, 23);
            this.buttonMemregions.TabIndex = 22;
            this.buttonMemregions.Text = "Read Memregions";
            this.buttonMemregions.UseVisualStyleBackColor = true;
            this.buttonMemregions.Click += new System.EventHandler(this.buttonMemregions_Click);
            // 
            // buttonDumpAll
            // 
            this.buttonDumpAll.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDumpAll.Location = new System.Drawing.Point(570, 134);
            this.buttonDumpAll.Name = "buttonDumpAll";
            this.buttonDumpAll.Size = new System.Drawing.Size(169, 23);
            this.buttonDumpAll.TabIndex = 21;
            this.buttonDumpAll.Text = "Dump all Memregions";
            this.buttonDumpAll.UseVisualStyleBackColor = true;
            this.buttonDumpAll.Click += new System.EventHandler(this.buttonDumpAll_Click);
            // 
            // cbEditModeLittleEndian
            // 
            this.cbEditModeLittleEndian.AutoSize = true;
            this.cbEditModeLittleEndian.Checked = true;
            this.cbEditModeLittleEndian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEditModeLittleEndian.Location = new System.Drawing.Point(109, 134);
            this.cbEditModeLittleEndian.Name = "cbEditModeLittleEndian";
            this.cbEditModeLittleEndian.Size = new System.Drawing.Size(117, 19);
            this.cbEditModeLittleEndian.TabIndex = 15;
            this.cbEditModeLittleEndian.Text = "Little Endian";
            this.cbEditModeLittleEndian.UseVisualStyleBackColor = true;
            // 
            // buttonEditModeWriteHex
            // 
            this.buttonEditModeWriteHex.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditModeWriteHex.Location = new System.Drawing.Point(177, 58);
            this.buttonEditModeWriteHex.Name = "buttonEditModeWriteHex";
            this.buttonEditModeWriteHex.Size = new System.Drawing.Size(62, 23);
            this.buttonEditModeWriteHex.TabIndex = 19;
            this.buttonEditModeWriteHex.Text = "Write";
            this.buttonEditModeWriteHex.UseVisualStyleBackColor = true;
            this.buttonEditModeWriteHex.Click += new System.EventHandler(this.buttonEditModeWriteHex_Click);
            // 
            // txtEditModeDecimal
            // 
            this.txtEditModeDecimal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditModeDecimal.Location = new System.Drawing.Point(109, 29);
            this.txtEditModeDecimal.MaxLength = 10;
            this.txtEditModeDecimal.Name = "txtEditModeDecimal";
            this.txtEditModeDecimal.Size = new System.Drawing.Size(63, 23);
            this.txtEditModeDecimal.TabIndex = 16;
            this.txtEditModeDecimal.Text = "0";
            this.txtEditModeDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEditModeHex
            // 
            this.txtEditModeHex.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditModeHex.Location = new System.Drawing.Point(109, 58);
            this.txtEditModeHex.MaxLength = 8;
            this.txtEditModeHex.Name = "txtEditModeHex";
            this.txtEditModeHex.Size = new System.Drawing.Size(63, 23);
            this.txtEditModeHex.TabIndex = 18;
            this.txtEditModeHex.Text = "00000000";
            this.txtEditModeHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEditModeHex.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateHex32);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 61);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hexadecimal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 32);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Decimal";
            // 
            // buttonEditModeWriteDecimal
            // 
            this.buttonEditModeWriteDecimal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditModeWriteDecimal.Location = new System.Drawing.Point(178, 29);
            this.buttonEditModeWriteDecimal.Name = "buttonEditModeWriteDecimal";
            this.buttonEditModeWriteDecimal.Size = new System.Drawing.Size(61, 23);
            this.buttonEditModeWriteDecimal.TabIndex = 17;
            this.buttonEditModeWriteDecimal.Text = "Write";
            this.buttonEditModeWriteDecimal.UseVisualStyleBackColor = true;
            this.buttonEditModeWriteDecimal.Click += new System.EventHandler(this.buttonEditModeWriteDecimal_Click);
            // 
            // buttonEditModeRead
            // 
            this.buttonEditModeRead.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditModeRead.Location = new System.Drawing.Point(244, 86);
            this.buttonEditModeRead.Name = "buttonEditModeRead";
            this.buttonEditModeRead.Size = new System.Drawing.Size(47, 23);
            this.buttonEditModeRead.TabIndex = 14;
            this.buttonEditModeRead.Text = "Read";
            this.buttonEditModeRead.UseVisualStyleBackColor = true;
            this.buttonEditModeRead.Click += new System.EventHandler(this.buttonEditModeRead_Click);
            // 
            // cmbEditModeType
            // 
            this.cmbEditModeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditModeType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditModeType.FormattingEnabled = true;
            this.cmbEditModeType.Items.AddRange(new object[] {
            "Byte",
            "UInt16",
            "UInt32"});
            this.cmbEditModeType.Location = new System.Drawing.Point(177, 86);
            this.cmbEditModeType.Name = "cmbEditModeType";
            this.cmbEditModeType.Size = new System.Drawing.Size(62, 22);
            this.cmbEditModeType.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 3);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Length";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 3);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEditModeAddress
            // 
            this.txtEditModeAddress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditModeAddress.Location = new System.Drawing.Point(109, 86);
            this.txtEditModeAddress.MaxLength = 8;
            this.txtEditModeAddress.Name = "txtEditModeAddress";
            this.txtEditModeAddress.Size = new System.Drawing.Size(62, 23);
            this.txtEditModeAddress.TabIndex = 12;
            this.txtEditModeAddress.Text = "00000000";
            this.txtEditModeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEditModeAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateHex32);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Write Memory";
            // 
            // buttonDumpMemoryConsole
            // 
            this.buttonDumpMemoryConsole.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDumpMemoryConsole.Location = new System.Drawing.Point(570, 110);
            this.buttonDumpMemoryConsole.Name = "buttonDumpMemoryConsole";
            this.buttonDumpMemoryConsole.Size = new System.Drawing.Size(169, 23);
            this.buttonDumpMemoryConsole.TabIndex = 11;
            this.buttonDumpMemoryConsole.Text = "Dump to Console";
            this.buttonDumpMemoryConsole.UseVisualStyleBackColor = true;
            this.buttonDumpMemoryConsole.Click += new System.EventHandler(this.buttonDumpMemoryConsole_Click);
            // 
            // buttonDumpMemoryFile
            // 
            this.buttonDumpMemoryFile.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDumpMemoryFile.Location = new System.Drawing.Point(570, 86);
            this.buttonDumpMemoryFile.Name = "buttonDumpMemoryFile";
            this.buttonDumpMemoryFile.Size = new System.Drawing.Size(168, 23);
            this.buttonDumpMemoryFile.TabIndex = 10;
            this.buttonDumpMemoryFile.Text = "Dump as File";
            this.buttonDumpMemoryFile.UseVisualStyleBackColor = true;
            this.buttonDumpMemoryFile.Click += new System.EventHandler(this.buttonDumpMemoryFile_Click);
            // 
            // txtDumpMemAddrLength
            // 
            this.txtDumpMemAddrLength.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDumpMemAddrLength.Location = new System.Drawing.Point(657, 21);
            this.txtDumpMemAddrLength.MaxLength = 8;
            this.txtDumpMemAddrLength.Name = "txtDumpMemAddrLength";
            this.txtDumpMemAddrLength.Size = new System.Drawing.Size(80, 23);
            this.txtDumpMemAddrLength.TabIndex = 8;
            this.txtDumpMemAddrLength.Text = "00000000";
            this.txtDumpMemAddrLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDumpMemAddrLength.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateHex32);
            // 
            // txtDumpMemAddrStart
            // 
            this.txtDumpMemAddrStart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDumpMemAddrStart.Location = new System.Drawing.Point(571, 21);
            this.txtDumpMemAddrStart.MaxLength = 8;
            this.txtDumpMemAddrStart.Name = "txtDumpMemAddrStart";
            this.txtDumpMemAddrStart.Size = new System.Drawing.Size(80, 23);
            this.txtDumpMemAddrStart.TabIndex = 7;
            this.txtDumpMemAddrStart.Text = "00000000";
            this.txtDumpMemAddrStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDumpMemAddrStart.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateHex32);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dump Memory";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonBaseHelp);
            this.tabPage2.Controls.Add(this.buttonBaseClipboardPaste);
            this.tabPage2.Controls.Add(this.buttonBaseClipboardCopy);
            this.tabPage2.Controls.Add(this.buttonUseBaseCode);
            this.tabPage2.Controls.Add(this.txtBaseCode);
            this.tabPage2.Controls.Add(this.buttonCreateBaseCode);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtBaseLength);
            this.tabPage2.Controls.Add(this.txtBaseAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 164);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base64 Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonBaseHelp
            // 
            this.buttonBaseHelp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaseHelp.Location = new System.Drawing.Point(708, 6);
            this.buttonBaseHelp.Name = "buttonBaseHelp";
            this.buttonBaseHelp.Size = new System.Drawing.Size(36, 23);
            this.buttonBaseHelp.TabIndex = 13;
            this.buttonBaseHelp.Text = "[?]";
            this.buttonBaseHelp.UseVisualStyleBackColor = true;
            this.buttonBaseHelp.Click += new System.EventHandler(this.buttonBaseHelp_Click);
            // 
            // buttonBaseClipboardPaste
            // 
            this.buttonBaseClipboardPaste.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaseClipboardPaste.Location = new System.Drawing.Point(614, 7);
            this.buttonBaseClipboardPaste.Name = "buttonBaseClipboardPaste";
            this.buttonBaseClipboardPaste.Size = new System.Drawing.Size(88, 23);
            this.buttonBaseClipboardPaste.TabIndex = 12;
            this.buttonBaseClipboardPaste.Text = "Paste";
            this.buttonBaseClipboardPaste.UseVisualStyleBackColor = true;
            this.buttonBaseClipboardPaste.Click += new System.EventHandler(this.buttonBaseClipboardPaste_Click);
            // 
            // buttonBaseClipboardCopy
            // 
            this.buttonBaseClipboardCopy.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaseClipboardCopy.Location = new System.Drawing.Point(520, 7);
            this.buttonBaseClipboardCopy.Name = "buttonBaseClipboardCopy";
            this.buttonBaseClipboardCopy.Size = new System.Drawing.Size(88, 23);
            this.buttonBaseClipboardCopy.TabIndex = 11;
            this.buttonBaseClipboardCopy.Text = "Copy";
            this.buttonBaseClipboardCopy.UseVisualStyleBackColor = true;
            this.buttonBaseClipboardCopy.Click += new System.EventHandler(this.buttonBaseClipboardCopy_Click);
            // 
            // buttonUseBaseCode
            // 
            this.buttonUseBaseCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUseBaseCode.Location = new System.Drawing.Point(331, 6);
            this.buttonUseBaseCode.Name = "buttonUseBaseCode";
            this.buttonUseBaseCode.Size = new System.Drawing.Size(93, 23);
            this.buttonUseBaseCode.TabIndex = 10;
            this.buttonUseBaseCode.Text = "Use Code";
            this.buttonUseBaseCode.UseVisualStyleBackColor = true;
            this.buttonUseBaseCode.Click += new System.EventHandler(this.buttonUseBaseCode_Click);
            // 
            // txtBaseCode
            // 
            this.txtBaseCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBaseCode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseCode.Location = new System.Drawing.Point(3, 33);
            this.txtBaseCode.Multiline = true;
            this.txtBaseCode.Name = "txtBaseCode";
            this.txtBaseCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBaseCode.Size = new System.Drawing.Size(738, 128);
            this.txtBaseCode.TabIndex = 14;
            // 
            // buttonCreateBaseCode
            // 
            this.buttonCreateBaseCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateBaseCode.Location = new System.Drawing.Point(232, 6);
            this.buttonCreateBaseCode.Name = "buttonCreateBaseCode";
            this.buttonCreateBaseCode.Size = new System.Drawing.Size(93, 23);
            this.buttonCreateBaseCode.TabIndex = 9;
            this.buttonCreateBaseCode.Text = "Create Code";
            this.buttonCreateBaseCode.UseVisualStyleBackColor = true;
            this.buttonCreateBaseCode.Click += new System.EventHandler(this.buttonCreateBaseCode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create Code";
            // 
            // txtBaseLength
            // 
            this.txtBaseLength.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseLength.Location = new System.Drawing.Point(164, 6);
            this.txtBaseLength.MaxLength = 8;
            this.txtBaseLength.Name = "txtBaseLength";
            this.txtBaseLength.Size = new System.Drawing.Size(62, 23);
            this.txtBaseLength.TabIndex = 8;
            this.txtBaseLength.Text = "00000000";
            this.txtBaseLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBaseLength.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateHex32);
            // 
            // txtBaseAddress
            // 
            this.txtBaseAddress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseAddress.Location = new System.Drawing.Point(96, 6);
            this.txtBaseAddress.MaxLength = 8;
            this.txtBaseAddress.Name = "txtBaseAddress";
            this.txtBaseAddress.Size = new System.Drawing.Size(62, 23);
            this.txtBaseAddress.TabIndex = 7;
            this.txtBaseAddress.Text = "00000000";
            this.txtBaseAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBaseAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateHex32);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(744, 164);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Code Creator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.37975F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.62025F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 158);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPointer);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtEditorLength);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtEditorOffset);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonEditorCreate);
            this.panel1.Controls.Add(this.buttonEditorUse);
            this.panel1.Controls.Add(this.buttonEditorHelp);
            this.panel1.Controls.Add(this.buttonEditorEncrypt);
            this.panel1.Controls.Add(this.buttonEditorDecrypt);
            this.panel1.Controls.Add(this.txtEditorAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 48);
            this.panel1.TabIndex = 0;
            // 
            // cbPointer
            // 
            this.cbPointer.AutoSize = true;
            this.cbPointer.Location = new System.Drawing.Point(205, 19);
            this.cbPointer.Name = "cbPointer";
            this.cbPointer.Size = new System.Drawing.Size(75, 19);
            this.cbPointer.TabIndex = 10;
            this.cbPointer.Text = "Pointer";
            this.cbPointer.UseVisualStyleBackColor = true;
            this.cbPointer.CheckedChanged += new System.EventHandler(this.cbPointer_CheckedChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(141, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Length";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEditorLength
            // 
            this.txtEditorLength.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorLength.Location = new System.Drawing.Point(141, 19);
            this.txtEditorLength.MaxLength = 8;
            this.txtEditorLength.Name = "txtEditorLength";
            this.txtEditorLength.Size = new System.Drawing.Size(62, 23);
            this.txtEditorLength.TabIndex = 9;
            this.txtEditorLength.Text = "00000000";
            this.txtEditorLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(73, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Offset";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEditorOffset
            // 
            this.txtEditorOffset.Enabled = false;
            this.txtEditorOffset.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorOffset.Location = new System.Drawing.Point(73, 19);
            this.txtEditorOffset.MaxLength = 8;
            this.txtEditorOffset.Name = "txtEditorOffset";
            this.txtEditorOffset.Size = new System.Drawing.Size(62, 23);
            this.txtEditorOffset.TabIndex = 8;
            this.txtEditorOffset.Text = "00000000";
            this.txtEditorOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEditorOffset.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateHex32);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(5, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Address";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonEditorCreate
            // 
            this.buttonEditorCreate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditorCreate.Location = new System.Drawing.Point(377, 3);
            this.buttonEditorCreate.Name = "buttonEditorCreate";
            this.buttonEditorCreate.Size = new System.Drawing.Size(85, 23);
            this.buttonEditorCreate.TabIndex = 13;
            this.buttonEditorCreate.Text = "Create Code";
            this.buttonEditorCreate.UseVisualStyleBackColor = true;
            this.buttonEditorCreate.Click += new System.EventHandler(this.buttonEditorCreate_Click);
            // 
            // buttonEditorUse
            // 
            this.buttonEditorUse.Location = new System.Drawing.Point(377, 25);
            this.buttonEditorUse.Name = "buttonEditorUse";
            this.buttonEditorUse.Size = new System.Drawing.Size(85, 23);
            this.buttonEditorUse.TabIndex = 14;
            this.buttonEditorUse.Text = "Use Code";
            this.buttonEditorUse.UseVisualStyleBackColor = true;
            this.buttonEditorUse.Click += new System.EventHandler(this.buttonEditorUse_Click);
            // 
            // buttonEditorHelp
            // 
            this.buttonEditorHelp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditorHelp.Location = new System.Drawing.Point(702, 3);
            this.buttonEditorHelp.Name = "buttonEditorHelp";
            this.buttonEditorHelp.Size = new System.Drawing.Size(36, 23);
            this.buttonEditorHelp.TabIndex = 19;
            this.buttonEditorHelp.Text = "[?]";
            this.buttonEditorHelp.UseVisualStyleBackColor = true;
            // 
            // buttonEditorEncrypt
            // 
            this.buttonEditorEncrypt.Location = new System.Drawing.Point(286, 3);
            this.buttonEditorEncrypt.Name = "buttonEditorEncrypt";
            this.buttonEditorEncrypt.Size = new System.Drawing.Size(85, 23);
            this.buttonEditorEncrypt.TabIndex = 11;
            this.buttonEditorEncrypt.Text = "Encrypt";
            this.buttonEditorEncrypt.UseVisualStyleBackColor = true;
            this.buttonEditorEncrypt.Click += new System.EventHandler(this.buttonEditorEncrypt_Click);
            // 
            // buttonEditorDecrypt
            // 
            this.buttonEditorDecrypt.Location = new System.Drawing.Point(286, 25);
            this.buttonEditorDecrypt.Name = "buttonEditorDecrypt";
            this.buttonEditorDecrypt.Size = new System.Drawing.Size(85, 23);
            this.buttonEditorDecrypt.TabIndex = 12;
            this.buttonEditorDecrypt.Text = "Decrypt";
            this.buttonEditorDecrypt.UseVisualStyleBackColor = true;
            this.buttonEditorDecrypt.Click += new System.EventHandler(this.buttonEditorDecrypt_Click);
            // 
            // txtEditorAddress
            // 
            this.txtEditorAddress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorAddress.Location = new System.Drawing.Point(5, 19);
            this.txtEditorAddress.MaxLength = 8;
            this.txtEditorAddress.Name = "txtEditorAddress";
            this.txtEditorAddress.Size = new System.Drawing.Size(62, 23);
            this.txtEditorAddress.TabIndex = 7;
            this.txtEditorAddress.Text = "00000000";
            this.txtEditorAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEditorAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateHex32);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.729F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.271F));
            this.tableLayoutPanel2.Controls.Add(this.txtEditorBase, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtEditorByte, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(738, 110);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtEditorBase
            // 
            this.txtEditorBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditorBase.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorBase.Location = new System.Drawing.Point(370, 3);
            this.txtEditorBase.Multiline = true;
            this.txtEditorBase.Name = "txtEditorBase";
            this.txtEditorBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditorBase.Size = new System.Drawing.Size(365, 104);
            this.txtEditorBase.TabIndex = 16;
            this.txtEditorBase.Text = "BASE64 CODE";
            // 
            // txtEditorByte
            // 
            this.txtEditorByte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEditorByte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditorByte.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorByte.Location = new System.Drawing.Point(3, 3);
            this.txtEditorByte.Multiline = true;
            this.txtEditorByte.Name = "txtEditorByte";
            this.txtEditorByte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditorByte.Size = new System.Drawing.Size(361, 104);
            this.txtEditorByte.TabIndex = 15;
            this.txtEditorByte.Text = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 \r\n";
            this.txtEditorByte.TextChanged += new System.EventHandler(this.txtEditorByte_TextChanged);
            this.txtEditorByte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditorByte_KeyPress);
            this.txtEditorByte.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditorByte_Validating);
            // 
            // cmbMemlayout
            // 
            this.cmbMemlayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemlayout.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMemlayout.FormattingEnabled = true;
            this.cmbMemlayout.Items.AddRange(new object[] {
            "Memory Layout",
            "00000000 | 00000000 | 00000000"});
            this.cmbMemlayout.Location = new System.Drawing.Point(514, 9);
            this.cmbMemlayout.Name = "cmbMemlayout";
            this.cmbMemlayout.Size = new System.Drawing.Size(234, 23);
            this.cmbMemlayout.TabIndex = 6;
            // 
            // cmbProcesses
            // 
            this.cmbProcesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcesses.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcesses.FormattingEnabled = true;
            this.cmbProcesses.Items.AddRange(new object[] {
            "Processes"});
            this.cmbProcesses.Location = new System.Drawing.Point(263, 9);
            this.cmbProcesses.Name = "cmbProcesses";
            this.cmbProcesses.Size = new System.Drawing.Size(198, 23);
            this.cmbProcesses.TabIndex = 4;
            this.cmbProcesses.SelectedIndexChanged += new System.EventHandler(this.cmbProcesses_SelectedIndexChanged);
            // 
            // buttonProcesses
            // 
            this.buttonProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProcesses.Font = new System.Drawing.Font("Webdings", 9.75F);
            this.buttonProcesses.ForeColor = System.Drawing.Color.Teal;
            this.buttonProcesses.Location = new System.Drawing.Point(464, 9);
            this.buttonProcesses.Name = "buttonProcesses";
            this.buttonProcesses.Size = new System.Drawing.Size(25, 23);
            this.buttonProcesses.TabIndex = 3;
            this.buttonProcesses.Text = "q";
            this.buttonProcesses.UseVisualStyleBackColor = true;
            this.buttonProcesses.Click += new System.EventHandler(this.buttonProcesses_Click);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIpAddress.Location = new System.Drawing.Point(3, 8);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(113, 23);
            this.txtIpAddress.TabIndex = 1;
            this.txtIpAddress.Text = "192.168.1.45";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.Control;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnect.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Bold);
            this.buttonConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConnect.Location = new System.Drawing.Point(158, 8);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(31, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "~";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // pgbProgress
            // 
            this.pgbProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbProgress.Location = new System.Drawing.Point(3, 560);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(752, 15);
            this.pgbProgress.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.configToolStripMenuItem,
            this.openWorkDirToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.testToolStripMenuItem.Text = "File";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnecttrueToolStripMenuItem,
            this.disconnectfalseToolStripMenuItem});
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.test1ToolStripMenuItem.Text = "Disconnect";
            // 
            // disconnecttrueToolStripMenuItem
            // 
            this.disconnecttrueToolStripMenuItem.Name = "disconnecttrueToolStripMenuItem";
            this.disconnecttrueToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.disconnecttrueToolStripMenuItem.Text = "Safe Disconnect";
            this.disconnecttrueToolStripMenuItem.Click += new System.EventHandler(this.disconnecttrueToolStripMenuItem_Click);
            // 
            // disconnectfalseToolStripMenuItem
            // 
            this.disconnectfalseToolStripMenuItem.Name = "disconnectfalseToolStripMenuItem";
            this.disconnectfalseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.disconnectfalseToolStripMenuItem.Text = "Hard Disconnect";
            this.disconnectfalseToolStripMenuItem.Click += new System.EventHandler(this.disconnectfalseToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadConfigToolStripMenuItem,
            this.saveConfigToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.configToolStripMenuItem.Text = "Settings";
            // 
            // reloadConfigToolStripMenuItem
            // 
            this.reloadConfigToolStripMenuItem.Name = "reloadConfigToolStripMenuItem";
            this.reloadConfigToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.reloadConfigToolStripMenuItem.Text = "Reload Settings";
            this.reloadConfigToolStripMenuItem.Click += new System.EventHandler(this.reloadConfigToolStripMenuItem_Click);
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveConfigToolStripMenuItem.Text = "Save Settings";
            this.saveConfigToolStripMenuItem.Click += new System.EventHandler(this.saveConfigToolStripMenuItem_Click);
            // 
            // openWorkDirToolStripMenuItem
            // 
            this.openWorkDirToolStripMenuItem.Name = "openWorkDirToolStripMenuItem";
            this.openWorkDirToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openWorkDirToolStripMenuItem.Text = "Open Directory";
            this.openWorkDirToolStripMenuItem.Click += new System.EventHandler(this.openWorkDirToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 602);
            this.Controls.Add(this.ContentTable);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "NTRClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.ContentTable.ResumeLayout(false);
            this.ContentTable.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel ContentTable;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
		private System.Windows.Forms.Panel ContentPanel;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.ProgressBar pgbProgress;
		private System.Windows.Forms.TextBox txtIpAddress;
		private System.Windows.Forms.Button buttonProcesses;
		private System.Windows.Forms.ComboBox cmbProcesses;
		private System.Windows.Forms.ComboBox cmbMemlayout;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtDumpMemAddrStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDumpMemAddrLength;
		private System.Windows.Forms.Button buttonDumpMemoryConsole;
		private System.Windows.Forms.Button buttonDumpMemoryFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCreateBaseCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBaseLength;
		private System.Windows.Forms.TextBox txtBaseAddress;
		private System.Windows.Forms.TextBox txtBaseCode;
		private System.Windows.Forms.Button buttonUseBaseCode;
		private System.Windows.Forms.Button buttonBaseClipboardPaste;
		private System.Windows.Forms.Button buttonBaseClipboardCopy;
		private System.Windows.Forms.ComboBox cmbEditModeType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEditModeAddress;
		private System.Windows.Forms.Button buttonEditModeWriteHex;
		private System.Windows.Forms.TextBox txtEditModeDecimal;
		private System.Windows.Forms.TextBox txtEditModeHex;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonEditModeWriteDecimal;
		private System.Windows.Forms.Button buttonEditModeRead;
		private System.Windows.Forms.CheckBox cbEditModeLittleEndian;
		private System.Windows.Forms.ToolStripMenuItem disconnectfalseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnecttrueToolStripMenuItem;
		private System.Windows.Forms.Button buttonBaseHelp;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonEditorEncrypt;
		private System.Windows.Forms.Button buttonEditorDecrypt;
		private System.Windows.Forms.TextBox txtEditorAddress;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TextBox txtEditorBase;
		private System.Windows.Forms.TextBox txtEditorByte;
		private System.Windows.Forms.Button buttonEditorHelp;
		private System.Windows.Forms.Button buttonEditorUse;
		private System.Windows.Forms.Button buttonEditorCreate;
		private System.Windows.Forms.Button buttonDumpAll;
		private System.Windows.Forms.ToolStripMenuItem openWorkDirToolStripMenuItem;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtEditorLength;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtEditorOffset;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox cbPointer;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reloadConfigToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveConfigToolStripMenuItem;
		private System.Windows.Forms.Button buttonMemregions;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.CheckBox autoProcs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

