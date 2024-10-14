
using ExampleModels.Models;
using System.Globalization;

//new ExampleExceptions().Metodo1();


/*

try
    {
        string[] leitor = File.ReadAllLines("Arquivos/arquivo.txt");
        //Faz a leitura de uma linha no arquivo de text

        foreach (string leitorLine in leitor) 
        {
            Console.WriteLine(leitorLine); 
        }//Percorrendo as linhas do arquivo

    }
    catch(DirectoryNotFoundException ex) //Execoes Especificas
        {
            Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Caminho da pasta nao encontrado {ex.Message}");
        }
    catch(FileNotFoundException ex)
        {
            Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Arquivo nao encontrado {ex.Message}");
        }
    catch(Exception ex) //Excecao Generica
        {
            Console.WriteLine($"Ocorreu uma excecao generica. {ex.Message}");
        }
    finally // Eh executado independe de erro ou sucesso (Sempre sera executado)(Feedbacks - Fim de processamento)
        {
            Console.WriteLine("Fim da leitura do arquivo!");
        }













//Filas - Queue

Queue<int> fila = new Queue<int>();

fila.Enqueue(2); //adiciona no final
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(var index in fila)
{
    Console.WriteLine(index);
}














//Pilha


Stack<int> stack = new Stack<int>();
stack.Push(2);
stack.Push(4);
stack.Push(6);

foreach(var index in stack)
{
    Console.WriteLine(index);
}


















//Dictionary - (chave valor)

Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("SP", "Sao Paulo");
dictionary.Add("RJ", "Rio de Janeiro");
dictionary.Add("PR", "Parana");

dictionary["SP"] = "Valor alterado"; //Manipulando valor

foreach(var index in dictionary)
{
    Console.WriteLine($"chave: {index.Key} | valor: {index.Value}");
}

string chave = "RJ";

if(dictionary.ContainsKey(chave)) //Verificando valores 
{
    Console.WriteLine($"Valor encontrado: {dictionary["RJ"]}");
}
else
{
    Console.WriteLine("Valor nao encontrado!!");
}

*/
















//Tuplas 


(int, string, string) tuple = (1, "alexandre", "nunes");
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);
Console.WriteLine(tuple.Item3);


LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, qtdLinhas) = arquivo.LerArquivo("Arquivos/arquivo.txt");

if(sucesso)
{
    Console.WriteLine($"Qtd de linhas: {qtdLinhas}");
    foreach(var linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else{
    Console.WriteLine("Nao foi possivel ler arquivo");
}






















//Operador Ternario



