using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.IO;

namespace SerialBus
{
    public partial class Form1 : Form
    {
        public string data_rx { get; set; }
        bool send_data_flag = false;    /*!< Data transmitted */
        int send_repeat_counter = 0;    /*!< Tx repeatition counter */
        System.IO.StreamReader in_file;

        public Form1()
        {
            InitializeComponent();
            PortConfiguration();
        }

        /**
         * @param 
         *  empty
         * @brief 
         *  This function initializes...
         * @author  
         *  S.Aman
         */
        public void PortConfiguration()
        {
            //String[] ports = SerialPort.GetPortNames();
            //portNumber.Items.AddRange(ports);

            portNumberConfig.Items.AddRange(SerialPort.GetPortNames());   /*!< Baud rate configuration */
            baudRateConfig.DataSource = new[] { "115200", "57600", "19200", "38400", "9600", "4800" };  /*!< Baud rate configuration */
            parityConfig.DataSource = new[] { "None", "Odd", "Even", "Mark", "Space" };
            dataBitsConfig.DataSource = new[] { "5", "6", "7", "8" };
            stopBitsConfig.DataSource = new[] { "1", "2", "1.5" };
            flowControlConfig.DataSource = new[] { "None", "RTS", "RTS/X", "Xon/Xoff" };

            baudRateConfig.SelectedIndex = 5;
            parityConfig.SelectedIndex = 0;
            dataBitsConfig.SelectedIndex = 3;
            stopBitsConfig.SelectedIndex = 0;
            flowControlConfig.SelectedIndex = 0;

            tx_repeater_delay.Tick += new EventHandler(send_data);

            //Port configuration from Bus_Monitor with refrence to the function rx_data_event

            serialPort1.DataReceived += rx_data_event;
            backgroundWorker1.DoWork += new DoWorkEventHandler(update_rxtextarea_event);
        }

        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function is exectued when connect button is clicked.
         * @author  
         *  S.Aman
         */
        private void connect_Click(object sender, EventArgs e)
        {
            /*Connect*/
            if (!serialPort1.IsOpen)
            {
                if (Serial_port_config())
                {
                    //try
                    //{
                    serialPort1.Open();
                    //}
                    /*catch
                    {
                        alert("Can't open " + serialPort1.PortName + " port, it might be used in another program");
                        return;
                    }*/

                    /*if (datalogger_checkbox.Checked)
                    {
                        try
                        {
                            out_file = new System.IO.StreamWriter(datalogger_checkbox.Text, datalogger_append_radiobutton.Checked);
                        }
                        catch
                        {
                            alert("Can't open " + datalogger_checkbox.Text + " file, it might be used in another program");
                            return;
                        }
                    }*/

                    UserControl_state(true);
                }
            }

            /*Disconnect*/
            else if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                }
                catch {/*ignore*/}

                //if (datalogger_checkbox.Checked)
                //    try { out_file.Dispose(); }
                //    catch {/*ignore*/ }

                //try { in_file.Dispose(); }
                //catch {/*ignore*/ }

