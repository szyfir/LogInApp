using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogInApp
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {






        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string ConnectionString = "datasource = localhost; port = 3306; Database = logowanie_sklep; username = root; Password = ;";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();


            string login = tbEmail.Text;
            string pass = tbHaslo.Text;

            string query = $"Select imie from uzytkownicy where email='{login}' and haslo='{pass}'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
           
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("RegisterSucess.aspx?Imie=" + dt.Rows[0][0]);
            }
            else
            {

                labWynik.Text = "Błędny login lub hasło";
            }





            connection.Close();
        }
    }
}