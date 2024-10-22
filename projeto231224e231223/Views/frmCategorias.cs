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
    public partial class frmCategorias : Form
    {
        Categorias cat;
        public frmCategorias()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            txtPesquisar.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            cat = new Categorias()
            {
                categoria = pesquisa
            };

            dgvCategorias.DataSource = cat.Consultar();
        }
        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisar.Text);
        }   

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir a Categoria?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cat = new Categorias()
                {
                    id = int.Parse(txtId.Text)
                };
                cat.Excluir();
                limpaControles();
                carregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty) return;

            cat = new Categorias()
            {
                id = int.Parse(txtId.Text),
                categoria = txtNome.Text,

            };
            cat.Alterar();

            limpaControles();
            carregarGrid("");

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;

            cat = new Categorias()
            {
                categoria = txtNome.Text,

            };
            cat.Incluir();

            limpaControles();
            carregarGrid("");

        }


        private void frmCategorias_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.RowCount > 0)
            {
                txtId.Text = dgvCategorias.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCategorias.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }
    }
}
