using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion matematica de dos numeros.
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operador aritmetico</param>
        /// <returns>Retorna el resultado de la operacion, en caso de que el operador sea invalido, retorna la suma de los numeros</returns>
        public static double Operar(Numero num1,Numero num2,string operador)
        {
            double resultado;
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

        /// <summary>
        /// Valida que el operador sea valido.
        /// </summary>
        /// <param name="operador">operador a validar</param>
        /// <returns>Retorna el operador, en caso de que el operador sea invalido retorna +</returns>
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
