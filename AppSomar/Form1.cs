using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSomar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();

            lblResultado.Text = "0";

            txtN1.Focus();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text); 
            int n2 = int.Parse(txtN2.Text); 

            int resultado = n1 + n2;

            lblResultado.Text = resultado.ToString();   
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void lblResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
