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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
          //  lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumUno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            Numero numeroUno = new Numero(txtNumUno.Text);
            Numero numeroDos = new Numero(txtNumDos.Text);
            
            resultado = Calculadora.Operar(numeroUno, numeroDos, cmbOperador.Text);
            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumUno.Clear();
            this.txtNumDos.Clear();
            lblResultado.Text = "";
            cmbOperador.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);

        }
    }
}
