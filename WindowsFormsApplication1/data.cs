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
        public static string[] cardquantity = new string[6];
        public static string cardini = "0_0_0_0_0_0_0_0_0_0_0_0";
        public static string shuihuini = "0_0_0_0_0_0_0_0_0_0_0_0_" + "0_0_0_0_0_0_0_0_0_0_0_0_" + "0_0_0_0_0_0_0_0_0_0_0_0_" +
            "0_0_0_0_0_0_0_0_0_0_0_0_" + "0_0_0_0_0_0_0_0_0_0_0_0_" + "0_0_0_0_0_0_0_0_0_0_0_0_" + "0_0_0_0_0_0_0_0_0_0_0_0_" +
            "0_0_0_0_0_0_0_0_0_0_0_0_" + "0_0_0_0_0_0_0_0_0_0_0_0";
        public static Boolean[] bl = new Boolean[] { true, true, true, true, true, true };

        public static void cardinit(string userName,string cardtype)
        {
            string constr = "server=118.89.29.115;User Id=root;password=ccx1986719824;Database=card";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            string conUpdateGolden = "insert into playercard (user_name,card_type,player_card_quantity) values (@username,@cardtype,@playercardquantity)";
            MySqlCommand mycmdWYL2 = new MySqlCommand(conUpdateGolden, mycon);
            mycmdWYL2.Parameters.AddRange(
                new MySqlParameter[]
                {
                            new MySqlParameter("@username",MySqlDbType.String) {Value=userName },
                            new MySqlParameter("@cardtype",MySqlDbType.String) {Value="水浒" },
                            new MySqlParameter("@playercardquantity",MySqlDbType.String) {Value=shuihuini }
                }
                );
            mycmdWYL2.ExecuteNonQuery();
            mycon.Close();
        }
        public static int getResource(Button button, Label label)
        {
            string cardName;
            Random ran = new Random();
            int rankey = ran.Next(1, 108);
            ResourceManager rm = new ResourceManager("WindowsFormsApplication1.Properties.Resources", Assembly.GetExecutingAssembly());
            cardName = "_" + rankey.ToString();
            label.Text = rankey.ToString();
            button.BackgroundImage = (Image)rm.GetObject(cardName);
            return rankey;
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

        public static void insertcard()
        {
            string constr = "server=118.89.29.115;User Id=root;password=ccx1986719824;Database=card";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            string conUpdateGolden = "update playercard set player_card_quantity=@playercardquantity where user_name = @username";
            MySqlCommand mycmdWYL2 = new MySqlCommand(conUpdateGolden, mycon);
            mycmdWYL2.Parameters.AddRange(
                new MySqlParameter[]
                {
                     new MySqlParameter("@playercardquantity",MySqlDbType.String) {Value=shuihuini },
                     new MySqlParameter("@username",MySqlDbType.String) {Value=login.userName }

                }
            );
            mycmdWYL2.ExecuteNonQuery();
            mycon.Close();
        }

        public static string[] spiltcardinfo(string playercardquantity)
        {
            string[] cardinfo = playercardquantity.Split('_');
            return cardinfo;
        }
        public static void getplayercard(string userName)
        {
            string constr = "server=118.89.29.115;User Id=root;password=ccx1986719824;Database=card";
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();
            string conUpdateGolden = "Select * from playercard where user_name=@userName";
            MySqlCommand mycmdWYL2 = new MySqlCommand(conUpdateGolden, mycon);
            mycmdWYL2.Parameters.AddRange(
                new MySqlParameter[]
                {
                            new MySqlParameter("@userName",MySqlDbType.String) {Value=userName }
                }
                );
            MySqlDataReader myDRWYL = mycmdWYL2.ExecuteReader();
            //string playercard;
            if (myDRWYL.Read())
            {
                favorites.cardtype = myDRWYL["card_type"].ToString();
                favorites.playercardquantity = myDRWYL["player_card_quantity"].ToString();
            }
            //favorites.cardinfo = spiltcardinfo(favorites.playercardquantity);
            for (int i = 0; i < (favorites.playercardquantity.Split('_')).Length; i++)
            {
                favorites.cardinfo[i] = (favorites.playercardquantity.Split('_'))[i];
            }

            myDRWYL.Close();
            mycon.Close();
        }
        public static void viewcard(int page, Button[] bts, Label[] labels, string[] cardinfo)
        {
            ResourceManager rm = new ResourceManager("WindowsFormsApplication1.Properties.Resources", Assembly.GetExecutingAssembly());
            string cardname;
            for (int i = 0; i < 6; i++)
            {
                cardname = "_" + ((page - 1) * 6 + i + 1).ToString();
                labels[i].Text = "No." + ((page - 1) * 6 + i + 1).ToString();
                bts[i].BackgroundImage = (Image)rm.GetObject(cardname);
                int realpage = (page - 1) * 6 + i;
                if (cardinfo[realpage] != null)
                {
                    //if (cardinfo[realpage] == "")
                    //{
                    //    cardinfo[realpage] = "0";
                    //}
                    if (cardinfo[realpage] == "0")
                    {
                        labels[i + 6].BackColor = Color.Gray;
                    }
                    labels[i + 6].Text = cardinfo[realpage] + " 张";
                }
                else
                {
                    labels[i + 6].BackColor = Color.Gray;
                    labels[i + 6].Text = "0 张";
                }
            }
        }
    }
}
