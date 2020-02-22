using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_time
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instancia de um objeto*/
            Tme objTme = new Tme ();
            objTme.nome = "Santos";
            objTme.cidade = "Santos SP";
            objTme.estado = "SP";
            objTme.pais = "Brasil";
            objTme.numeroDeTitulos = 89;
            objTme.valorDoTimeEmDinheiro = 9000000;
            objTme.numeroDeJogadores = 45 ;
            objTme.comprarJogador(1);
         
          

           

            
            
            System.Console.WriteLine(@"Entre com a cidade do time "+ objTme.nome);
            objTme.cidade = System.Console.ReadLine();


            System.Console.WriteLine(@"Entre com o Pais da cidade " + objTme.cidade);
            objTme.pais = System.Console.ReadLine();

            System.Console.WriteLine(@"Entre com o estado do Pais " + objTme.pais);
            objTme.estado = System.Console.ReadLine();

            System.Console.WriteLine(@"Entre com o numero de titulos do time " + objTme.nome);
            objTme.numeroDeTitulos = Convert.ToInt32( System.Console.ReadLine());

            System.Console.WriteLine(@"Entre com o numero de jogadores do time " + objTme.nome);
            objTme.numeroDeJogadores = Convert.ToInt32( System.Console.ReadLine());

            System.Console.WriteLine(@"Entre com o valor do time " + objTme.nome);
            objTme.valorDoTimeEmDinheiro = Convert.ToInt32(System.Console.ReadLine());

            string statusDoObjeto;
            statusDoObjeto = objTme.statusClass();
            System.Console.WriteLine(statusDoObjeto);
           
            Console.ReadKey();
            //int numJogador;
            //System.Console.Readline(numJogador);
            //objTme.comprarJogador(numJogador);
        }
    }
}
