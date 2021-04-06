Best-mind-login-app � uma aplica��o desenvolvida para o teste pratico do programa de trainee Best minds da Everymind, para um cliente fict�cio onde o seu proposito �:

- Criar uma solu��o de Sing in e Sing up.
- Permitir a cria��o de novos usu�rios de maneira intuitiva e pratica.

Features
--------

- GUIs moderna
- API Desenvolvida em C#


Instala��o
----------
Para a utiliza��o desta aplica��o e necess�rio uma plataforma de execu��o para C#, como sugest�o deixo o [.net vers�o 3.1](https://dotnet.microsoft.com/download/dotnet/3.1/runtime/?utm_source=getdotnetcore&utm_medium=referral)

1. Descompacta��o do arquivo
2. Descompacta��o da pasta debug no caminho
...\Best-mind-login-app-main\OliveiraTradeFrontPage\obj\Debug.zip
3. Executar a aplica��o pelo execut�vel no caminho
...\Best-mind-login-app-main\OliveiraTradeFrontPage\bin\Debug\netcoreapp3.1\OliveiraTradeLoginSolution.exe

Instala��o do Banco de Dados
----------------------------
O banco de dados foi criado em SQL utilizando a plataforma de desenvolvimento [SSMS 18.8](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver15)
1. Juntamente com arquivos da aplica��o disponibilizei o arquivo de Backup cujo o nome � [BD OliveiraTrade.bak]
2. A configura��o padr�o da classe "Conexao" utiliza como padr�o a sess�o criada na minha maquina durante o desenvolvimento da aplica��o nessa linha "connection.ConnectionString = (@"Data Source=ART2-PC;Initial Catalog=OliveiraTrade;Integrated Security=True");" 
3. Para o correto funcionamento esta linha deve ser atualizada com as configura��es de sess�o da maquina na qual o banco de dados ser� instalado
4. A nomenclatura do banco de dados deve ser mantida pois h� referencias no c�digo com o mesmo nome.
5. usu�rio e senha padr�es da sess�o SQL 

Modo de utiliza��o
------------------
- A aplica��o j� contem um usu�rio padr�o cadastrado para testes (admin, admin).
- Na tela de login caso algum campo fique vazio ou as informa��es preenchidas n�o estejam corretas a aplica��o exibira uma mensagem de erro.
- Ainda na tela de login caso as informa��es constem no banco de dados o login e feito e a tela principal surge.
- Na tela de cria��o de usu�rio segue o mesmo conceito campos vazios ou senhas n�o correspondentes tamb�m ativar�o uma mensagem de erro.
- Continuando na tela de cria��o de usu�rio com todas as informa��es preenchidas corretamente a mensagem de cadastro conclu�do com sucesso aparece e as informa��es ser�o salvas no banco de dados.

Licen�a
-------
Essa aplica��o n�o requer licen�a de uso, sinta-se livre para usa-la e copia-la 