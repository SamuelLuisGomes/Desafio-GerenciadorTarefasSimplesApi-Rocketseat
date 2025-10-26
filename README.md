# 🚀 Gerenciador de Tarefas Simples

#### Um sistema de gerenciamento de tarefas (TODO List) construído com .NET e Csharp

## 🌟 Sobre o Projeto

Este projeto é uma API RESTful simples para gerenciamento de tarefas (CRUD de Tasks).
Foi desenvolvido com o objetivo principal de consolidar conhecimentos em **Arquitetura de Software** e **Boas Práticas** no ecossistema .NET.

### Conceitos e Aprendizados Focados:

- **Arquitetura em Camadas (Layered Architecture):** Separação clara entre `Controller`, `Service` e `Repository/Data`.
- **Injeção de Dependência (DI):** Uso do container de DI nativo do .NET para gerenciar o ciclo de vida dos serviços.
- **Simulação de Banco de Dados em Memória:** Uso de `List<T>` para simular o armazenamento de dados, mantendo a arquitetura pronta para migrar para um DB real (ex: Entity Framework Core).
- **Validação de Dados:** Utilização do **Fluent Validation** para regras de negócio mais robustas e legíveis.
- **Tratamento de Exceções:** Implementação de uma estratégia de **tratamento de erros centralizada** para capturar exceções (ex: "Não Encontrado", "Requisição Inválida") e mapeá-las para códigos de status HTTP apropriados (`404 Not Found`, `400 Bad Request`, etc.).

## 🛠️ Funcionalidades e Endpoints

A API expõe os seguintes recursos para manipulação das Tasks:

| Método HTTP | Endpoint          | Descrição                                        |
| :---------: | :---------------- | :----------------------------------------------- |
|   `POST`    | `/api/tasks`      | Cria uma nova tarefa.                            |
|    `GET`    | `/api/tasks`      | Retorna a lista de todas as tarefas.             |
|    `GET`    | `/api/tasks/{id}` | Retorna uma tarefa específica por ID.            |
|    `PUT`    | `/api/tasks/{id}` | Atualiza uma tarefa existente (todos os campos). |
|  `DELETE`   | `/api/tasks/{id}` | Remove uma tarefa por ID.                        |

## 💻 Tecnologias

- **Linguagem:** C#
- **Framework:** .NET 8 (ou a versão que você estiver usando)
- **Framework Web:** ASP.NET Core
- **Documentação:** Swagger UI
- **Validação:** Fluent Validation

## ⚙️ Como Rodar Localmente

### Pré-requisitos Certifique-se de ter instalado em sua máquina:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download) ou superior.
- Uma IDE de sua preferência (Visual Studio 2022, Jetbrains Rider ou VS Code com C# Dev Kit).

### Passos

1. **Clone o repositório**

```
git clone https://github.com/SamuelLuisGomes/Desafio-GestaoLivrariaApi-Rocketseat.git
```

2. Restaure as dependências (se necessário):

```
dotnet restore
```

3. Execute a aplicação pela IDE ou pelo terminar com:

```
dotnet run
```

A API estará rodando em `https://localhost:7xxx` (A porta exata é exibida no terminal).

4. **Acesse a Documentação:** Abra seu navegador e acesse:
   `https://localhost:7xxx/swagger` Você poderá interagir com todos os endpoints diretamente na interface do Swagger UI.

👤 Autor
[Samuel Luis Gomes](https://github.com/SamuelLuisGomes)

- **[GitHub](https://github.com/SamuelLuisGomes)**
- [LinkedIn](https://www.linkedin.com/in/samuel-gomes-6b4a6a1ab/)
