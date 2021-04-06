Best-mind-login-app é uma aplicação desenvolvida para o teste pratico do programa de trainee Best minds da Everymind, para um cliente fictício onde o seu proposito é:

- Criar uma solução de Sing in e Sing up.
- Permitir a criação de novos usuários de maneira intuitiva e pratica.

Features
--------

- GUIs moderna
- API Desenvolvida em C#


Instalação
----------
Para a utilização desta aplicação e necessário uma plataforma de execução para C#, como sugestão deixo o [.net versão 3.1](https://dotnet.microsoft.com/download/dotnet/3.1/runtime/?utm_source=getdotnetcore&utm_medium=referral)

1. Descompactação do arquivo
2. Descompactação da pasta debug no caminho
...\Best-mind-login-app-main\OliveiraTradeFrontPage\obj\Debug.zip
3. Executar a aplicação pelo executável no caminho
...\Best-mind-login-app-main\OliveiraTradeFrontPage\bin\Debug\netcoreapp3.1\OliveiraTradeLoginSolution.exe

Instalação do Banco de Dados
----------------------------
O banco de dados foi criado em SQL utilizando a plataforma de desenvolvimento [SSMS 18.8](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver15)
1. Juntamente com arquivos da aplicação disponibilizei o arquivo de Backup cujo o nome é [BD OliveiraTrade.bak]
2. A configuração padrão da classe "Conexao" utiliza como padrão a sessão criada na minha maquina durante o desenvolvimento da aplicação nessa linha "connection.ConnectionString = (@"Data Source=ART2-PC;Initial Catalog=OliveiraTrade;Integrated Security=True");" 
3. Para o correto funcionamento esta linha deve ser atualizada com as configurações de sessão da maquina na qual o banco de dados será instalado
4. A nomenclatura do banco de dados deve ser mantida pois há referencias no código com o mesmo nome.
5. usuário e senha padrões da sessão SQL 

Modo de utilização
------------------
- A aplicação já contem um usuário padrão cadastrado para testes (admin, admin).
- Na tela de login caso algum campo fique vazio ou as informações preenchidas não estejam corretas a aplicação exibira uma mensagem de erro.
- Ainda na tela de login caso as informações constem no banco de dados o login e feito e a tela principal surge.
- Na tela de criação de usuário segue o mesmo conceito campos vazios ou senhas não correspondentes também ativarão uma mensagem de erro.
- Continuando na tela de criação de usuário com todas as informações preenchidas corretamente a mensagem de cadastro concluído com sucesso aparece e as informações serão salvas no banco de dados.

Licença
-------
Essa aplicação não requer licença de uso, sinta-se livre para usa-la e copia-la 