using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMercado
{
    public partial class Form1 : Form
    {

        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            double valor = double.Parse(txtVlrUnitario.Text);

            ListBox listBox = lstProdutos;

            listBox.Items.Add("Produto: " + produto + " / " + "Quantidade: " + quantidade + " / "+ "Valor Unitário: R$ " + valor);

            total += quantidade * valor;

            lblTotal.Text = total.ToString("C");

            txtProduto.Clear();
            txtQuantidade.Clear();
            txtVlrUnitario.Clear();

            txtProduto.Focus();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQuantidade.Clear();
            txtVlrUnitario.Clear();

            lstProdutos.Items.Clear() ;

            lblTotal.Text = "";

            txtProduto.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();


        }
    }
}
