using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excecoes_Colecoes.Models
{
    public class ExemplosExcecoes
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch(Exception)
            {
                Console.WriteLine("Excecao Tratada!");
            }
            
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            throw new Exception("Ocorreu uma excecao");
        }
    }
}