using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        //Atributos
        private int x;
        private int y;

        //Metodos 
        public int GetX()
        {

        }
        public int GetY()
        {

        }

        //Constructor
        public Punto(int x,int y)
        {

        }

    }

    public class Rectangulo
    {
        //Atributos
        private float area;
        private float pertimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        //Getters
        public float GetArea()
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.pertimetro;
        }

        //Metodos
        public float Area()
        {

        }

        public float Perimetro()
        {

        }

        //Constructor
        Rectangulo(Punto vertice1,Punto vertice3)
        {

        }
    }
}
