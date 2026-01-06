• API de Pedidos – ASP.NET Core

• API REST desenvolvida em ASP.NET Core para gerenciamento de pedidos.

• Suas Funcionalidades:
- Criar pedidos
- Listar pedidos
- Aprovar pedidos
- Cancelar pedidos

• Tecnologias utilizadas
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)
- Git e GitHub

• Conceitos aplicados
- REST API
- Arquitetura em camadas (Controllers, Data, Models)
- Validações de regras de negócio


▶️ Como executar a API localmente

• Pré-requisitos
  • Antes de começar, você precisa ter instalado na sua máquina:
    - .NET SDK 7 ou superior
    - SQL Server ou SQL Server LocalDB
    - Git (opcional, para clonar o repositório)

É crucial o dotnet ef estar instalado, então execute no cmd o comando: 

dotnet tool install --global dotnet-ef

Agora, no terminal das pasta do projeto, rode:

dotnet restore
dotnet ef database update
dotnet run

Após executar o comando `dotnet run`, a API ficará escutando em:
http://localhost:5261

E a documentação Swagger pode ser acessada em:
http://localhost:5261/swagger


