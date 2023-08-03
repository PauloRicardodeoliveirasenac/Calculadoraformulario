using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ModelCalculadora
    {
        private double operacao;

        public ModelCalculadora()
        {
            consultarOpercao = 0;

        }//fim do metodo constructor

        public double consultarOpercao
        {
            get { return operacao; }
            set { this.operacao = value; }
        }//fim do metodo

        public double somar(double num)
        {
            return consultarOpercao += num;

        }//fim do metodo somar

        public double subtrair(double num)
        {
            if (consultarOpercao <= 0)
            {
                return consultarOpercao = num;
            }
            return consultarOpercao -= num;
        }//fim do subtrair

        public double multiplicacao(double num)
        {
            return consultarOpercao *= num;

        }//fim do metodo subtarir

        public double divisao(double num)
        {
            return consultarOpercao /= num;

        }//fim do metodo divisão

        public double raiz(double num)
        {
            if (consultarOpercao <= 0)
            {
                return consultarOpercao = num;

            }
            return  Math.Sqrt(consultarOpercao,num);

        }//fim do metodo divisão

        public double potencia(double num)
        {
            if (consultarOpercao <= 0)
            {
                return consultarOpercao = num;
            }
             return  Math.Pow(consultarOpercao, num);
        }//fim do metodo potencia 

        public double clear(double v)
        {
            return consultarOpercao = 0;
        }//CLEAR

    }//fim da classe
}//fim do projeto