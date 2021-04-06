using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OliveiraTradeFrontPage.Classes;

namespace OliveiraTradeFrontPage
{
    public partial class SingPage : Form
    {
        public SingPage()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Controle control = new Controle();
            string mensagem = control.cadastrar(txbuser.Text.Trim(),txbpass.Text.Trim(),txbconfirma.Text.Trim());
            if (control.match)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(control.mensagem);
            }
        }
    }
}

