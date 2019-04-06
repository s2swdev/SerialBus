namespace SerialBus
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.port_config_group = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowControlConfig = new System.Windows.Forms.ComboBox();
            this.stopBitsConfig = new System.Windows.Forms.ComboBox();
            this.parityConfig = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBitsConfig = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portNumberConfig = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baudRateConfig = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tx_repeater_delay = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tx_textarea = new System.Windows.Forms.TextBox();
            this.write_options_group = new System.Windows.Forms.GroupBox();
            this.tx_num_panel = new System.Windows.Forms.Panel();
            this.send_delay = new System.Windows.Forms.NumericUpDown();
            this.send_repeat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_radiobuttons_panel = new System.Windows.Forms.Panel();
            this.write_form_file_radiobutton = new System.Windows.Forms.RadioButton();
            this.key_capture_radiobutton = new System.Windows.Forms.RadioButton();
            this.send_word_radiobutton = new System.Windows.Forms.RadioButton();
            this.send_status = new System.Windows.Forms.Label();
            this.sendData = new System.Windows.Forms.Button();
            this.main_textBox_hex = new System.Windows.Forms.RichTextBox();
            this.display_as_group = new System.Windows.Forms.GroupBox();
            this.DisplayAsciiRadiobutton = new System.Windows.Forms.RadioButton();
            this.DisplayHexRadiobutton = new System.Windows.Forms.RadioButton();
            this.DisplayDecimalRadiobutton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.DisplayBinaryRadiobutton = new System.Windows.Forms.RadioButton();
            this.main_textBox_binary = new System.Windows.Forms.RichTextBox();
            this.main_textBox_decimal = new System.Windows.Forms.RichTextBox();
            this.main_textBox_ascii = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.port_config_group.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.write_options_group.SuspendLayout();
            this.tx_num_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_repeat)).BeginInit();
            this.tx_radiobuttons_panel.SuspendLayout();
            this.display_as_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // port_config_group
            // 
            this.port_config_group.Controls.Add(this.ClearBtn);
            this.port_config_group.Controls.Add(this.connect);
            this.port_config_group.Controls.Add(this.label7);
            this.port_config_group.Controls.Add(this.label6);
            this.port_config_group.Controls.Add(this.flowControlConfig);
            this.port_config_group.Controls.Add(this.stopBitsConfig);
            this.port_config_group.Controls.Add(this.parityConfig);
            this.port_config_group.Controls.Add(this.label5);
            this.port_config_group.Controls.Add(this.dataBitsConfig);
            this.port_config_group.Controls.Add(this.label4);
            this.port_config_group.Controls.Add(this.label1);
            this.port_config_group.Controls.Add(this.portNumberConfig);
            this.port_config_group.Controls.Add(this.label2);
            this.port_config_group.Controls.Add(this.baudRateConfig);
            this.port_config_group.Location = new System.Drawing.Point(12, 27);
            this.port_config_group.Name = "port_config_group";
            this.port_config_group.Size = new System.Drawing.Size(335, 133);
            this.port_config_group.TabIndex = 22;
            this.port_config_group.TabStop = false;
            this.port_config_group.Text = "Port Configuration";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(182, 104);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(83, 23);
            this.ClearBtn.TabIndex = 33;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(64, 104);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(89, 23);
            this.connect.TabIndex = 22;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Flow Control";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Parity";
            // 
            // flowControlConfig
            // 
            this.flowControlConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowControlConfig.FormattingEnabled = true;
            this.flowControlConfig.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.flowControlConfig.Location = new System.Drawing.Point(244, 72);
            this.flowControlConfig.Name = "flowControlConfig";
            this.flowControlConfig.Size = new System.Drawing.Size(81, 21);
            this.flowControlConfig.TabIndex = 24;
            // 
            // stopBitsConfig
            // 
            this.stopBitsConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsConfig.FormattingEnabled = true;
            this.stopBitsConfig.Location = new System.Drawing.Point(244, 18);
            this.stopBitsConfig.Name = "stopBitsConfig";
            this.stopBitsConfig.Size = new System.Drawing.Size(81, 21);
            this.stopBitsConfig.TabIndex = 22;
            // 
            // parityConfig
            // 
            this.parityConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityConfig.FormattingEnabled = true;
            this.parityConfig.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.parityConfig.Location = new System.Drawing.Point(244, 45);
            this.parityConfig.Name = "parityConfig";
            this.parityConfig.Size = new System.Drawing.Size(81, 21);
            this.parityConfig.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stop Bit(s)";
            // 
            // dataBitsConfig
            // 
            this.dataBitsConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitsConfig.FormattingEnabled = true;
            this.dataBitsConfig.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.dataBitsConfig.Location = new System.Drawing.Point(64, 73);
            this.dataBitsConfig.Name = "dataBitsConfig";
            this.dataBitsConfig.Size = new System.Drawing.Size(81, 21);
            this.dataBitsConfig.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data Bits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Port(s)";
            // 
            // portNumberConfig
            // 
            this.portNumberConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portNumberConfig.FormattingEnabled = true;
            this.portNumberConfig.Location = new System.Drawing.Point(64, 19);
            this.portNumberConfig.Name = "portNumberConfig";
            this.portNumberConfig.Size = new System.Drawing.Size(81, 21);
            this.portNumberConfig.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Baud Rate";
            // 
            // baudRateConfig
            // 
            this.baudRateConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateConfig.FormattingEnabled = true;
            this.baudRateConfig.Location = new System.Drawing.Point(64, 46);
            this.baudRateConfig.Name = "baudRateConfig";
            this.baudRateConfig.Size = new System.Drawing.Size(81, 21);
            this.baudRateConfig.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "No Connection";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(6, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(368, 3);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 26;
            this.progressBar1.Visible = false;
            // 
            // tx_textarea
            // 
            this.tx_textarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tx_textarea.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_textarea.Location = new System.Drawing.Point(6, 42);
            this.tx_textarea.Name = "tx_textarea";
            this.tx_textarea.Size = new System.Drawing.Size(368, 24);
            this.tx_textarea.TabIndex = 14;
            this.tx_textarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_textarea_KeyPress);
            // 
            // write_options_group
            // 
            this.write_options_group.Controls.Add(this.tx_num_panel);
            this.write_options_group.Controls.Add(this.tx_radiobuttons_panel);
            this.write_options_group.Controls.Add(this.progressBar1);
            this.write_options_group.Controls.Add(this.send_status);
            this.write_options_group.Controls.Add(this.sendData);
            this.write_options_group.Controls.Add(this.tx_textarea);
            this.write_options_group.Enabled = false;
            this.write_options_group.Location = new System.Drawing.Point(353, 27);
            this.write_options_group.Name = "write_options_group";
            this.write_options_group.Size = new System.Drawing.Size(383, 133);
            this.write_options_group.TabIndex = 34;
            this.write_options_group.TabStop = false;
            this.write_options_group.Text = "Write Options";
            // 
            // tx_num_panel
            // 
            this.tx_num_panel.Controls.Add(this.send_delay);
            this.tx_num_panel.Controls.Add(this.send_repeat);
            this.tx_num_panel.Controls.Add(this.label3);
            this.tx_num_panel.Controls.Add(this.label8);
            this.tx_num_panel.Location = new System.Drawing.Point(63, 73);
            this.tx_num_panel.Name = "tx_num_panel";
            this.tx_num_panel.Size = new System.Drawing.Size(253, 27);
            this.tx_num_panel.TabIndex = 31;
            // 
            // send_delay
            // 
            this.send_delay.Location = new System.Drawing.Point(189, 4);
            this.send_delay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.send_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.send_delay.Name = "send_delay";
            this.send_delay.Size = new System.Drawing.Size(53, 20);
            this.send_delay.TabIndex = 21;
            this.send_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.send_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // send_repeat
            // 
            this.send_repeat.Location = new System.Drawing.Point(54, 4);
            this.send_repeat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.send_repeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.send_repeat.Name = "send_repeat";
            this.send_repeat.Size = new System.Drawing.Size(53, 20);
            this.send_repeat.TabIndex = 22;
            this.send_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.send_repeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Repeats:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Delay (ms):";
            // 
            // tx_radiobuttons_panel
            // 
            this.tx_radiobuttons_panel.Controls.Add(this.write_form_file_radiobutton);
            this.tx_radiobuttons_panel.Controls.Add(this.key_capture_radiobutton);
            this.tx_radiobuttons_panel.Controls.Add(this.send_word_radiobutton);
            this.tx_radiobuttons_panel.Location = new System.Drawing.Point(6, 18);
            this.tx_radiobuttons_panel.Name = "tx_radiobuttons_panel";
            this.tx_radiobuttons_panel.Size = new System.Drawing.Size(368, 23);
            this.tx_radiobuttons_panel.TabIndex = 27;
            // 
            // write_form_file_radiobutton
            // 
            this.write_form_file_radiobutton.AutoSize = true;
            this.write_form_file_radiobutton.Location = new System.Drawing.Point(298, 3);
            this.write_form_file_radiobutton.Name = "write_form_file_radiobutton";
            this.write_form_file_radiobutton.Size = new System.Drawing.Size(67, 17);
            this.write_form_file_radiobutton.TabIndex = 20;
            this.write_form_file_radiobutton.Text = "From File";
            this.write_form_file_radiobutton.UseVisualStyleBackColor = true;
            this.write_form_file_radiobutton.CheckedChanged += new System.EventHandler(this.write_form_file_radiobutton_CheckedChanged);
            // 
            // key_capture_radiobutton
            // 
            this.key_capture_radiobutton.AutoSize = true;
            this.key_capture_radiobutton.Location = new System.Drawing.Point(141, 3);
            this.key_capture_radiobutton.Name = "key_capture_radiobutton";
            this.key_capture_radiobutton.Size = new System.Drawing.Size(83, 17);
            this.key_capture_radiobutton.TabIndex = 19;
            this.key_capture_radiobutton.Text = "Key Capture";
            this.key_capture_radiobutton.UseVisualStyleBackColor = true;
            this.key_capture_radiobutton.CheckedChanged += new System.EventHandler(this.key_capture_radiobutton_CheckedChanged);
            // 
            // send_word_radiobutton
            // 
            this.send_word_radiobutton.AutoSize = true;
            this.send_word_radiobutton.Checked = true;
            this.send_word_radiobutton.Location = new System.Drawing.Point(3, 2);
            this.send_word_radiobutton.Name = "send_word_radiobutton";
            this.send_word_radiobutton.Size = new System.Drawing.Size(79, 17);
            this.send_word_radiobutton.TabIndex = 18;
            this.send_word_radiobutton.TabStop = true;
            this.send_word_radiobutton.Text = "Send Word";
            this.send_word_radiobutton.UseVisualStyleBackColor = true;
            this.send_word_radiobutton.CheckedChanged += new System.EventHandler(this.send_word_radiobutton_CheckedChanged);
            // 
            // send_status
            // 
            this.send_status.AutoSize = true;
            this.send_status.Location = new System.Drawing.Point(271, 76);
            this.send_status.Name = "send_status";
            this.send_status.Size = new System.Drawing.Size(0, 13);
            this.send_status.TabIndex = 25;
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(157, 104);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(63, 25);
            this.sendData.TabIndex = 13;
            this.sendData.Text = "Send";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // main_textBox_hex
            // 
            this.main_textBox_hex.BackColor = System.Drawing.Color.White;
            this.main_textBox_hex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_textBox_hex.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_textBox_hex.HideSelection = false;
            this.main_textBox_hex.Location = new System.Drawing.Point(15, 165);
            this.main_textBox_hex.Name = "main_textBox_hex";
            this.main_textBox_hex.ReadOnly = true;
            this.main_textBox_hex.Size = new System.Drawing.Size(799, 268);
            this.main_textBox_hex.TabIndex = 35;
            this.main_textBox_hex.Text = "";
            this.main_textBox_hex.Visible = false;
            // 
            // display_as_group
            // 
            this.display_as_group.Controls.Add(this.DisplayAsciiRadiobutton);
            this.display_as_group.Controls.Add(this.DisplayHexRadiobutton);
            this.display_as_group.Controls.Add(this.DisplayDecimalRadiobutton);
            this.display_as_group.Controls.Add(this.label11);
            this.display_as_group.Controls.Add(this.DisplayBinaryRadiobutton);
            this.display_as_group.Enabled = false;
            this.display_as_group.Location = new System.Drawing.Point(742, 27);
            this.display_as_group.Name = "display_as_group";
            this.display_as_group.Size = new System.Drawing.Size(71, 133);
            this.display_as_group.TabIndex = 35;
            this.display_as_group.TabStop = false;
            this.display_as_group.Text = "Display As";
            // 
            // DisplayAsciiRadiobutton
            // 
            this.DisplayAsciiRadiobutton.AutoSize = true;
            this.DisplayAsciiRadiobutton.Location = new System.Drawing.Point(6, 87);
            this.DisplayAsciiRadiobutton.Name = "DisplayAsciiRadiobutton";
            this.DisplayAsciiRadiobutton.Size = new System.Drawing.Size(52, 17);
            this.DisplayAsciiRadiobutton.TabIndex = 26;
            this.DisplayAsciiRadiobutton.Text = "ASCII";
            this.DisplayAsciiRadiobutton.UseVisualStyleBackColor = true;
            this.DisplayAsciiRadiobutton.CheckedChanged += new System.EventHandler(this.DisplayAsciiRadiobutton_CheckedChanged);
            // 
            // DisplayHexRadiobutton
            // 
            this.DisplayHexRadiobutton.AutoSize = true;
            this.DisplayHexRadiobutton.Location = new System.Drawing.Point(6, 64);
            this.DisplayHexRadiobutton.Name = "DisplayHexRadiobutton";
            this.DisplayHexRadiobutton.Size = new System.Drawing.Size(44, 17);
            this.DisplayHexRadiobutton.TabIndex = 20;
            this.DisplayHexRadiobutton.Text = "Hex";
            this.DisplayHexRadiobutton.UseVisualStyleBackColor = true;
            this.DisplayHexRadiobutton.CheckedChanged += new System.EventHandler(this.DisplayHexRadiobutton_CheckedChanged);
            // 
            // DisplayDecimalRadiobutton
            // 
            this.DisplayDecimalRadiobutton.AutoSize = true;
            this.DisplayDecimalRadiobutton.Location = new System.Drawing.Point(6, 41);
            this.DisplayDecimalRadiobutton.Name = "DisplayDecimalRadiobutton";
            this.DisplayDecimalRadiobutton.Size = new System.Drawing.Size(63, 17);
            this.DisplayDecimalRadiobutton.TabIndex = 19;
            this.DisplayDecimalRadiobutton.Text = "Decimal";
            this.DisplayDecimalRadiobutton.UseVisualStyleBackColor = true;
            this.DisplayDecimalRadiobutton.CheckedChanged += new System.EventHandler(this.DisplayDecimalRadiobutton_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 25;
            // 
            // DisplayBinaryRadiobutton
            // 
            this.DisplayBinaryRadiobutton.AutoSize = true;
            this.DisplayBinaryRadiobutton.Checked = true;
            this.DisplayBinaryRadiobutton.Location = new System.Drawing.Point(6, 18);
            this.DisplayBinaryRadiobutton.Name = "DisplayBinaryRadiobutton";
            this.DisplayBinaryRadiobutton.Size = new System.Drawing.Size(54, 17);
            this.DisplayBinaryRadiobutton.TabIndex = 18;
            this.DisplayBinaryRadiobutton.TabStop = true;
            this.DisplayBinaryRadiobutton.Text = "Binary";
            this.DisplayBinaryRadiobutton.UseVisualStyleBackColor = true;
            this.DisplayBinaryRadiobutton.CheckedChanged += new System.EventHandler(this.DisplayBinaryRadiobutton_CheckedChanged);
            // 
            // main_textBox_binary
            // 
            this.main_textBox_binary.BackColor = System.Drawing.Color.White;
            this.main_textBox_binary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_textBox_binary.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_textBox_binary.HideSelection = false;
            this.main_textBox_binary.Location = new System.Drawing.Point(15, 165);
            this.main_textBox_binary.Name = "main_textBox_binary";
            this.main_textBox_binary.ReadOnly = true;
            this.main_textBox_binary.Size = new System.Drawing.Size(799, 268);
            this.main_textBox_binary.TabIndex = 36;
            this.main_textBox_binary.Text = "";
            // 
            // main_textBox_decimal
            // 
            this.main_textBox_decimal.BackColor = System.Drawing.Color.White;
            this.main_textBox_decimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_textBox_decimal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_textBox_decimal.HideSelection = false;
            this.main_textBox_decimal.Location = new System.Drawing.Point(15, 165);
            this.main_textBox_decimal.Name = "main_textBox_decimal";
            this.main_textBox_decimal.ReadOnly = true;
            this.main_textBox_decimal.Size = new System.Drawing.Size(799, 268);
            this.main_textBox_decimal.TabIndex = 37;
            this.main_textBox_decimal.Text = "";
            this.main_textBox_decimal.Visible = false;
            // 
            // main_textBox_ascii
            // 
            this.main_textBox_ascii.BackColor = System.Drawing.Color.White;
            this.main_textBox_ascii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_textBox_ascii.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_textBox_ascii.HideSelection = false;
            this.main_textBox_ascii.Location = new System.Drawing.Point(15, 165);
            this.main_textBox_ascii.Name = "main_textBox_ascii";
            this.main_textBox_ascii.ReadOnly = true;
            this.main_textBox_ascii.Size = new System.Drawing.Size(799, 268);
            this.main_textBox_ascii.TabIndex = 38;
            this.main_textBox_ascii.Text = "";
            this.main_textBox_ascii.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 458);
            this.Controls.Add(this.main_textBox_ascii);
            this.Controls.Add(this.main_textBox_decimal);
            this.Controls.Add(this.main_textBox_binary);
            this.Controls.Add(this.display_as_group);
            this.Controls.Add(this.main_textBox_hex);
            this.Controls.Add(this.write_options_group);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.port_config_group);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialBus";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.port_config_group.ResumeLayout(false);
            this.port_config_group.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.write_options_group.ResumeLayout(false);
            this.write_options_group.PerformLayout();
            this.tx_num_panel.ResumeLayout(false);
            this.tx_num_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_repeat)).EndInit();
            this.tx_radiobuttons_panel.ResumeLayout(false);
            this.tx_radiobuttons_panel.PerformLayout();
            this.display_as_group.ResumeLayout(false);
            this.display_as_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox port_config_group;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox flowControlConfig;
        private System.Windows.Forms.ComboBox stopBitsConfig;
        private System.Windows.Forms.ComboBox parityConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dataBitsConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portNumberConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baudRateConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer tx_repeater_delay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tx_textarea;
        private System.Windows.Forms.GroupBox write_options_group;
        private System.Windows.Forms.Panel tx_num_panel;
        private System.Windows.Forms.NumericUpDown send_delay;
        private System.Windows.Forms.NumericUpDown send_repeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel tx_radiobuttons_panel;
        private System.Windows.Forms.RadioButton write_form_file_radiobutton;
        private System.Windows.Forms.RadioButton key_capture_radiobutton;
        private System.Windows.Forms.RadioButton send_word_radiobutton;
        private System.Windows.Forms.Label send_status;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.RichTextBox main_textBox_hex;
        private System.Windows.Forms.GroupBox display_as_group;
        private System.Windows.Forms.RadioButton DisplayAsciiRadiobutton;
        private System.Windows.Forms.RadioButton DisplayHexRadiobutton;
        private System.Windows.Forms.RadioButton DisplayDecimalRadiobutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton DisplayBinaryRadiobutton;
        private System.Windows.Forms.RichTextBox main_textBox_binary;
        private System.Windows.Forms.RichTextBox main_textBox_decimal;
        private System.Windows.Forms.RichTextBox main_textBox_ascii;
    }
}

