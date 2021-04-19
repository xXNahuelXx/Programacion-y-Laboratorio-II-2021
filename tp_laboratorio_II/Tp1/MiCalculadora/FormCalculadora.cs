using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Constructor por defecto de FormCalculadora
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Invoca al metodo Limpiar para borrar todos los datos de los textBox, Labels y ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Asigna un string vacio a cada textBox, ComboBox y Label. Ademas deshabilita las operaciones de conversion y habilita el boton Operar.
        /// </summary>
        private void Limpiar()
        {
            this.btnOperar.Enabled = true;
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.Text = string.Empty;
            lblResultado.Text = string.Empty;
        }

        /// <summary>
        /// Cuando se da click al boton se invoca al metodo operar y el resultado que devuelve los transforma a string para mostrarlo en el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            this.btnConvertirABinario.Enabled = true;
            lblResultado.Text = resultado.ToString();
           
        }

        /// <summary>
        /// Invoca al metodo Operar que realiza una operacion matematica entre dos numeros tambien pasandole el operador para que sepa que operacion hacer.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1,string numero2,string operador)
        {
            double retorno = 0;
            if(numero1!=null &&numero2!=null && operador!=null)
            {
                Numero numeroUno = new Numero(numero1);
                Numero numeroDos = new Numero(numero2);
                retorno= Calculadora.Operar(numeroUno, numeroDos, operador);
            }
            return retorno;           
        }

        /// <summary>
        /// Cierra el formulario preguntando si está seguro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion=MessageBox.Show("¿Seguro desea cerrar?", "¡CUIDADO!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(opcion==DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Convierte el resultado decimal a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {  
            lblResultado.Text= new Numero().DecimalBinario(lblResultado.Text);
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = true;
            this.btnOperar.Enabled = false;
        }

        /// <summary>
        /// Convierte el resultado a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = new Numero().BinarioDecimal(lblResultado.Text);
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = true;
            this.btnOperar.Enabled = false;
        }
    }
}


