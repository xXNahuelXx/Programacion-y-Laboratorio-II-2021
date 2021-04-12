using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoLaboII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Asi está la cosa país";
            String nombre;
            Int32 edad;

            Console.Write("Hola"); //Imprime por consola.
            Console.WriteLine(" Mundo!"); //Hace exactamente lo mismo pero al finalizar provoca un salto de linea.


            Console.Write("Ingrese su nombre: ");
            nombre=Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = Int32.Parse(Console.ReadLine());
           
            //Console.WriteLine("Su nombre es: "+nombre); //Se puede pero no es correcto.
            Console.WriteLine("Su nombre es: {0}\nY su edad es de: {1} años", nombre,edad); //Manera correcta de mostrar un dato por consola. 
            /*Console.WriteLine({0,10} {1,-10} {2},10,15,23) //Lo que hacemos dentro de lo que esta en la llave es:
              * El primer numero corresponde al indice de la variable que vamos a mostrar, y el segundo numero corresponde al espacio.
              * que se dará entre una variable y otra.*/
            Console.WriteLine("{0:.0} - {1:#.00} - {2:0.000} - {3}", 10.47374, 0.4637384, 0.3757373, 96.473747573);
            MiClase.MetodoUno();
            Console.ReadKey(true); //Como el getch o getche de C. Si usamos el booleano nos muestra por consola que tecla presiono el usuario.
        }
    }
}
