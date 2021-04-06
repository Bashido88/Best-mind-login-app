using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace OliveiraTradeFrontPage.Classes
{
    public class conexao
    {
        SqlConnection connection = new SqlConnection();
        public conexao()
        {
            connection.ConnectionString = (@"Data Source=ART2-PC;Initial Catalog=OliveiraTrade;Integrated Security=True");
        }

        public SqlConnection conectar()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void desconectar()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
