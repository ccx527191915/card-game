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
    public partial class purchase : Form
    {
        int i = 0, golden = 0;
        public purchase()
        {
            InitializeComponent();
            textBox1.Text = Form1.usergolden.ToString();
        }

        public delegate void Mysel(int i,int gold);
        public event Mysel onSel;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            i = int.Parse(textBox2.Text.ToString());
            ++i;
            if (!button1.Enabled)
            {
                button1.Enabled = true;
            }
            if (i > 98)
            {
                button2.Enabled = false;
            }
            textBox2.Text = (i).ToString();
            label2.Text = (i * 5).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            i = int.Parse(textBox2.Text.ToString());
            --i;
            if (!button2.Enabled)
            {
                button2.Enabled = true;
            }
            if (i < 2)
            {
                button1.Enabled = false;
            }
            textBox2.Text = (i).ToString();
            label2.Text = (i * 5).ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    int i = int.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                    label2.Text = (i * 5).ToString();
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                i = int.Parse(textBox2.Text.ToString());
                golden = int.Parse(textBox1.Text);
                if (golden >= i * 5)
                {
                    golden -= i * 5;
                    Form1.usergolden = golden;
                    Form1.userpackage += i;
                    data.purchase(Form1.usergolden);
                    MessageBox.Show("购买成功！购买"+i+"包，共花费" + i * 5 + "金币。", "购买成功");
                    this.onSel(i, golden);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("金币不够！", "提示");
                }
            }
            else
            {
                MessageBox.Show("请输入正确数字！", "提示");
            }
        }
    }
}
