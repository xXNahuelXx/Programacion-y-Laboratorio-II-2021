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
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.Text = string.Empty;
            lblResultado.Text = string.Empty;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            this.btnConvertirABinario.Enabled = true;
            lblResultado.Text = resultado.ToString();
           
        }

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion=MessageBox.Show("¿Seguro desea cerrar?", "¡CUIDADO!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(opcion==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {  
            lblResultado.Text= new Numero().DecimalBinario(lblResultado.Text);
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = new Numero().BinarioDecimal(lblResultado.Text);
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = true;
        }
    }
}


