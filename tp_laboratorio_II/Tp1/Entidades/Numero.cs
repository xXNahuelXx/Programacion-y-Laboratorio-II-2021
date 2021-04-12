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
        public string SetNumero 
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Constructores
        public Numero(double numero)
        {
            SetNumero = numero.ToString();
        }

        public Numero():this(0)
        {
        }
        
        public Numero(string numeroString)
        {
            SetNumero = numeroString;
        }
        #endregion

        #region Validaciones
        private double ValidarNumero(string strNumero)
        {
            double retorno=0;
            string validado=null;
            int i = 1;

            foreach(char caracterNumericoaValidar in strNumero)
            {
                if(caracterNumericoaValidar >= '0' || caracterNumericoaValidar <= '9')
                {
                    validado = validado + caracterNumericoaValidar.ToString();
                    if(i==strNumero.Length)
                    {
                        retorno = double.Parse(validado);
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
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1,Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

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
