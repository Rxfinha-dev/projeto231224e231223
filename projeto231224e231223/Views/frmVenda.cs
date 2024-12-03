using projeto231224e231223.Models;
using System;
using System.Data;
using MySql.Data.MySqlClient;


using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace projeto231224e231223.Views
{
    public partial class frmVenda : Form
    {
        double total;
        Cliente c;
        Produto p;
        VendaCab vc;
        VendaDet vd;

        public frmVenda()
        {
            InitializeComponent();
        }

        void LimpaProduto()
        {
            cboProdutos.SelectedIndex = -1;
            txtEstoque.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtMarca.Clear();
            txtCategoria.Clear();
            picProduto.ImageLocation = "";
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvProdutos.RowCount = 1;
            cboCliente.SelectedIndex = -1;
            txtCidade.Clear();
            txtUf.Clear();
            txtRenda.Clear();
            mskCPF.Clear();
            mskNascimento.Clear();
            chkVenda.Checked = false;
            picClientes.ImageLocation = "";
            total = 0;
            lblTotal.Text = total.ToString("C");
            gboClientes.Enabled = true;
            gboProdutos.Enabled = false;
            LimpaProduto();           
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double quantidade = double.Parse(txtQuantidade.Text);
            double estoque = double.Parse(txtEstoque.Text);

            if(quantidade>estoque)
            {
                MessageBox.Show("Estoque insuficiente", "Vendas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.SelectAll();
                return;
            }

            dgvProdutos.Rows.Add(cboProdutos.SelectedValue, cboProdutos.Text,
                txtQuantidade.Text, txtPreco.Text);

            double preco = double.Parse(txtPreco.Text);

            total += quantidade * preco;
            lblTotal.Text = total.ToString("C");
            LimpaProduto();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            c = new Cliente();
            cboCliente.DataSource = c.Consultar();
            cboCliente.DisplayMember = "nome";
            cboCliente.ValueMember = "id";

            p = new Produto();
            cboProdutos.DataSource = p.Consultar();
            cboProdutos.DisplayMember = "descricao";
            cboProdutos.ValueMember = "id";

            btnCancelar.PerformClick();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCliente.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCliente.SelectedItem;
                txtCidade.Text = reg["cidade"].ToString();
                txtUf.Text = reg["uf"].ToString();
                txtRenda.Text = reg["renda"].ToString();
                mskCPF.Text = reg["cpf"].ToString();
                mskNascimento.Text = reg["dataNasc"].ToString();
                picClientes.ImageLocation = reg["foto"].ToString();
                chkVenda.Checked = (bool)reg["venda"];
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)
            {
                if(chkVenda.Checked)
                {
                    MessageBox.Show("Cliente bloqueado para venda", "Vendas",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCancelar.PerformClick();
                    return;
                }
                gboClientes.Enabled = false;
                gboProdutos.Enabled = true;
            }
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProdutos.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboProdutos.SelectedItem;
                txtEstoque.Text = reg["estoque"].ToString();
                txtPreco.Text = reg["valorVenda"].ToString();
                txtMarca.Text = reg["marca"].ToString();
                txtCategoria.Text = reg["categoria"].ToString();
                picProduto.ImageLocation = reg["foto"].ToString();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.RowCount > 0)
            {
                double quantidade = double.Parse(dgvProdutos.CurrentRow.Cells[2].Value.ToString());
                double preco = double.Parse(dgvProdutos.CurrentRow.Cells[3].Value.ToString());

                total -= quantidade * preco;
                lblTotal.Text = total.ToString();

                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            vc = new VendaCab()
            {
                idCliente = (int)cboCliente.SelectedValue,
                Data = DateTime.Now,
                Total = total
            };

            int idVenda = vc.Incluir();

            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {
                vd = new VendaDet()
                {
                    idVendaCab = idVenda,
                    idProduto = Convert.ToInt32(linha.Cells[0].Value),
                    qtde = Convert.ToDouble(linha.Cells[2].Value),
                    valorUnitario = Convert.ToDouble(linha.Cells[3].Value)
                };
                vd.Incluir();

                p = new Produto()
                {
                    id = (int)linha.Cells[0].Value
                };
                p.atualizaEstoque(Convert.ToDouble(linha.Cells[2].Value));
            }
            btnCancelar.PerformClick();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
