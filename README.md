# Estudos C# e .NET

## Sobre o projeto

Este repositório reúne exercícios práticos e projetos desenvolvidos durante o estudo da linguagem C# e da plataforma .NET, com foco na preparação para oportunidades de Desenvolvedor de Software Júnior.

O aprendizado será organizado de forma incremental, aplicando boas práticas de programação, Clean Code, controle de versão e documentação técnica.

## Objetivos

- Aprender os fundamentos da linguagem C#.
- Compreender a plataforma .NET e seu ecossistema.
- Desenvolver aplicações utilizando boas práticas de programação.
- Aprender a criar APIs e integrar aplicações com bancos de dados.
- Praticar testes, depuração e manutenção de sistemas.
- Utilizar Git e Conventional Commits para controlar as alterações.
- Documentar os conceitos e as funcionalidades implementadas.

## Tecnologias

- **Linguagem:** C#
- **Plataforma:** .NET
- **Editor:** Visual Studio Code
- **Controle de versão:** Git e GitHub

## Estrutura atual

```text
ProjectCSharp/
├── .gitignore
├── Program.cs
├── ProjectCSharp.csproj
└── README.md
```

## Funcionalidades atuais

### Primeiro programa

O programa inicial apresenta informações de exemplo utilizando variáveis e exibição de mensagens no terminal.

### Cadastro de Chamado

O programapermite cadastrar um chamado informando:
- Nome do solicitante.
- Descrição do problema

Os campos são validados para impedir que o usuário prossiga com informações vazias ou compostas apenas por espaços vazios.

Após o preenchimento correto, o programa exibe um resumo do chamado.

Conceitos praticados:
- Declaração de variáveis do tipo `string`.
- Leitura de dados com `Console.ReadLine()`.
- Exibição de informações como `Console.WriteLine()`.
- Interpolação de strings. 
- Validaação com `string.IsNullOrWhiteSpace()`.
- Estruturas de repetição como `while`.
- Controle de fluxo com `if` e `break`.
- Criação e chamada de métodos como `void`.
- Tratamento de possíveis valores nulos com `??`.

## Como executar

### Pré-requisitos

- SDK do .NET instalado.
- Terminal PowerShell ou equivalente.

### Execução

Na raiz do projeto, execute:

```powershell
dotnet run
```

O comando compila e executa a aplicação.

## Boas práticas adotadas

- Utilizar nomes de variáveis claros e significativos.
- Manter o código simples, legível e organizado.
- Evitar duplicação desnecessária.
- Atualizar a documentação conforme o projeto evoluir.
- Registrar alterações por meio de commits objetivos.
- Implementar funcionalidades gradualmente, validando cada etapa.

## Padrão de commits

O projeto utiliza a convenção Conventional Commits, com descrições em português.

Formato:

```text
tipo: descrição curta
```

Tipos utilizados:

- `feat`: adiciona uma funcionalidade.
- `fix`: corrige um erro.
- `refactor`: reorganiza o código sem alterar o comportamento esperado.
- `test`: adiciona ou modifica testes.
- `docs`: altera a documentação.
- `style`: altera formatação sem mudar o comportamento.
- `chore`: realiza tarefas de manutenção e configuração.
- `build`: altera a configuração de compilação ou dependências.
- `ci`: altera os processos de integração contínua.
- `perf`: melhora o desempenho.

## Próximas etapas

### Progresso dos estudos

- [x] Fundamentos de C# e entrada e saída de dados.
- [x] Variáveis, strings e interpolação.
- [x] Validação de entradas com `string.IsNullOrWhiteSpace()`.
- [x] Condições e estruturas de repetição com `if` e `while`.
- [x] Criação e chamada de métodos com `void`.
- [x] Desenvolver um cadastro de chamado com validação de campos.
- [ ] Praticar conversão e validação de tipos.
- [ ] Aprofundar métodos com parâmetros e valores de retorno.
- [ ] Trabalhar com classes e objetos.
- [ ] Desenvolver novos exercícios de cadastro e validação.
- [ ] Aprender testes automatizados e depuração.
- [ ] Avançar para APIs com ASP.NET Core e integração com banco de dados.

 ### Métodos 

 Foi criado o método "ExibirTitulo()" para separar a exibição do título da lógica principal do cadastro

 #### Conceitos praticados

 - Declaração de métodos com "void".
 - Chamada de métodos.
 - Separação de responsabilidades.

## Observações

Este é um projeto de aprendizado em desenvolvimento contínuo. A documentação e as funcionalidades serão atualizadas conforme novos conceitos forem estudados e implementados.