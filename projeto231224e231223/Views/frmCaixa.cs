using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto231224e231223.Models;

namespace projeto231224e231223.Views
{
    public partial class frmCaixa : Form
    {
        double totalVenda, pago, troco, dinheiro, cartao, cheque, pix, boleto;
        public frmCaixa(int idVendaCab, double total, string nome, int idCliente)
        {
            InitializeComponent();

            txtId.Text = idCliente.ToString();
            txtCliente.Text = nome;
            txtValor.Text = total.ToString("C");
            txtVenda.Text = idVendaCab.ToString();
            totalVenda = total;

            calcularTroco();
        }

        void calcularTroco()
        {
            if (txtDinheiro.Text == "") dinheiro = 0;
            else dinheiro = double.Parse(txtDinheiro.Text);

            if (txtCheque.Text == "") cheque = 0;
            else cheque = double.Parse(txtCheque.Text);



        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {

        }
    }
}
