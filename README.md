### Resumo do Projeto

Este projeto é um aplicativo .NET MAUI para gerenciamento acadêmico, que inclui funcionalidades para gerenciar períodos, cursos e disciplinas. O aplicativo possui uma tela de login inicial e utiliza SQLite para armazenamento de dados.

### Estrutura do Projeto

#### 1. Tela de Login

**Arquivos:**
- `LoginPage.xaml`
- `LoginPage.xaml.cs`

**Descrição:**
A tela de login autentica o usuário antes de permitir o acesso às outras páginas do aplicativo. A autenticação é feita de forma estática.

**Componentes:**
- `Image`: Exibe um ícone de usuário.
- `Entry`: Campo de entrada para o nome de usuário.
- `Entry`: Campo de entrada para a senha.
- `Button`: Botão para realizar o login.

**Lógica de Autenticação:**
- Verifica se o nome de usuário e a senha são iguais a `"admin"` e `"admin"`, respectivamente.
- Se as credenciais estiverem corretas, navega para a `AppShell`.
- Se as credenciais estiverem incorretas, exibe um alerta de erro.

#### 2. Gerenciamento de Períodos

**Arquivos:**
- `PeriodosPage.xaml`
- `PeriodosPage.xaml.cs`
- `Periodo.cs`

**Descrição:**
A página de períodos permite ao usuário gerenciar os períodos acadêmicos.

**Componentes:**
- `Entry`: Campo de entrada para o nome do período.
- `Entry`: Campo de entrada para a sigla do período.
- `Button`: Botões para inserir, atualizar, ler e deletar períodos.

**Modelo de Dados:**

```csharp
public class Periodo
{
    [PrimaryKey, AutoIncrement]
    public int PerId { get; set; }
    public string PerNome { get; set; }
    public string PerSigla { get; set; }
}

```

#### 3. Gerenciamento de Cursos

**Arquivos:**
- `CursosPage.xaml`
- `CursosPage.xaml.cs`
- `Curso.cs`

**Descrição:**
A página de cursos permite ao usuário gerenciar os cursos acadêmicos.

**Componentes:**
- `Entry`: Campo de entrada para o nome do curso.
- `Entry`: Campo de entrada para a sigla do curso.
- `Editor`: Campo de entrada para observações sobre o curso.
- `Entry`: Campo de entrada para o ID do período.
- `Button`: Botões para inserir, atualizar, ler e deletar cursos.

**Modelo de Dados:**

```csharp
public class Curso
{
    [PrimaryKey, AutoIncrement]
    public int CurId { get; set; }
    public string CurNome { get; set; }
    public string CurSigla { get; set; }
    public string CurObservacoes { get; set; }
    public int PerId { get; set; }
}

```

#### 4. Gerenciamento de Disciplinas

**Arquivos:**
- `DisciplinasPage.xaml`
- `DisciplinasPage.xaml.cs`
- `Disciplina.cs`

**Descrição:**
A página de disciplinas permite ao usuário gerenciar as disciplinas acadêmicas.

**Componentes:**
- `Entry`: Campo de entrada para o nome da disciplina.
- `Entry`: Campo de entrada para a sigla da disciplina.
- `Editor`: Campo de entrada para observações sobre a disciplina.
- `Entry`: Campo de entrada para o ID do curso.
- `Button`: Botões para inserir, atualizar, ler e deletar disciplinas.

**Modelo de Dados:**

```csharp
public class Disciplina
{
    [PrimaryKey, AutoIncrement]
    public int DisId { get; set; }
    public string DisNome { get; set; }
    public string DisSigla { get; set; }
    public string DisObservacoes { get; set; }
    public int CurId { get; set; }
}

```

#### 5. Banco de Dados

**Arquivo:**
- `Database.cs`

**Descrição:**
A classe `Database` gerencia a conexão e as operações com o banco de dados SQLite.

**Métodos Principais:**
- `GetPeriodosAsync()`: Retorna a lista de períodos.
- `SavePeriodoAsync(Periodo periodo)`: Salva ou atualiza um período.
- `DeletePeriodoAsync(Periodo periodo)`: Deleta um período.
- `GetCursosAsync()`: Retorna a lista de cursos.
- `SaveCursoAsync(Curso curso)`: Salva ou atualiza um curso.
- `DeleteCursoAsync(Curso curso)`: Deleta um curso.
- `GetDisciplinasAsync()`: Retorna a lista de disciplinas.
- `SaveDisciplinaAsync(Disciplina disciplina)`: Salva ou atualiza uma disciplina.
- `DeleteDisciplinaAsync(Disciplina disciplina)`: Deleta uma disciplina.

#### 6. Navegação

**Arquivo:**
- `AppShell.xaml`

**Descrição:**
Define a estrutura de navegação do aplicativo, incluindo o Flyout e o TabBar.

**Componentes:**
- `FlyoutItem`: Itens de menu para navegar entre as páginas de períodos, cursos e disciplinas.
- `TabBar`: Abas para navegação rápida entre as páginas.

### Configuração do Projeto

**Arquivo:**
- `MauiProgram.cs`

**Descrição:**
Configura o aplicativo .NET MAUI, incluindo fontes e logging.


```csharp
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

```

### Resumo

Este projeto é um aplicativo .NET MAUI para gerenciamento acadêmico, com funcionalidades para gerenciar períodos, cursos e disciplinas. O aplicativo possui uma tela de login inicial e utiliza SQLite para armazenamento de dados. A navegação é gerenciada pelo `AppShell`, que inclui um Flyout e um TabBar para facilitar a navegação entre as diferentes páginas.
