# Sistema de Agendamento - Gerenciamento de Pacientes

Trabalho acadêmico desenvolvido em ASP.NET Core MVC para gerenciar pacientes de uma aplicação de agendamento.

O projeto utiliza Entity Framework Core com PostgreSQL, migrations, Data Annotations, seeding e telas Razor para realizar as operações de cadastro, consulta, edição e remoção.

## Funcionalidades

- Listagem de pacientes;
- Cadastro de novos pacientes;
- Edição de pacientes existentes;
- Remoção com tela de confirmação;
- Validação dos formulários com Data Annotations;
- Criação do banco por migration;
- Inserção automática de pacientes iniciais por seeding.

## Dados do paciente

Cada paciente possui:

- Nome;
- CPF;
- Telefone;
- Endereço;
- Data de nascimento.

## Tecnologias

- C#;
- .NET 9;
- ASP.NET Core MVC;
- Razor Views e Tag Helpers;
- Entity Framework Core 9;
- Npgsql;
- PostgreSQL;
- Bootstrap;
- Git e GitHub.

## Estrutura principal

```text
Controllers/
  PacientesController.cs
Data/
  AppDbContext.cs
  SeedingService.cs
Migrations/
Models/
  Paciente.cs
Views/
  Pacientes/
    Create.cshtml
    Delete.cshtml
    Edit.cshtml
    Index.cshtml
```

## Pré-requisitos

- .NET SDK 9.0;
- PostgreSQL instalado e em execução;
- usuário `postgres` com acesso à porta `5432`;
- Git.

## Como executar

Clone o repositório e entre na pasta do projeto:

```powershell
git clone https://github.com/leomolinari14/trabalho-pacientes-dotnet.git
cd trabalho-pacientes-dotnet
```

Restaure a ferramenta local do Entity Framework e as dependências:

```powershell
dotnet tool restore
dotnet restore
```

Configure a conexão local substituindo `SUA_SENHA` pela senha do usuário `postgres`:

```powershell
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Database=Agendamento;Username=postgres;Password=SUA_SENHA"
```

A senha é armazenada pelo User Secrets fora do repositório e não deve ser adicionada ao Git.

Crie ou atualize o banco de dados com a migration:

```powershell
dotnet ef database update
```

Execute a aplicação:

```powershell
dotnet run
```

Abra o endereço apresentado no terminal e acesse o item **Pacientes** no menu. No perfil HTTP padrão, o endereço é:

```text
http://localhost:5212/Pacientes
```

## Seeding

No ambiente de desenvolvimento, a aplicação verifica se a tabela `Pacientes` está vazia. Quando necessário, são inseridos dois pacientes iniciais para demonstração.

O método `Any()` impede que esses registros sejam duplicados nas próximas execuções.

## Histórico de desenvolvimento

O trabalho foi construído de forma incremental, com commits separados para a estrutura MVC, Model, validações, Entity Framework Core, contexto, migration, seeding e cada operação do CRUD.
