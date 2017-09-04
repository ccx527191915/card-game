using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class addgold : Form
    {
        int i = 0, golden = 0;
        public delegate void Mysel(int gold);
        public event Mysel onSel;
        public addgold()
        {
            InitializeComponent();
            textBox1.Text = Form1.usergolden.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            i = int.Parse(textBox2.Text.ToString());
            i += 5; ;
            if (!button1.Enabled)
            {
                button1.Enabled = true;
            }
            if (i > 95)
            {
                button2.Enabled = false;
            }
            textBox2.Text = (i).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            i = int.Parse(textBox2.Text.ToString());
            i -= 5;
            if (!button2.Enabled)
            {
                button2.Enabled = true;
            }
            if (i < 10)
            {
                button1.Enabled = false;
            }
            textBox2.Text = (i).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = int.Parse(textBox2.Text);
            golden = int.Parse(textBox1.Text);
            golden += i;
            Form1.usergolden = golden;
            data.addgold(Form1.usergolden);
            MessageBox.Show("购买成功！共购买" + i + "金币", "购买成功");
            this.onSel(golden);
            this.Close();
        }
    }
}
