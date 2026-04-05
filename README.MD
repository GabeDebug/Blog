# 📝 Blog API

> Uma API de blog moderna e robusta construída com **C#**, **Dapper** e hospedada no **Microsoft Azure**.

---

## 🚀 Visão Geral

Este projeto é uma API RESTful para gerenciamento de um blog completo, desenvolvida em **ASP.NET Core** com acesso a dados via **Dapper** (micro-ORM), garantindo performance e controle total sobre as queries SQL. A aplicação é implantada e gerenciada na nuvem **Microsoft Azure**.

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Descrição |
|---|---|
| ![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white) **C# / ASP.NET Core** | Framework principal da aplicação |
| ![Dapper](https://img.shields.io/badge/Dapper-ORM-blue?style=flat) **Dapper** | Micro-ORM para acesso ao banco de dados |
| ![Azure](https://img.shields.io/badge/Microsoft%20Azure-0078D4?style=flat&logo=microsoftazure&logoColor=white) **Microsoft Azure** | Hospedagem e serviços em nuvem |
| ![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white) **Azure SQL / SQL Server** | Banco de dados relacional |

---

## 📁 Estrutura do Projeto

```
Blog/
├── Blog.Api/                  # Camada de apresentação (Controllers, Middlewares)
│   ├── Controllers/
│   ├── Program.cs
│   └── appsettings.json
│
├── Blog.Application/          # Regras de negócio (Services, DTOs)
│   ├── Services/
│   └── DTOs/
│
├── Blog.Domain/               # Entidades e interfaces do domínio
│   ├── Entities/
│   └── Interfaces/
│
├── Blog.Infrastructure/       # Acesso a dados com Dapper
│   ├── Repositories/
│   └── Data/
│
└── Blog.Tests/                # Testes unitários e de integração
```

---

## ⚙️ Funcionalidades

- ✅ **CRUD de Posts** — criação, leitura, atualização e remoção de artigos
- ✅ **Gerenciamento de Categorias** — organização dos posts por categoria
- ✅ **Sistema de Comentários** — comentários vinculados a posts
- ✅ **Autenticação e Autorização** — controle de acesso por perfil (Admin / Leitor)
- ✅ **Paginação** — listagem de posts com suporte a paginação
- ✅ **Slugs amigáveis** — URLs limpas para cada post

---

## 🧩 Por que Dapper?

O **Dapper** foi escolhido por oferecer:

- 🔥 **Alta performance** — praticamente sem overhead comparado ao ADO.NET puro
- 🎯 **Controle total do SQL** — queries otimizadas e legíveis
- 🪶 **Leveza** — sem a complexidade de um ORM completo como o Entity Framework
- 🔄 **Mapeamento simples** — converte resultados SQL diretamente para objetos C#

---

## ☁️ Infraestrutura Azure

A aplicação utiliza os seguintes serviços da **Microsoft Azure**:

| Serviço | Uso |
|---|---|
| **Azure App Service** | Hospedagem da API |
| **Azure SQL Database** | Banco de dados relacional gerenciado |
| **Azure Key Vault** | Armazenamento seguro de secrets e connection strings |
| **Azure Application Insights** | Monitoramento e logs da aplicação |

---

## 🔧 Como Rodar Localmente

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) ou SQL Server Express
- [Azure CLI](https://learn.microsoft.com/pt-br/cli/azure/install-azure-cli) *(opcional, para deploy)*

### Passo a passo

**1. Clone o repositório**
```bash
git clone https://github.com/seu-usuario/blog-api.git
cd blog-api
```

**2. Configure a connection string**

No arquivo `appsettings.Development.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=BlogDb;Trusted_Connection=True;"
  }
}
```

**3. Execute as migrations / scripts SQL**
```bash
# Execute os scripts da pasta /scripts na ordem numérica
sqlcmd -S localhost -d BlogDb -i scripts/001_create_tables.sql
```

**4. Rode a aplicação**
```bash
cd Blog.Api
dotnet run
```

**5. Acesse a documentação da API**
```
https://localhost:5001/swagger
```

---

## 🌐 Deploy no Azure

```bash
# Login no Azure
az login

# Publicar a aplicação
dotnet publish -c Release -o ./publish

# Deploy para o App Service
az webapp deploy --resource-group meu-grupo \
                 --name meu-blog-api \
                 --src-path ./publish
```

---

## 📖 Endpoints da API

### Posts
| Método | Rota | Descrição |
|---|---|---|
| `GET` | `/api/posts` | Lista todos os posts (paginado) |
| `GET` | `/api/posts/{slug}` | Busca um post pelo slug |
| `POST` | `/api/posts` | Cria um novo post |
| `PUT` | `/api/posts/{id}` | Atualiza um post |
| `DELETE` | `/api/posts/{id}` | Remove um post |

### Categorias
| Método | Rota | Descrição |
|---|---|---|
| `GET` | `/api/categories` | Lista todas as categorias |
| `POST` | `/api/categories` | Cria uma nova categoria |

### Comentários
| Método | Rota | Descrição |
|---|---|---|
| `GET` | `/api/posts/{id}/comments` | Lista comentários de um post |
| `POST` | `/api/posts/{id}/comments` | Adiciona um comentário |

---

## 🤝 Contribuindo

1. Faça um fork do projeto
2. Crie uma branch para sua feature: `git checkout -b feature/minha-feature`
3. Commit suas mudanças: `git commit -m 'feat: minha nova feature'`
4. Push para a branch: `git push origin feature/minha-feature`
5. Abra um Pull Request

---

## 📄 Licença

Este projeto está sob a licença **MIT**. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

<div align="center">
  Feito por Gabriel usando C#, Dapper e Azure
</div>