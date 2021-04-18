using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero num1,Numero num2,string operador)
        {
            double resultado;
            //char operadoraValidar = Char.Parse(operador);
            char operadoraValidar;
            char.TryParse(operador, out operadoraValidar);

            switch (ValidarOperador(operadoraValidar))
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }

        private static string ValidarOperador(char operador)
        {
            char retorno = '+';
            switch(operador)
            {
                case '+':
                    retorno = '+';
                    break;
                case '-':
                    retorno = '-';
                    break;
                case '*':
                    retorno = '*';
                    break;
                case '/':
                    retorno = '/';
                    break;
            }
            return retorno.ToString();
        }
    }
}
