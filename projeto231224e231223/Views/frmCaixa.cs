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
        private int idVenda;
        private int selectedValue;
        private string v;
        private double total;

        private void txtPix_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(troco<0)
            {
                MessageBox.Show("Valor pago menor que o valor da Venda", "Caixa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
             
            }

            Caixa c = new Caixa()
            {
                idVendaCab = int.Parse(txtVenda.Text),
                dinheiro = dinheiro,
                cartao = cartao,
                cheque = cheque,
                boleto = boleto,
                pix = pix,
            };
            c.Incluir();
            Close();
        }

        private void txtCartao_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void txtCheque_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void txtBoleto_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

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

        public frmCaixa(int idVenda, int selectedValue, string v, string text)
        {
            this.idVenda = idVenda;
            this.selectedValue = selectedValue;
            this.v = v;
            Text = text;
        }

        public frmCaixa(int idVenda, int selectedValue, double total, string text)
        {
            this.idVenda = idVenda;
            this.selectedValue = selectedValue;
            this.total = total;
            Text = text;
        }

        void calcularTroco()
        {
            if (txtDinheiro.Text == "") dinheiro = 0;
            else dinheiro = double.Parse(txtDinheiro.Text);

            if (txtCheque.Text == "") cheque = 0;
            else cheque = double.Parse(txtCheque.Text);

            if (txtCartao.Text == "") cartao = 0;
            else cartao = double.Parse(txtCartao.Text);

            if (txtPix.Text == "") pix = 0;
            else pix = double.Parse(txtPix.Text);

            if (txtBoleto.Text == "") boleto = 0;
            else boleto = double.Parse(txtBoleto.Text);

            pago = dinheiro + cartao + cheque + pix + boleto;

            troco = pago - totalVenda;
            txtTroco.Text = troco.ToString();

            if(troco < 0) txtTroco.ForeColor = Color.Red;
            else txtTroco.ForeColor= Color.Blue;
        }

        

        private void frmCaixa_Load(object sender, EventArgs e)
        {

        }
    }
}
