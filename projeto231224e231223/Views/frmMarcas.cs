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
    public partial class frmMarcas : Form
    {
        Marca m;
        public frmMarcas()
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
            m = new Marca()
            {
                marca = pesquisa
            };

            dgvMarcas.DataSource = m.Consultar();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;

            m = new Marca()
            {
                marca = txtNome.Text,
               
            };
            m.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarcas.RowCount > 0)
            {
                txtId.Text = dgvMarcas.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvMarcas.CurrentRow.Cells["marca"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty) return;

            m = new Marca()
            {
                id = int.Parse(txtId.Text),
                marca = txtNome.Text,
                
            };
            m.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir a Marca?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    id = int.Parse(txtId.Text)
                };
                m.Excluir();
                limpaControles();
                carregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisar.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
