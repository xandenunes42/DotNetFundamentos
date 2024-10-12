
using ExampleModels.Models;
using System.Globalization;

//new ExampleExceptions().Metodo1();

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

