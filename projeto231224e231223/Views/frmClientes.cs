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
    public partial class frmClientes : Form
    {
        Cidade ci;
        Cliente cl;
        public frmClientes()
        {
            InitializeComponent();
        }   

     
        void limpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUf.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataDeNascimento.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            txtPesquisar.Clear();
            chkVenda.Checked = false;
        }
        void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };

            dgvCidades.DataSource = c.Consultar();
        }


        private void frmClientes_Load(object sender, EventArgs e)
        {
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            dgvClientes.Columns["idCidade"].Visible = false;
            dgvClientes.Columns["foto"].Visible=false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;

            c = new Cidade()
            {
                nome = txtNome.Text,
                uf = txtUf.Text
            };
            c.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                txtId.Text = dgvCidades.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUf.Text = dgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty) return;

            c = new Cidade()
            {
                id = int.Parse(txtId.Text),
                nome = txtNome.Text,
                uf = txtUf.Text
            };
            c.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidade()
                {
                    id = int.Parse(txtId.Text)
                };
                c.Excluir();
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

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1) 
            { 
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUf.Text = reg["uf"].ToString();
            }
        }
    }
}
