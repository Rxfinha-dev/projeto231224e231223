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
    public partial class frmConsultaVendas : Form
    {
        ListaDeVendas lv;

        public  frmConsultaVendas()
        {
            InitializeComponent();
        }

        void carregarGrid(string consulta)
        {
            lv = new ListaDeVendas()
            {
                descricao = consulta
               // data = data
            };
            dgvVendas.DataSource = lv.Consultar();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisar.Text);
        }

        private void frmConsultaVendas_Load(object sender, EventArgs e)
        {
            carregarGrid("");
        }
    }
}
