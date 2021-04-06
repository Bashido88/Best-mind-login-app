using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace OliveiraTradeFrontPage.Classes
{
    public class comandos
    {
        public bool match = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        conexao connection = new conexao();
        SqlDataReader reader;

        public bool logincheck(string Username, string senha)
        {
            cmd.CommandText = "SELECT * FROM users WHERE Username = @Username AND Senha = @senha";
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = connection.conectar();
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    match = true;
                }
                connection.desconectar();
                reader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Ops, algo deu errado no Banco de dados!!";
            }
            return match;
        }
        public string cadastrar(string Username, string senha, string confirmasenha)
        {
            match = false;
            
            if (!Username.Equals("") && !senha.Equals("") && !confirmasenha.Equals("") && senha.Equals(confirmasenha))
            {
                cmd.CommandText = "INSERT INTO users VALUES (@Username, @senha);";
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@senha", senha);
                try
                {
                    cmd.Connection = connection.conectar();
                    cmd.ExecuteNonQuery();
                    connection.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    match = true;
                }
                catch
                {
                    this.mensagem = "Ops, algo deu errado no Banco de dados";
                }
            }
            else
            {
                this.mensagem = "Ei, alguem esqueceu alguma coisa ou as senhas não estão iguais...";
            }

            return mensagem;
        }
    }
}
