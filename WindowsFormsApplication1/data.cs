using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class data
    {
        public static Boolean[] bl = new Boolean[] { true, true, true, true, true, true };
        public static void getResource(Button button, Label label)
        {
            string cardName;
            Random ran = new Random();
            int rankey = ran.Next(1, 108);
            ResourceManager rm = new ResourceManager("WindowsFormsApplication1.Properties.Resources", Assembly.GetExecutingAssembly());
            cardName = "_" + rankey.ToString();
            label.Text = rankey.ToString();
            button.BackgroundImage = (Image)rm.GetObject(cardName);
        }
        public static void purchase(int golden)
        {
            string constr = "server=118.89.29.115;User Id=root;password=ccx1986719824;Database=card";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            string conUpdateGolden = "update userinfo set user_gold = @usergold, user_package = @userpackage where user_name = @username";
            MySqlCommand mycmdWYL2 = new MySqlCommand(conUpdateGolden, mycon);
            mycmdWYL2.Parameters.AddRange(
                new MySqlParameter[]
                {
                            new MySqlParameter("@usergold",MySqlDbType.Int32) {Value=golden },
                            new MySqlParameter("@userpackage",MySqlDbType.Int32) {Value=Form1.userpackage },
                            new MySqlParameter("@username",MySqlDbType.String) {Value=login.userName }
                }
                );
            mycmdWYL2.ExecuteNonQuery();
            mycon.Close();
        }

        public static void addgold(int golden)
        {
            string constr = "server=118.89.29.115;User Id=root;password=ccx1986719824;Database=card";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            string conUpdateGolden = "update userinfo set user_gold = @usergold where user_name = @username";
            MySqlCommand mycmdWYL2 = new MySqlCommand(conUpdateGolden, mycon);
            mycmdWYL2.Parameters.AddRange(
                new MySqlParameter[]
                {
                            new MySqlParameter("@usergold",MySqlDbType.Int32) {Value=golden },
                            new MySqlParameter("@username",MySqlDbType.String) {Value=login.userName }
                }
                );
            mycmdWYL2.ExecuteNonQuery();
            mycon.Close();
        }

        public static void updatepackage(int userpackage)
        {
            string constr = "server=118.89.29.115;User Id=root;password=ccx1986719824;Database=card";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            string conUpdateGolden = "update userinfo set user_package = @userpackage where user_name = @username";
            MySqlCommand mycmdWYL2 = new MySqlCommand(conUpdateGolden, mycon);
            mycmdWYL2.Parameters.AddRange(
                new MySqlParameter[]
                {
                            new MySqlParameter("@userpackage",MySqlDbType.Int32) {Value=userpackage },
                            new MySqlParameter("@username",MySqlDbType.String) {Value=login.userName }
                }
                );
            mycmdWYL2.ExecuteNonQuery();
            mycon.Close();
        }
    }
}
