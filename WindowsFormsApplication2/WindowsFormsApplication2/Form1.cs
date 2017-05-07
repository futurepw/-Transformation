using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //中文转16进制编码
            string Msg = textBox1.Text;
            byte[] bytes = System.Text.Encoding.Default.GetBytes(Msg);
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str += string.Format("{0:X}", bytes[i]);
            }
            label1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //16进制编码转中文
            string Msg = textBox1.Text;
            byte[] buff = new byte[Msg.Length / 2];
            string Message = "";
            for (int i = 0; i < buff.Length; i++)
            {
                buff[i] = byte.Parse(Msg.Substring(i * 2, 2),
                   System.Globalization.NumberStyles.HexNumber);
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");
            Message = chs.GetString(buff);
            label1.Text = Message;

        }
    }
}
