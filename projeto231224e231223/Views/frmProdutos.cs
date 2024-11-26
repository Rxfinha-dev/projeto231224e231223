using projeto231224e231223.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto231224e231223.Views
{
    public partial class frmProdutos : Form
    {
        Produto p;
        Categorias c;
        Marca m;

        public frmProdutos()
        {
            InitializeComponent();
        }

        void carregarGrid(string consulta)
        {
            p = new Produto()
            {
                descricao = consulta,
            };
            dgvProdutos.DataSource = p.Consultar();
        }
        void limpaControles()
        {
            txtId.Clear();
            txtDescricao.Clear();
            txtEstoque.Clear();
            txtPesquisar.Clear();
            txtValor.Clear();
            cboCategoria.SelectedIndex = -1;
            cboMarcas.SelectedIndex = -1;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "") return;

            p = new Produto()
            {
                descricao = txtDescricao.Text,
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarcas.SelectedValue,
                estoque = decimal.Parse(txtEstoque.Text),
                valorVenda = decimal.Parse(txtValor.Text),
            };
            p.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            p = new Produto()
            {
                id = int.Parse(txtId.Text),
                descricao = txtDescricao.Text,
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarcas.SelectedValue,
                estoque = decimal.Parse(txtEstoque.Text),
                valorVenda = decimal.Parse(txtValor.Text),
            };
            p.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir o Produto?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                p = new Produto()
                {
                    id = int.Parse(txtId.Text),
                };
                p.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            m = new Marca();
            cboMarcas.DataSource = m.Consultar();
            cboMarcas.DisplayMember = "marca";
            cboMarcas.ValueMember = "id";

            c = new Categorias();
            cboCategoria.DataSource = c.Consultar();
            cboCategoria.DisplayMember = "categoria";
            cboCategoria.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            dgvProdutos.Columns["idMarca"].Visible = false;
            dgvProdutos.Columns["idCategoria"].Visible = false;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                txtId.Text = dgvProdutos.CurrentRow.Cells["id"].Value.ToString();
                txtDescricao.Text = dgvProdutos.CurrentRow.Cells["descricao"].Value.ToString();
                cboCategoria.Text = dgvProdutos.CurrentRow.Cells["categoria"].Value.ToString();
                cboMarcas.Text = dgvProdutos.CurrentRow.Cells["marca"].Value.ToString();
                txtEstoque.Text = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
                txtValor.Text = dgvProdutos.CurrentRow.Cells["valorVenda"].Value.ToString();
            }
        }
    }
}