                UserControl_state(false);
            }
        }

        /**
         * 
         * @param
         *  None
         * @brief 
         *  This function cofigures the serial port.
         * @author  
         *  S.Aman
         */
        private bool Serial_port_config()
        {
            //try
            //{
            serialPort1.PortName = portNumberConfig.Text;
            //}
            /*catch
            {
                alert("There are no available ports");
                return false;
            }*/
            serialPort1.BaudRate = (Int32.Parse(baudRateConfig.Text));
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (stopBitsConfig.SelectedIndex + 1).ToString(), true);
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), parityConfig.SelectedIndex.ToString(), true);
            serialPort1.DataBits = (Int32.Parse(dataBitsConfig.Text));
            serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowControlConfig.SelectedIndex.ToString(), true);

            return true;
        }

        /**
         * 
         * @param
         *  value
         * @brief 
         *  This function displays connection status at the bottom of the software.
         * @author  
         *  S.Aman
         */
        private void UserControl_state(bool value)
        {
            //port_config_group.Enabled = !value;
            //datalogger_options_panel.Enabled = !value;
            write_options_group.Enabled = value;
            display_as_group.Enabled = value;

            if (value)
            {
                connect.Text = "Disconnect";
                toolStripStatusLabel1.Text = "Connected port: " + serialPort1.PortName + " @ " + serialPort1.BaudRate + " bps";
                connect.Enabled = true;
            }
            else
            {
                connect.Text = "Disconnected";
                toolStripStatusLabel1.Text = "No Connection";
            }
        }

        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function...
         * @author  
         *  S.Aman
         */
        private void sendData_Click(object sender, EventArgs e)
        {
            if (!send_data_flag)
            {
                tx_repeater_delay.Interval = (int)send_delay.Value;
                tx_repeater_delay.Start();

                if (send_word_radiobutton.Checked)
                {
                    progressBar1.Maximum = (int)send_repeat.Value;
                    progressBar1.Visible = true;
                }
                else if (write_form_file_radiobutton.Checked)
                {
                    //try
                    //{
                    in_file = new System.IO.StreamReader(tx_textarea.Text, true);
                    //}
                    //catch
                    //{
                    //    alert("Can't open " + tx_textarea.Text + " file, it might be not exist or it is used in another program");
                    //    return;
                    //}

                    progressBar1.Maximum = file_size(tx_textarea.Text);
                    progressBar1.Visible = true;
                }

                send_data_flag = true;
                tx_num_panel.Enabled = false;
                tx_textarea.Enabled = false;
                tx_radiobuttons_panel.Enabled = false;
                sendData.Text = "Stop";
            }
            else
            {
                tx_repeater_delay.Stop();
                progressBar1.Value = 0;
                send_repeat_counter = 0;
                send_data_flag = false;
                progressBar1.Visible = false;
                tx_num_panel.Enabled = true;
                tx_textarea.Enabled = true;
                tx_radiobuttons_panel.Enabled = true;
                sendData.Text = "Send";
                /* if (write_form_file_radiobutton.Checked)
                     try { in_file.Dispose(); }
                     catch { }*/
            }
        }

        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function...
         * @author  
         *  S.Aman
         */
        private void send_data(object sender, EventArgs e)
        {

            string tx_data = "";
            if (send_word_radiobutton.Checked)
            {
                tx_data = tx_textarea.Text.Replace("\n", Environment.NewLine);
                if (send_repeat_counter < (int)send_repeat.Value)
                {
                    send_repeat_counter++;
                    progressBar1.Value = send_repeat_counter;
                    progressBar1.Update();
                }
                else
                    send_data_flag = false;
            }

            else if (write_form_file_radiobutton.Checked)
            {
                try { tx_data = in_file.ReadLine(); }
                catch { }

                if (tx_data == null)
                    send_data_flag = false;
                else
                {
                    progressBar1.Value = send_repeat_counter;
                    send_repeat_counter++;
                }
                tx_data += "\\n";
            }

            if (send_data_flag)
            {
                if (serialPort1.IsOpen)
                {
                    //try
                    //{

                    serialPort1.Write(tx_data.Replace("\\n", Environment.NewLine));

                    // Changing outgoing data color to blue
                    main_textBox_binary.SelectionColor = Color.Blue;
                    main_textBox_decimal.SelectionColor = Color.Blue;
                    main_textBox_hex.SelectionColor = Color.Blue;
                    main_textBox_ascii.SelectionColor = Color.Blue;

                    main_textBox_binary.AppendText("" + DateTime.Now + " [TX]> ");
                    main_textBox_hex.AppendText("" + DateTime.Now + " [TX]> ");
                    main_textBox_decimal.AppendText("" + DateTime.Now + " [TX]> ");
                    main_textBox_ascii.AppendText("" + DateTime.Now + " [TX]> ");

                    byte[] bytes = Encoding.ASCII.GetBytes(tx_data);
                    foreach (byte b in bytes)
                    {
                        main_textBox_decimal.AppendText(Convert.ToInt32(Convert.ToString(b, 2), 2).ToString() + " ");
                    }
                    main_textBox_decimal.AppendText("\n");

                    foreach (byte b in bytes)
                    {
                        main_textBox_binary.AppendText(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
                    }
                    main_textBox_binary.AppendText("\n");

                    char[] array = tx_data.ToCharArray();
                    string final = "";
                    foreach (var i in array)
                    {
                        string hex = String.Format("{0:x}", Convert.ToInt32(i));  // If inserting 0x is needed for hex data
                        final += hex + " "; //.Insert(0, "0x") + " ";
                    }
                    final = final.TrimEnd();
                    main_textBox_hex.AppendText(final + "\n");

                    main_textBox_ascii.AppendText(tx_data + "\n");

                    //}
                    //catch
                    //{
                    //alert("Can't write to " + serialPort1.PortName + " port it might be opened in another program");
                    //}
                }
            }
            else
            {
                tx_repeater_delay.Stop();
                sendData.Text = "Send";
                send_repeat_counter = 0;
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                tx_radiobuttons_panel.Enabled = true;
                tx_num_panel.Enabled = true;
                tx_textarea.Enabled = true;

                if (write_form_file_radiobutton.Checked)
                    try { in_file.Dispose(); }
                    catch { }
            }
        }

        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function...
         * @author  
         *  S.Aman
         */
        private void key_capture_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            tx_textarea.Clear();
            send_repeat.Enabled = !key_capture_radiobutton.Checked;
            send_delay.Enabled = !key_capture_radiobutton.Checked;
            sendData.Enabled = !key_capture_radiobutton.Checked;
            this.ActiveControl = tx_textarea;
        }

        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function...
         * @author  
         *  S.Aman
         */
        private void send_word_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            tx_textarea.Clear();
            send_repeat.Enabled = send_word_radiobutton.Checked;
            send_delay.Enabled = send_word_radiobutton.Checked;
            this.ActiveControl = tx_textarea;
        }

        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function...
         * @author  
         *  S.Aman
         */
        private void write_form_file_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            tx_textarea.Clear();
            send_repeat.Enabled = !write_form_file_radiobutton.Checked;
            send_delay.Enabled = write_form_file_radiobutton.Checked;

            if (write_form_file_radiobutton.Checked)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tx_textarea.Text = openFileDialog1.FileName;
                    tx_textarea.Cursor = Cursors.Hand;
                    tx_textarea.ReadOnly = true;
                }
                else
                {
                    send_word_radiobutton.Checked = true;
                }
            else
            {
                tx_textarea.Cursor = Cursors.IBeam;
                tx_textarea.ReadOnly = false;
            }
        }


        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function...
         * @author  
         *  S.Aman
         */
        private void tx_textarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (key_capture_radiobutton.Checked && serialPort1.IsOpen)
            {
                //try
                //{
                serialPort1.Write(e.KeyChar.ToString());


                main_textBox_hex.AppendText("[TX]> " + e.KeyChar.ToString() + "\n");
                tx_textarea.Clear();

                //}
                //catch { alert("Can't write to " + serialPort1.PortName + " port it might be opened in another program"); }
            }
        }

        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function...
         * @author  
         *  S.Aman
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
        }

        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function get number of lines.
         * @author  
         *  S.Aman
         */
        private int file_size(string path)
        {
            var file = new StreamReader(path).ReadToEnd();
            string[] lines = file.Split(new char[] { '\n' });
            int count = lines.Count();
            return count;
        }

        /**
         * 
         * @param
         *  sender, e
         * @brief 
         *  This function will be run when Exit is clicked from the menuStrip1 > File
         * @author  
         *  S.Aman
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
            catch {/*ignore*/}

            //if (datalogger_checkbox.Checked)
            //    try { out_file.Dispose(); }
            //    catch {/*ignore*/ }

            //try { in_file.Dispose(); }
            //catch {/*ignore*/ }

            UserControl_state(false);
            this.Close();
        }

        /*Clear funtion*/
        //Implementing CLEAR function which clears corresponding console window of display

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            main_textBox_hex.Clear();
            main_textBox_decimal.Clear();
            main_textBox_binary.Clear();
            main_textBox_ascii.Clear();
        }


        /* read data from serial */
        private void rx_data_event(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //try
                //{
                int dataLength = serialPort1.BytesToRead;
                byte[] dataRecevied = new byte[dataLength];
                int nbytes = serialPort1.Read(dataRecevied, 0, dataLength);
                if (nbytes == 0) return;

                /*if (datalogger_checkbox.Checked)
                {
                    try
                    { out_file.Write(data.Replace("\\n", Environment.NewLine)); }
                    catch { alert("Can't write to " + datalogger_checkbox.Text + " file it might be not exist or it is opened in another program"); 
                    return; }
                }*/


                this.BeginInvoke((Action)(() =>
                {
                    data_rx = System.Text.Encoding.Default.GetString(dataRecevied);

                    //if (!plotter_flag && !backgroundWorker1.IsBusy)
                    //{
                    //if (display_hex_radiobutton.Checked)
                    data_rx = BitConverter.ToString(dataRecevied);

                    backgroundWorker1.RunWorkerAsync();
                    //}

                    /*else if (plotter_flag)
                    {
                        double number;
                        string[] variables = data.Split('\n')[0].Split(',');
                        for (int i = 0; i < variables.Length && i < 5; i++)
                        {
                            if (double.TryParse(variables[i], out number))
                            {
                                if (graph.Series[i].Points.Count > graph_scaler)
                                    graph.Series[i].Points.RemoveAt(0);
                                graph.Series[i].Points.Add(number);
                            }
                        }
                        graph.ResetAutoValues();
                    }*/
                }));
                //}
                //catch { alert("Can't read form  " + serialPort1.PortName + " port it might be opened in another program"); }
            }
        }

        //Function to show the Monitor Data in text area
        /* Append text to rx_textarea*/
        private void update_rxtextarea_event(object sender, DoWorkEventArgs e)
        {
            string[] groups = data_rx.Split('-');
            int decValue;// = Convert.ToInt32("data_rx", 16);
            this.BeginInvoke((Action)(() =>
            {
                if (main_textBox_hex.Lines.Count() > 5000)
                    main_textBox_hex.ResetText();

                // Changing incoming data color to green
                main_textBox_binary.SelectionColor = Color.Green;
                main_textBox_decimal.SelectionColor = Color.Green;
                main_textBox_hex.SelectionColor = Color.Green;
                main_textBox_ascii.SelectionColor = Color.Green;

                //showing current Date and Time 
                main_textBox_binary.AppendText("" + DateTime.Now + " [RX]> ");
                main_textBox_hex.AppendText("" + DateTime.Now + " [RX]> ");
                main_textBox_decimal.AppendText("" + DateTime.Now + " [RX]> ");
                main_textBox_ascii.AppendText("" + DateTime.Now + " [RX]> ");
                for (int x = 0; x < groups.Length; x++)
                {
                    decValue = Convert.ToInt32(groups[x], 16);
                    byte[] bytes = Encoding.ASCII.GetBytes(ConvertHex(groups[x]));
                    foreach (byte b in bytes)
                    {
                        main_textBox_binary.AppendText(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
                    }
                    

                    main_textBox_decimal.AppendText(decValue + "");
                    

                    char[] array = groups[x].ToCharArray();
                    string final = "";
                    foreach (var i in array)
                    //for (int i = 0; i < data_rx.Length; i += 2)
                    {
                        string hex = String.Format("{0:X}", Convert.ToInt32(i));  // If inserting 0x is needed for hex data
                        final += hex.Insert(0, "0x") + " ";
                    }
                    final = final.TrimEnd();
                    main_textBox_hex.AppendText(groups[x]);
                    

                    main_textBox_ascii.AppendText(ConvertHex(groups[x]));
                    
                }
                main_textBox_binary.AppendText("\n");
                main_textBox_decimal.AppendText("\n");
                main_textBox_hex.AppendText("\n");
                main_textBox_ascii.AppendText("\n");
            }));
        }

        public static string ConvertHex(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }
        
        private void DisplayBinaryRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            main_textBox_hex.Visible = false;
            main_textBox_binary.Visible = true;
            main_textBox_decimal.Visible = false;
            main_textBox_ascii.Visible = false;
        }

        private void DisplayDecimalRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            main_textBox_hex.Visible = false;
            main_textBox_binary.Visible = false;
            main_textBox_decimal.Visible = true;
            main_textBox_ascii.Visible = false;
        }

        private void DisplayHexRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            main_textBox_hex.Visible = true;
            main_textBox_binary.Visible = false;
            main_textBox_decimal.Visible = false;
            main_textBox_ascii.Visible = false;
        }

        private void DisplayAsciiRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            main_textBox_hex.Visible = false;
            main_textBox_binary.Visible = false;
            main_textBox_decimal.Visible = false;
            main_textBox_ascii.Visible = true;
        }
    }
}
