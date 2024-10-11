

try
{
    string[] leitor = File.ReadAllLines("Arquivos/arquivos.txt");
    //Faz a leitura de uma linha no arquivo de text

    foreach (string leitorLine in leitor) 
    {
        Console.WriteLine(leitorLine); 
    }//Percorrendo as linhas do arquivo

} catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma excecao generica. {ex.Message}");
}