using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeMoedas
{
    public partial class Form1 : Form
    {
        double valor = 0;
        public Form1()
        {
            InitializeComponent();
            cmbValorReal.Items.Add("Dólar");//Cotação das moedas: 12/08/2020
            cmbValorReal.Items.Add("Euro");//Dólar: 5,45 Reais; Euro: 6,41 Reais
            cmbValorDolar.Items.Add("Real");
            cmbValorDolar.Items.Add("Euro");
            cmbValorEuro.Items.Add("Real");
            cmbValorEuro.Items.Add("Dólar");       
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtConverte_TextChanged(object sender, EventArgs e)
        {
        }
        private void cmbValorReal__SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtValorReal.Text);                            
            if (cmbValorReal.Text == "Dólar")
            {
                valor = valor / 5.45;
                txtConverteReal.Text = valor.ToString("f");
            }                 
            if (cmbValorReal.Text == "Euro")
            { 
                valor = valor / 6.41;
                txtConverteReal.Text = valor.ToString("f");
            }            
        }
        private void cmbValorDolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtValorDolar.Text);
            if (cmbValorDolar.Text == "Real")
            {
                valor = valor * 5.45;
                txtConverteDolar.Text = valor.ToString("f");
            }
            if (cmbValorDolar.Text == "Euro")
            {
                valor = (valor * 5.45) / 6.41;
                txtConverteDolar.Text = valor.ToString("f");
            }
        }
        private void txtValorDolar_TextChanged(object sender, EventArgs e)
        {
        }
        private void cmbValorEuro_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValorEuro.Text);
            if (cmbValorEuro.Text == "Real")
            {
                valor = valor * 6.41;
                txtConverteEuro.Text = valor.ToString("f");
            }
            if (cmbValorEuro.Text == "Dólar")
            {
                valor = (valor * 6.41) / 5.45;
                txtConverteEuro.Text = valor.ToString("f");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
