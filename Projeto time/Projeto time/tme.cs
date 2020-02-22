using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_time
{
    class Tme
    {
        /*Atributos( caracteristicas da classe)*/
        public string nome;
        public string pais;
        public string estado;
        public string cidade;
        public int numeroDeJogadores = 0;
        public int numeroDeTitulos = 0;
        public double valorDoTimeEmDinheiro = 0;

        /*metodos*/
        public void comprarJogador(int numJongador)
        {
            this.numeroDeJogadores += numJongador;

        }
        public string statusClass()
        {
            string retorno;
            retorno = "Nome::" + this.nome +
                       "\nCidade:" + this.cidade +
                       "\nEstado:" + this.estado +
                       "\nPais:" + this.pais+
                       " \nNumero de Jogadores:" + this.numeroDeJogadores +
                       " \nNumero de Titulos:" + this.numeroDeTitulos +
                       "\nValor do time: R$" + this.valorDoTimeEmDinheiro;

            return retorno;

        }

    }
}
