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
    public partial class sign : Form
    {
        public static string userNick;
        public sign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userNick = user_nick.Text.ToString();
            if (user_nick.Text.ToString() == "")
            {
                userNick = "unnamed user";
            }
            if (user_name.Text == "")
            {
                MessageBox.Show("用户名不能为空！", "提示");
            }
            else if(user_password.Text == "")
            {
                MessageBox.Show("密码不能为空！", "提示");
            }
            else if (user_password2.Text == "")
            {
                MessageBox.Show("密码确认不能为空！", "提示");
            }
            else if (user_password.Text != user_password2.Text)
            {
                MessageBox.Show("两次输入密码不同！", "提示");
            }
            else
            {
                //string constr = "server=localhost;User Id=root;password=;Database=card";
                string constr = "server=118.89.29.115;User Id=root;password=ccx1986719824;Database=card";
                string conStringUserId = "Select * from userinfo where user_name=@userName";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                MySqlCommand mycmdWYL = new MySqlCommand(conStringUserId, mycon);
                mycmdWYL.Parameters.AddRange(
                    new MySqlParameter[] {
                    new MySqlParameter("@username", MySqlDbType.String) { Value = user_name.Text.ToString() }
                    });
                MySqlDataReader myDRWYL = mycmdWYL.ExecuteReader();
                string userPassword=user_password.Text.ToString();
                if (myDRWYL.Read())
                {
                    MessageBox.Show("用户名已存在！", "提示");
                    myDRWYL.Close();
                }
                else
                {
                    myDRWYL.Close();
                    string conAddUser = "Insert into userinfo (user_name,user_password,user_nick) values (@username,@userpassword,@usernick)";
                    MySqlCommand mycmdWYL2 = new MySqlCommand(conAddUser, mycon);
                    mycmdWYL2.Parameters.AddRange(
                        new MySqlParameter[]
                        {
                            new MySqlParameter("@username",MySqlDbType.String) {Value=user_name.Text.ToString() },
                            new MySqlParameter("@userpassword",MySqlDbType.String) {Value=user_password.Text.ToString() },
                            new MySqlParameter("@usernick",MySqlDbType.String) {Value=userNick }
                        }
                        );
                    mycmdWYL2.ExecuteNonQuery();
                    MessageBox.Show("注册成功", "注册成功");
                    this.Close();
                }
                mycon.Close();
            }
        }
    }
}
