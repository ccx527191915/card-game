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
    public partial class Form1 : Form
    {
        public static int usergolden,userpackage;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = usergolden.ToString();
            label8.Text = userpackage.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void image1_Click(object sender, EventArgs e)
        {
            if (!data.bl[0])
            {
                data.getResource(image1, label1);
                data.bl[0] = true;
            }
        }

        private void image2_Click(object sender, EventArgs e)
        {
            if (!data.bl[1])
            {
                data.getResource(image2, label2);
                data.bl[1] = true;
            }
        }

        private void image3_Click(object sender, EventArgs e)
        {
            if (!data.bl[2])
            {
                data.getResource(image3, label3);
                data.bl[2] = true;
            }
        }

        private void image4_Click(object sender, EventArgs e)
        {
            if (!data.bl[3])
            {
                data.getResource(image4, label4);
                data.bl[3] = true;
            }
        }

        private void image5_Click(object sender, EventArgs e)
        {
            if (!data.bl[4])
            {
                data.getResource(image5, label5);
                data.bl[4] = true;
            }
        }

        private void image6_Click(object sender, EventArgs e)
        {
            if (!data.bl[5])
            {
                data.getResource(image6, label6);
                data.bl[5] = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userpackage>0)
            {
                image1.BackgroundImage = null;
                image2.BackgroundImage = null;
                image3.BackgroundImage = null;
                image4.BackgroundImage = null;
                image5.BackgroundImage = null;
                image6.BackgroundImage = null;
                label1.Text = null;
                label2.Text = null;
                label3.Text = null;
                label4.Text = null;
                label5.Text = null;
                label6.Text = null;
                for (int i = 0; i < 6; i++)
                {
                    data.bl[i] = false;
                }
                userpackage--;
                data.updatepackage(userpackage);
                label8.Text = userpackage.ToString();
            }
            else
            {
                MessageBox.Show("卡包不足，请购买！", "提示");
            }
            
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            purchase pur = new purchase();
            pur.onSel += new WindowsFormsApplication1.purchase.Mysel(purchase_onSel);
            pur.Show();
        }

        private void purchase_onSel(int i, int gold)
        {
            textBox1.Text = gold.ToString();
            label8.Text = userpackage.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            addgold ag = new addgold();
            ag.onSel += new WindowsFormsApplication1.addgold.Mysel(addgold_onSel);
            ag.Show();
        }
        private void addgold_onSel(int gold)
        {
            textBox1.Text = gold.ToString();
        }
    }
}
