using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using OliveiraTradeFrontPage.Classes;

namespace OliveiraTradeFrontPage
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            usuariotxt.Select();
        }
        

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.conexaobd(usuariotxt.Text, passtxt.Text);
            if (controle.mensagem.Equals(""))
            {


                if (controle.match)
                {
                    MainPage main = new MainPage();
                    this.Hide();
                    main.Show();

                }

                else
                {
                    MessageBox.Show("Ops, algo deu errado !!!\nUsuario e senha nao encontrados ou incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuariotxt.Text = "";
                    passtxt.Text = "";
                    usuariotxt.Select();

                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnsing_Click(object sender, EventArgs e)
        {
            SingPage sing = new SingPage();
            sing.Show();
            
        }
    }
}
