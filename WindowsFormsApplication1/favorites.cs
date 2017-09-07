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
    public partial class favorites : Form
    {
        int page = 1;
        public static int total = 18;
        public static int[] playercard = new int[10000];
        public static Button[] bts = new Button[6];
        public static Label[] labels = new Label[12];
        public static string playercardquantity,cardtype="暂无卡牌";
        public static string[] cardinfo = new string[108];
        public favorites()
        {
            InitializeComponent();
            bts[0] = button1;
            bts[1] = button2;
            bts[2] = button3;
            bts[3] = button4;
            bts[4] = button5;
            bts[5] = button6;
            labels[0] = card1;
            labels[1] = card2;
            labels[2] = card3;
            labels[3] = card4;
            labels[4] = card5;
            labels[5] = card6;
            labels[6] = quantity1;
            labels[7] = quantity2;
            labels[8] = quantity3;
            labels[9] = quantity4;
            labels[10] = quantity5;
            labels[11] = quantity6;
            label2.Text = favorites.cardtype;
            data.viewcard(1, favorites.bts, favorites.labels, favorites.cardinfo);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (page == total)
            {
                next.BackColor = SystemColors.ControlLight;
                next.Enabled = true;
            }
            if (--page==1)
            {
                this.focus.Focus();
                previous.BackColor = Color.Silver;
                previous.Enabled = false;
            }
            data.viewcard(page,bts,labels,cardinfo);
            label1.Text = "第 " + page + " 页";
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                previous.BackColor = SystemColors.ControlLight;
                previous.Enabled = true;
            }
            if (++page==total)
            {
                this.focus.Focus();
                next.Enabled = false;
                next.BackColor = Color.Silver;
            }
            data.viewcard(page, bts, labels, cardinfo);
            label1.Text = "第 " + page +" 页";
        }
    }
}
