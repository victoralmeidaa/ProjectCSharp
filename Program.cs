string nome;
string descricao;

ExibirTitulo();
nome = ColetarNome("Informe o nome do solicitante: ");
descricao = ColetarDados("Informe a descrição do problema: ");

Console.WriteLine();
Console.WriteLine("=== Resumo do chamado ===");
Console.WriteLine($"=== Solicitante: {nome} ===");
Console.WriteLine($"=== Descrição do problema: {descricao}  ===");

void ExibirTitulo()
{
    Console.WriteLine("=== Cadastro de Chamado ===");
}
string ColetarDados(string mensagem) // Coleta e valida se o campo não está vazio.
{ 
    while(true)
    {
        Console.Write(mensagem);
        string nome = Console.ReadLine()??"";  // Coleta nome do solicitante e garante que não seja nulo.
        if(!string.IsNullOrWhiteSpace(nome)) // Valida se o campo não está vazio ou contém apenas espaços.
        {
            return nome;
        }
        Console.WriteLine("Erro: O campo não pode ser vazio! Por favor, Informe um valor válido.");
    }
}
bool NomeValido(string texto) // Valida se o nome informado contém apenas letras e espaços
{
    foreach(char caractere in texto) // Laço que percorre cada caractere do texto informado.
    {
        if(!char.IsLetter(caractere) && !char.IsWhiteSpace(caractere)) // Verifica se o caractere não é uma letra e não é um espaço.
        {
            return false; // Retorna falso se encontrar um caractere inválido, número ou caractere especial.
        } 
    }
    return true; // Retorna verdadeiro se todos os caracteres forem validos, letras ou espaços.
}
string ColetarNome(string mensagem) // Coleta o nome do solicitante.
{
    while(true)
    {
        string nome = ColetarDados(mensagem); //  Chama o método ColetarDados que ler e valida se o campo não está vazio.
        if(NomeValido(nome)) // Método NomeValido retorna verdadeiro se o nome contém apenas letras e espaços.
        {
            return nome; // Se verdadeiro, retorna o nome informado.
        }
        Console.WriteLine("Erro: O campo não pode conter números ou caracteres especiais, Informe um nome válido!"); // Se falso, exibe erro e solicita novamente o nome.
    }
}