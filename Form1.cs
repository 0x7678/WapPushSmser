using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDU
{
 
    public partial class Form1 : Form
    {
        string RECEIVER = "",
               HEADER = "",
               MESSAGE = "",
               START_DATE = "",
               END_DATE = "",
               MSG_LEN_HEX ="",
               OUTPUT="";

        SerialPort ComPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            lb_headercount.Text = "(18)Lenght:" + tb_header.Text.Length;
            lb_smscount.Text = "sms len:" + tb_message.Text.Length;

            var ports = SerialPort.GetPortNames();
            cb_comports.DataSource = ports;
            cb_mode.SelectedIndex = 11;
        }

        private void btngen_Click(object sender, EventArgs e)
        {
            RECEIVER = SwapNumber(tb_receiver.Text.ToString());
            HEADER = StringToHex(tb_header.Text.ToString());
            MESSAGE = StringToHex(tb_message.Text.ToString());
            START_DATE = tb_startdate.Text.ToString();
            END_DATE = tb_enddate.Text.ToString();

            int MSG_LEN = tb_message.Text.ToString().Length + 69;

            MSG_LEN_HEX = MSG_LEN.ToString("X");

            string NUM_HEX_LEN = (tb_receiver.Text.Length).ToString("X");
            if (tb_receiver.Text.Length <= 15)
            {
                NUM_HEX_LEN = "0" + NUM_HEX_LEN;
            }

            // 0B = no www or http OC = http:// 0D = http://wwww 0E https:// 0F = https://www
            OUTPUT = String.Format("004100{7}91{0}0004{1}0B05040B84C0020003F001010B060403AE81EA02056A0045C6{2}03{3}000AC306{4}10C306{5}0103{6}000101",
                RECEIVER, MSG_LEN_HEX, cb_mode.SelectedItem.ToString(), HEADER, START_DATE, END_DATE, MESSAGE, NUM_HEX_LEN);

            tb_rawpdu.Text = OUTPUT;

        }

        private string StringToHex(string hexstring)
        {
            var sb = new StringBuilder();
            foreach (char t in hexstring)
                sb.Append(Convert.ToInt32(t).ToString("x"));
            return sb.ToString();
        }
        private Boolean isNumberOdd(int numberlen)
        {
            return numberlen % 2 != 0;
        }
        private string SwapNumber(string number)
        {
            if (isNumberOdd(number.Length))
            {
                number += "F";
            }
            int loopcount = number.Length;
            //char[] charArray = receiver.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < loopcount/2; x++)
            {
                String temp = number.Substring(0, 2);
                char[] charArray = temp.ToCharArray();
                Array.Reverse(charArray);
                sb.Append(new string(charArray));
                number = number.Substring(2);
            } number = sb.ToString();
            return number;
        }

        private void OnTextChangeHeader(object sender, EventArgs e)
        {
            lb_headercount.Text = "(18)Lenght:" + tb_header.Text.Length;
        }

        private void OnMessageChange(object sender, EventArgs e)
        {
            lb_smscount.Text = "sms len:" + tb_message.Text.Length;
            if (tb_message.Text.Length > 70)
            {
                MessageBox.Show("Msg is to Long please only put in 70 chars");
            }
        }

        private void btnsendpdu_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.Write("AT+CMGS=17\r");
                Thread.Sleep(400);
                ComPort.Write(tb_rawpdu.Text.ToString());
                //ComPort.Write(sca + type + mr + da_len + inp + receiver + pid + dcs + "080074006500730074");
                Thread.Sleep(50);
                ComPort.Write(new byte[] { 0x1A }, 0, 1);
            }
            else { MessageBox.Show("Please Open Com Port"); }

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (!ComPort.IsOpen)
            {
                if (cb_comports.SelectedIndex > -1)
                {
                    //MessageBox.Show(String.Format("You selected port '{0}'", cb_comports.SelectedItem));
                    Connect(cb_comports.SelectedItem.ToString());
                    btnstart.Text = "Stop";
                }
                else
                {
                    MessageBox.Show("Please select a port first");
                }
            }
            else if (ComPort.IsOpen) 
            {
                btnstart.Text = "Start";
                CloseSerialPort();
            }
        }

        private void Connect(string portName)
        {

            if (!ComPort.IsOpen)
            {
                ComPort.BaudRate = 9600;
                ComPort.PortName = portName;
                ComPort.Open();
                //Continue here....
            }
        }

        private void CloseSerialPort()
        {
            //var ComPort = new SerialPort(portName);
            if (ComPort.IsOpen)
            {
                ComPort.Close();
                //Continue here....
            }
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void btnpdumode_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen) {
                ComPort.Write("AT+CMGF=0\r");
            }
            else
            {
                MessageBox.Show("Please Open Port");
            }

        }
    }

}
