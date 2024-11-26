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
            chkVenda.Checked = false;
        }


        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUf.Text = reg["uf"].ToString();
            }
        }

        
        void carregarGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };

            dgvClientes.DataSource = cl.Consultar();

        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:/fotos/clientes/";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            picFoto.ImageLocation = openFileDialog1.FileName;
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
            dgvClientes.Columns["foto"].Visible = false;
        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.RowCount > 0)
            {
                txtId.Text = dgvClientes.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvClientes.CurrentRow.Cells["nome"].Value.ToString();
                cboCidades.Text = dgvClientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtUf.Text = dgvClientes.CurrentRow.Cells["uf"].Value.ToString();
                chkVenda.Checked = (bool)dgvClientes.CurrentRow.Cells["venda"].Value;
                mskCPF.Text = dgvClientes.CurrentRow.Cells["cpf"].Value.ToString();
                dtpDataDeNascimento.Text = dgvClientes.CurrentRow.Cells["dataNasc"].Value.ToString();
                txtRenda.Text = dgvClientes.CurrentRow.Cells["renda"].Value.ToString();
            }
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            cl = new Cliente()
            {
                id = int.Parse(txtId.Text),
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataDeNascimento.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                venda = chkVenda.Checked
            };
            cl.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir o cliente?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Cliente()
                {
                    id = int.Parse(txtId.Text),
                };
                cl.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
               carregarGrid(txtPesquisar.Text);
        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == "") return;

            cl = new Cliente()
            {
                nome = txtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataDeNascimento.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                venda = chkVenda != null && chkVenda.Checked
            };
            cl.Incluir();

            limpaControles();
            carregarGrid("");
        }
    }
}
