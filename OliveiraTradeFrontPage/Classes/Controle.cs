using System;
using System.Collections.Generic;
using System.Text;

namespace OliveiraTradeFrontPage.Classes
{
    public class Controle
    {
        public bool match;
        public string mensagem = "";

        public bool conexaobd(string Username, string senha)
        {
            comandos comando = new comandos();
            match = comando.logincheck(Username, senha);

            if (! comando.mensagem.Equals(""))
            {
                this.mensagem = comando.mensagem;
            }
            return match;
        }

        public string cadastrar(string Username, string senha, string confirmasenha)
        {
            comandos comando = new comandos();
            this.mensagem = comando.cadastrar(Username, senha, confirmasenha);
            if(comando.match)
            {
                this.match = true;
            }
            return mensagem;
        }
    }
}
