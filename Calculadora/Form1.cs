using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calc;

namespace Calculadora
{


    public partial class frmCalculadora : Form
    {
        calc.Calculadora c = new calc.Calculadora();

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btNumber_Click(object sender, EventArgs e)
        {

            btSuma.Enabled = true;
            btResta.Enabled = true;
            btMulti.Enabled = true;
            btDivision.Enabled = true;
            btSigno.Enabled = true;
            btPunto.Enabled = true;
            btIgual.Enabled = true;

            Button b = (Button)sender;
            txtNumero.Text = txtNumero.Text + b.Text;
        }

        private void btOperador_Click(object sender, EventArgs e)
        {
            c.insert_num(float.Parse(txtNumero.Text));
            txtNumero.Text = "";
            Button b = (Button)sender;
            c.insert_op(Convert.ToChar(b.Text));
            lbOperacion.Text = c.oper_actual();

            btSuma.Enabled = false;
            btResta.Enabled = false;
            btMulti.Enabled = false;
            btDivision.Enabled = false;
            btSigno.Enabled = false;
            btPunto.Enabled = false;
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + ",";

            btSuma.Enabled = false;
            btResta.Enabled = false;
            btMulti.Enabled = false;
            btDivision.Enabled = false;
            btSigno.Enabled = false;
            btPunto.Enabled = false;
            btIgual.Enabled = false;
        }

        private void btSigno_Click(object sender, EventArgs e)
        {
            float cambioSign = float.Parse(txtNumero.Text) * -1;
            txtNumero.Text = cambioSign.ToString();

        }

        private void btBorrarAC_Click(object sender, EventArgs e)
        {
            lbOperacion.Text = c.operar().ToString();
            txtNumero.Text = "";
            lbOperacion.Text = "";
            lbResultado.Text = "";

            btSuma.Enabled = false;
            btResta.Enabled = false;
            btMulti.Enabled = false;
            btDivision.Enabled = false;
            btSigno.Enabled = false;
            btPunto.Enabled = false;
            btIgual.Enabled = false;
        }

        private void btBorrarC_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";

            btSuma.Enabled = false;
            btResta.Enabled = false;
            btMulti.Enabled = false;
            btDivision.Enabled = false;
            btSigno.Enabled = false;
            btPunto.Enabled = false;
            btIgual.Enabled = false;
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            c.insert_num(float.Parse(txtNumero.Text));
            lbResultado.Text = c.operar().ToString();
            txtNumero.Text = "";
            lbOperacion.Text = "";

            btSuma.Enabled = false;
            btResta.Enabled = false;
            btMulti.Enabled = false;
            btDivision.Enabled = false;
            btSigno.Enabled = false;
            btPunto.Enabled = false;
            btIgual.Enabled = false;
        }
    }
}