# Industries Dan.mdb
Esse ficheiro tem que estar imperativamente na raiz do C:\Industries Dan_PAP\ para que o aplicativo funcione

# Folder Industries-Manager
Colocar o que está dentro desta pasta (ou apenas o ficheiro Industries Dan.mdb) colocar nesta pasta C:\Industries Dan_PAP\

# Industries-Manager.sln
Este é o inicializador do editor do projeto, os proximos pontos são todos sobre cada formulario e como funciona

## Industries-Manager Login
Este formulario faz a verificação das credenciais do usuario (email e palavra-pass). Quando verificado introduz essas informações na base de dados, mais especificamente, na tabela Login_Funcionario. Na tabela Login_Funcionario fica registado toda a atividade de entrada e saida no programa por parte do utilizador (Login's e Logout's, futuramente tambem tentativas de login para que se possa ser tomadas medidas preventivas)

## Industries-Manager PMenu
O formulario PMenu, que quer dizer (de forma invertida) Menu Principal, faz a ligação a todas as funcionalidades do Applicativo, como a gestão de pessoal, gestão de comercial, gestão financeira, gestão de informação. Outra das coisas que foi implementado foi uma saudação dependendo da hora do dia, por exemplo se for antes do meio dia aparece uma mensagem do genero : "Bom dia, [nome_do_utilizador]"; se for depois do meio dia e antes das 21 horas aparece : "Boa tarde, [nome_do_utilizador]"; se for depois das 21 e antes das 5 da manhã aparece : "Boa noite, [nome_do_utilizador]". Tambem é dado ao utilizador um botão para realizar o seu Logout para poder fazer o login com outro utilizador. Quando o utilizar fecha o formulario do PMenu é realizado o Logout da mesma forma que seria clicando no botão Logout. Outra função que vai ser implementada no futuro vai ser a dos avisos que irá mudar a cor quando tiver algum e irá se poder clicar nele e irá aparecer os varios avisos em varios ToolStripMenuItem's

## Industries-Manager Clientes
O formulario de clientes proporciona ao utilizador as opções de para ver os clientes existentes, as compras realizadas e os produtos que se encontram dentro de cada compra. Outra coisa que permite é adicionar novos clientes e remover (se ainda não tiver efetuado nenhuma compra)
