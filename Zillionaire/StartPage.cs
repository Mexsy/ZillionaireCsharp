using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zillionaire
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            showTopPlayers();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            //string queryString = "SELECT OrderID, CustomerID FROM dbo.Orders;";

            

            Form1 form1 = new Form1(player_name.Text);
            form1.Show();
        }
        
        public void showTopPlayers()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Emeka\source\repos\Zillionaire\Zillionaire\Database2.mdf;Integrated Security=True");
            SqlDataReader rd;

                using (con)
                {
                    SqlCommand cmd = new SqlCommand("getscores", con); // getscores-> stored procedure name
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                    string name = rd[0].ToString();
                    string score = rd[1].ToString();
                    score_list_box.Items.Add(name + ": " + score);
                    }
                    rd.Close();
                }
                con.Close();
        }

      
    }
}
