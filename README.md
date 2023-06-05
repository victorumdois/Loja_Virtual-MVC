![loja-virtual-gif](https://github.com/victorumdois/Loja_Virtual-MVC/assets/88866368/c240fd6d-97b2-49ed-8418-43e681051246)

# Loja Virtual - MVC

A Loja Virtual - MVC é uma aplicação **ASP.NET** com o padrão de arquitetura **Model-View-Controller** que permite a criação e gerenciamento de uma loja virtual online.

(Algumas partes da aplicação foram implementadas de forma simplificada para facilitar a compreensão do ASP.NET MVC.)

## Como Executar

- Clone ou faça o download deste repositório.
- Execute o arquivo `Loja_Virtual-MVC.sln` para abrir o projeto no Visual Studio.
- Altere a `ConnectionStrings` no arquivo `appsettings.json` se necessário.
- Abra o Console do Gerenciador de Pacotes e execute o comando `Update-Database` para criar o banco de dados.
- Aperte CTRL + F5 para iniciar a aplicação.

## Ferramentas e Tecnologias usadas
- .NET 6.0
- Visual Studio
- SQL Server Management Studio
- Bootstrap

## Pacotes

- Entity Framework Core
- Entity Framework Core Design
- Entity Framework Core Tools
- Entity Framework Core SQL Server

## Páginas
- Home: Esta é a página principal da loja, onde os clientes podem visualizar todos os produtos disponíveis.
- - Produto: Exibe informações detalhadas sobre um produto específico, incluindo 3 imagens, descrição, preço e a opção de compra.
- ADMIN: Página de visualização e gerenciamento dos produtos pelos administradores.
- - Adicionar produto: Adicionar um produto.
- - Editar produto: Modificar, atualizar informações de um produto.
- - Deletar produto: Confirmar a exclusão de um produto.
