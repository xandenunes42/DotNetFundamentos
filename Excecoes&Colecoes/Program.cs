// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] leitor = File.ReadAllLines("Arquivos/arquivo.txt");

foreach (string leitorLine in leitor)
{
    Console.WriteLine(leitorLine);
}
