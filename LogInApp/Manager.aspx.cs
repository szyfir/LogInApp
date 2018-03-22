using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace LogInApp
{
    public partial class Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConnectionString = "datasource = localhost; port = 3306; Database = logowanie_sklep; username = root; Password = ;";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from uzytkownicy", connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}