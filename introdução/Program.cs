//writeline é para quebrar uma linha no texto

Console.WriteLine("Qual é o seu nome: ");
string nome = Console.ReadLine()!; //receber dados

Console.WriteLine($" Bem vindo {nome}!!");
Console.WriteLine("Qual sua idade:");

int idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Seu nome é {nome} e sua idade é {idade} anos");

string terminarTela = Console.ReadLine()!;

//ola mundo