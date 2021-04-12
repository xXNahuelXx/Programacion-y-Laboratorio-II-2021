using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerBoli
{
    public class Boligrafo
    {
        //Atributos
        const short cantidadTintaMaxima=100;
        private ConsoleColor color;
        private short tinta;

        //Constructor
        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if(this.tinta<0)
            {
                this.tinta = 0;
            }
            else if(this.tinta>cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto,out string dibujo)
        {
            dibujo = "";
            Boolean opcion=true;
            short tintaDisponible = this.tinta;
            SetTinta((short)-gasto);
            for (int i = 0; i < gasto; i++)
            {
                if (i>=tintaDisponible)
                {
                    opcion=false;
                    break;
                }
                dibujo += "*";
            }
            return opcion;
        }
    }
}
