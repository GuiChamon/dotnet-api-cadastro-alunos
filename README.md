# 📚 CadastroAlunosAPI

API REST criada em ASP.NET Core com Entity Framework para gerenciar o cadastro de alunos.

> 🔁 Atividade de **revisão prática** sobre criação de APIs REST utilizando o framework **.NET**, abordando conceitos de **Web APIs**, **controllers**, **rotas**, **injeção de dependência**, e **Swagger**.

---

## 🚀 Tecnologias Usadas

- 🟣 **.NET 6** – plataforma principal da API
- 🗄️ **Entity Framework Core (InMemory)** – para salvar dados sem banco real (ideal pra testes!)
- 📘 **Swagger** – teste todos os endpoints direto no navegador
- 💻 **Visual Studio Code** 
- 🔤 **C#** – o coração do projeto

---

## 📌 Funcionalidades da API

- `GET /api/alunos` → Lista todos os alunos
- `GET /api/alunos/{id}` → Consulta um aluno por ID
- `POST /api/alunos` → Cadastra um novo aluno
- `PUT /api/alunos/{id}` → Atualiza os dados de um aluno existente
- `DELETE /api/alunos/{id}` → Remove um aluno

---

## 🧪 Como testar a API

### 1. Clone o repositório

```bash
git clone https://github.com/GuiChamon/dotnet-api-cadastro-alunos.git
cd dotnet-api-cadastro-alunos
