void ExibirTitulo ()
{
    Console.WriteLine("=== Cadastro de Chamado ===");
}

string nome;
string descricao;

ExibirTitulo();

while(true) // Loop para garantir que o nome do solicitante não seja vazio.
{
    Console.WriteLine("Informe o nome do Solicitante: ");
    nome = Console.ReadLine() ?? "";
    if(!string.IsNullOrWhiteSpace(nome))
    {
        break;
    }
    Console.WriteLine("Error: Nome de solicitante não pode ser vazio. Por favor, Tente novamente.\n");
}
while(true) // Loop para garantir que a descrição do problema não seja vazio.
{
    Console.WriteLine("Informe a descrição do problema: ");
    descricao=Console.ReadLine()??"";
    if(!string.IsNullOrWhiteSpace(descricao))
    {
        break;
    }
    Console.WriteLine("Error: Deescrição do problema não pode ser vazio.  Por favor, Tente novamente.\n");
}
Console.WriteLine();
Console.WriteLine("=== Resumo do chamado ===");
Console.WriteLine($"=== Solicitante: {nome} ===");
Console.WriteLine($"=== Descrição do problema: {descricao}  ===");