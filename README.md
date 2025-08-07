# :briefcase: CrudSqlServer

## :book: Descrição

**CrudSqlServer** é um projeto em **C# (Console Application)** que demonstra a implementação dos princípios do **CRUD (Create, Read, Update, Delete)** com uma arquitetura em camadas bem definida. O sistema interage com um banco de dados **SQL Server**, utilizando **Dapper** como micro ORM e **FluentValidation** para validação de dados.

---

## :bricks: Estrutura do Projeto

O projeto está organizado da seguinte forma:

- :open_file_folder: **Controllers**  
  Responsável por gerenciar o fluxo da aplicação, conectando a entrada do usuário com a lógica de negócio. Aqui estão os métodos para criar, atualizar, listar e excluir funcionários.

- :open_file_folder: **Entities**  
  Contém as classes de domínio que representam os dados principais do sistema, como a entidade `Funcionario`.

---

## :tools: Tecnologias Utilizadas

- :receipt: **C# (.NET - Console Application)**
- :file_cabinet: **Microsoft SQL Server**
- :gear: **Dapper** – Acesso simplificado ao banco de dados
- :white_check_mark: **FluentValidation** – Validação de dados com regras claras

---

## :sparkles: Funcionalidades

- [x] Cadastro de funcionários  
- [x] Listagem de funcionários  
- [x] Atualização de dados  
- [x] Exclusão de registros  
- [x] Validação de entrada de dados  
- [x] Arquitetura modular com separação de camadas  

---



### :pushpin: Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado  
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) instalado e configurado  
- [Visual Studio](https://visualstudio.microsoft.com/) (ou outro editor C# compatível)  
