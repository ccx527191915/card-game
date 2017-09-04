using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public static string userName;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name.Text == "")
            {
                MessageBox.Show("用户名为空！", "提示");
            }
            else if (user_password.Text == "")
            {
                MessageBox.Show("密码为空！", "提示");
            }
            else
            {
                //string constr = "server=localhost;User Id=root;password=;Database=card";
                string constr = "server=118.89.29.115;User Id=root;password=ccx1986719824;Database=card";
                userName = user_name.Text.ToString();
                string conStringUserId = "Select * from userinfo where user_name=@userName";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                MySqlCommand mycmdWYL = new MySqlCommand(conStringUserId, mycon);
                mycmdWYL.Parameters.AddRange(
                    new MySqlParameter[] {
                    new MySqlParameter("@username", MySqlDbType.String) { Value = user_name.Text.ToString() }
                    });
                MySqlDataReader myDRWYL = mycmdWYL.ExecuteReader();
                string userPassword;
                if (myDRWYL.Read())
                {
                    userPassword = myDRWYL["user_password"].ToString();
                    Form1.usergolden= int.Parse(myDRWYL["user_gold"].ToString());
                    Form1.userpackage = int.Parse(myDRWYL["user_package"].ToString());
                    if (user_password.Text == userPassword)
                    {
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！", "提示");
                    }
                    myDRWYL.Close();
                }
                else
                {
                    MessageBox.Show("用户名不存在！", "提示");
                    myDRWYL.Close();
                }
                mycon.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sign sign1 = new sign();
            sign1.Show();
        }
    }
}
