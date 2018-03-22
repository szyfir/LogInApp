using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace LogInApp
{
    public class dbRegister : Register
    {

        public dbRegister(string FirstName,string Name,string Mail,string Pass)
        {

            string ConnectionString = "datasource = localhost; port = 3306; Database = logowanie_sklep; username = root; Password = ;";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            string query = "INSERT INTO uzytkownicy (id, Imie, Naziwsko, email, haslo) values (null, @1, @2, @3, @4)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@1",FirstName);
            cmd.Parameters.AddWithValue("@2", Name);
            cmd.Parameters.AddWithValue("@3", Mail);
            cmd.Parameters.AddWithValue("@4", Pass);
            cmd.ExecuteNonQuery();
            connection.Close();


        }


    }
}