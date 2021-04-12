using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        //Atributos
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        //Constructor
        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public  void CalcularFinal()
        {
            if (this.nota1 <= 4 || this.nota2 <= 4)
            {
                this.notaFinal = -1;
            }
            else
            {
                Random rand = new Random();
                this.notaFinal = rand.Next(4, 10);
            }
            /*Frena la cantidad de milisegundos que se le pasa por parametro.
            System.Threading.Thread.Sleep(200);*/
        }

        public  void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public  string Mostrar()
        {
            string cadena;
            if(this.notaFinal!=-1)
            {
                cadena= "Legajo: " + this.legajo + "\nNombre: " + this.nombre + "\nApellido: " + this.apellido +
                "\nNota1: " + this.nota1 + "\nNota2: " + nota2 + "\nNota final: " + this.notaFinal;
            }
            else
            {
                cadena = "Legajo: " + this.legajo + "\nNombre: " + this.nombre + "\nApellido: " + this.apellido +
                "\nNota1: " + this.nota1 + "\nNota2: " + nota2 + "\nNota final: " + "Alumno desaprobado";
            }
            return cadena;
        }
    }
}
