using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Propiedades
        /// <summary>
        /// Setea el numero que valida invocando a la funcion ValidarNumero.
        /// </summary>
        public string SetNumero 
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que setea un valor recibido.
        /// </summary>
        /// <param name="numero">Numero a asignar</param>
        public Numero(double numero)
        {
            SetNumero = numero.ToString();
        }

        /// <summary>
        /// Constructor por defecto que asigna el numero 0.
        /// </summary>
        public Numero():this(0)
        {
        }

        /// <summary>
        /// Constructor que setea el valor recibido en string
        /// </summary>
        /// <param name="numeroString">Numero a asignar</param>
        public Numero(string numeroString)
        {
            SetNumero = numeroString;
        }
        #endregion

        #region Validaciones
        /// <summary>
        /// Valida que lo recibido sea numerico
        /// </summary>
        /// <param name="strNumero">cadena a validar</param>
        /// <returns>Retorna el numero validado, en caso de que sea invalido retorna 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno=0;
            string validado=null;
            int i = 1;

            foreach(char caracterNumericoaValidar in strNumero)
            {
                if(caracterNumericoaValidar > '0' || caracterNumericoaValidar < '9')
                {
                    validado = validado + caracterNumericoaValidar.ToString();
                    if(i==strNumero.Length)
                    {
                        double.TryParse(validado.Replace(".", ","), out retorno);
                    }
                }
                else
                {
                    retorno = 0;
                    break;
                }
                i++;
            }
            return retorno;
        }

        /// <summary>
        /// Valida que la cadena recibida solo contenga 0 y 1 para saber si es binario
        /// </summary>
        /// <param name="binario">cadena a validar</param>
        /// <returns>Retorna true si es binario, false si no lo es</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = false;
            foreach (char binarioavalidar in binario)
            {
                if (binarioavalidar >= '0' || binarioavalidar <= '1')
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Realiza la conversion de un numero binario a decimal
        /// </summary>
        /// <param name="binario">numero a convertir</param>
        /// <returns>Retorna el numero convertido y en caso de error retorna Valor Invalido</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = null;
            double acum=0;
            double expo = binario.Length-1;

            if(EsBinario(binario))
            {
                foreach (Char auxNum in binario)
                {
                    if (auxNum == '1')
                    {
                        acum += Math.Pow(2, expo);
                    }
                    expo--;
                }
                retorno = acum.ToString();
            }
            else
            {
                retorno = "Valor Invalido";
            }
            
            return retorno;
        }

        /// <summary>
        /// Realiza la conversion de un numero decimal a binario
        /// </summary>
        /// <param name="numeroDecimal">numero a convertir</param>
        /// <returns>Retorna el numero convertido y en caso de error retorna Valor Invalido</returns>
        public string DecimalBinario(double numeroDecimal)
        {
            String cadena = null;
            int numero = (int)numeroDecimal;
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = numero / 2;
                }
            }
            else
            {
                cadena = "Valor Invalido";
            }
            return cadena;
        }

        /// <summary>
        /// Realiza la conversion de un numero decimal a binario
        /// </summary>
        /// <param name="numeroString">numero a convertir</param>
        /// <returns>Retorna el numero convertido y en caso de error retorna Valor Invalido</returns>
        public string DecimalBinario(string numeroString)
        {
            String cadena = null;
            double numero;
            if(double.TryParse(numeroString,out numero))
            {
                cadena = DecimalBinario(numero);
            }
            else
            {
                cadena = "Valor Invalido";
            }
            return cadena;
        }
        #endregion

        #region Sobrecarga de Operadores
        /// <summary>
        /// Sobrecarga del operador + para que pueda sumar 2 objetos de tipo Numero
        /// </summary>
        /// <param name="n1">Objeto de tipo Numero</param>
        /// <param name="n2">Objeto de tipo Numero</param>
        /// <returns>Retorna la suma de los numeros</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador - para poder restar 2 objetos de tipo Numero
        /// </summary>
        /// <param name="n1">Objeto de tipo Numero</param>
        /// <param name="n2">Objeto de tipo Numero</param>
        /// <returns>Retorna la resta de los numeros</returns>
        public static double operator -(Numero n1,Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador * para que multiplique 2 objetos de tipo numero.
        /// </summary>
        /// <param name="n1">Objeto de tipo Numero</param>
        /// <param name="n2">Objeto de tipo Numero</param>
        /// <returns>Retorna la multiplicacion de los numeros</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador / para dividir 2 objetos de tipo Numero
        /// </summary>
        /// <param name="n1">Objeto de tipo Numero</param>
        /// <param name="n2">Objeto de tipo Numero</param>
        /// <returns>Retorna la division de los numeros, en caso de que el segundo numero sea 0, retorna el valor minimo de un Double</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno;
            if(n2.numero==0)
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno= n1.numero / n2.numero;
            }
            return retorno;
        }
        #endregion 
    }
}
