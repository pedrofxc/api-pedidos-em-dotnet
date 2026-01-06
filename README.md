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

No terminal das pasta do projeto, rode:

dotnet restore
dotnet ef database update
dotnet run

Após isso, acesse localmente:

https://localhost:5001/swagger


