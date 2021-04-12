using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoLaboII
{
    class MiClase
    {
        //Miembros de la clase: atributos y métodos.

        //atributos.
        //propiedades. 
        //constructor. 
        //métodos.
        //sobrecargas.

        //Definir atributo
        private static string cadena; //definimos un atributo dentro de nuestra clase.
        public static Int32 entero;

        //Definir metodo
        public static void MetodoUno()
        {
            //Implementacion.
            String algo;
            algo = "hola";
            Console.Write("{0}", algo);
        }

        public static Int32 MetodoDos(string paramUno)
        {
            //Implementacion. 
            Int32 valor = Int32.Parse(paramUno);
            return valor;
        }
    }
}
