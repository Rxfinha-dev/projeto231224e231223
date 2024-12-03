using projeto231224e231223.Models;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            if (cboProdutos.SelectedValue != null &&
                !string.IsNullOrEmpty(txtQuantidade.Text) &&
                !string.IsNullOrEmpty(txtPreco.Text))
            {
                double quantidade = double.TryParse(txtQuantidade.Text, out var qtd) ? qtd : 0;
                double estoque = double.TryParse(txtEstoque.Text, out var est) ? est : 0;

                if (quantidade > estoque)
                {
                    MessageBox.Show("Estoque insuficiente", "Vendas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantidade.SelectAll();
                    return;
                }

                double preco = double.TryParse(txtPreco.Text, out var prc) ? prc : 0;

                dgvProdutos.Rows.Add(cboProdutos.SelectedValue, cboProdutos.Text, quantidade, preco);

                total += quantidade * preco;
                lblTotal.Text = total.ToString("C");
                LimpaProduto();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos do produto antes de inserir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (cboCliente.SelectedItem != null)
            {
                DataRowView reg = (DataRowView)cboCliente.SelectedItem;
                txtCidade.Text = reg["cidade"]?.ToString();
                txtUf.Text = reg["uf"]?.ToString();
                txtRenda.Text = reg["renda"]?.ToString();
                mskCPF.Text = reg["cpf"]?.ToString();
                mskNascimento.Text = reg["dataNasc"]?.ToString();
                picClientes.ImageLocation = reg["foto"]?.ToString();
                chkVenda.Checked = Convert.ToBoolean(reg["venda"] ?? false);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)
            {
                if (chkVenda.Checked)
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
            if (cboProdutos.SelectedItem != null)
            {
                DataRowView reg = (DataRowView)cboProdutos.SelectedItem;
                txtEstoque.Text = reg["estoque"]?.ToString();
                txtPreco.Text = reg["valorVenda"]?.ToString();
                txtMarca.Text = reg["marca"]?.ToString();
                txtCategoria.Text = reg["categoria"]?.ToString();
                picProduto.ImageLocation = reg["foto"]?.ToString();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null && dgvProdutos.CurrentRow.Index >= 0)
            {
                if (dgvProdutos.CurrentRow.Cells.Count > 3)
                {
                    double quantidade = double.TryParse(dgvProdutos.CurrentRow.Cells[2].Value?.ToString() ?? "0", out var qtd) ? qtd : 0;
                    double preco = double.TryParse(dgvProdutos.CurrentRow.Cells[3].Value?.ToString() ?? "0", out var prc) ? prc : 0;

                    total -= quantidade * preco;
                    lblTotal.Text = total.ToString("C");

                    dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada para remoção.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedValue == null)
            {
                MessageBox.Show("Nenhum cliente selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            vc = new VendaCab()
            {
                idCliente = (int)cboCliente.SelectedValue,
                Data = DateTime.Now,
                Total = total
            };

            int idVenda = vc.Incluir();

            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {
                if (!linha.IsNewRow && linha.Cells.Count > 3)
                {
                    vd = new VendaDet()
                    {
                        idVendaCab = idVenda,
                        idProduto = Convert.ToInt32(linha.Cells[0].Value ?? 0),
                        qtde = Convert.ToDouble(linha.Cells[2].Value ?? 0),
                        valorUnitario = Convert.ToDouble(linha.Cells[3].Value ?? 0)
                    };
                    vd.Incluir();

                    p = new Produto()
                    {
                        id = Convert.ToInt32(linha.Cells[0].Value ?? 0)
                    };
                    p.atualizaEstoque(Convert.ToDouble(linha.Cells[2].Value ?? 0));
                }
            }

            frmCaixa form =
                new frmCaixa(idVenda,               
                total,
                cboCliente.Text, 
                (int)cboCliente.SelectedValue);
            form.ShowDialog();
            btnCancelar.PerformClick();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
