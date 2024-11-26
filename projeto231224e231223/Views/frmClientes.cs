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
        
        void LimpaControles()
        {
            txtId.Clear();
            txtNome.Clear();
            cboCidades.SelectedItem = -1;
            mskCPF.Clear();
            dtpDataDeNascimento.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            txtPesquisar.Clear();
            txtRenda.Clear();
            txtUf.Clear();
            chkVenda.Checked = false;
        }
        
        void carregarGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };
            dgvClientes.DataSource = cl.consultar();
        }
   

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            LimpaControles();
            carregarGrid("");
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1) 
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUf.Text = reg["uf"].ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:/fotos/clientes/";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            picFoto.ImageLocation = openFileDialog1.FileName;
        }
    }
}
