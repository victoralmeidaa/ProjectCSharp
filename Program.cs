string nome;
string descricao;

ExibirTitulo();
nome = ColetarDados("Informe o nome do solicitante: ");
descricao = ColetarDados("Informe a descrição do problema: ");



Console.WriteLine();
Console.WriteLine("=== Resumo do chamado ===");
Console.WriteLine($"=== Solicitante: {nome} ===");
Console.WriteLine($"=== Descrição do problema: {descricao}  ===");

void ExibirTitulo()
{
    Console.WriteLine("=== Cadastro de Chamado ===");
}
string ColetarDados(string mensagem)
{
    while(true)
    {
        Console.Write(mensagem);
        string valor = Console.ReadLine()??"";
        if(!string.IsNullOrWhiteSpace(valor))
        {
            return valor;
        }
        Console.WriteLine("Erro: O campo não pode ser vazio! Por favor, Informe um valor válido.");
    }
}