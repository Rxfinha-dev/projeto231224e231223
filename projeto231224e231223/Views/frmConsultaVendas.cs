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

        DateTime tomorrowDate = DateTime.Now + new TimeSpan(1, 0, 0, 0);




        public  frmConsultaVendas()
        {
            InitializeComponent();
        }

        void carregarGrid(string consulta, DateTime data)
        {
            lv = new ListaDeVendas()
            {
                descricao = consulta,
                data = data
            };
            dgvVendas.DataSource = lv.Consultar();
            lblTotal.Text = (dgvVendas.Rows.Count - 1).ToString();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisar.Text, dtpVenda.Value);
            lblTotal.Text = (dgvVendas.Rows.Count - 1).ToString();
        }

        private void frmConsultaVendas_Load(object sender, EventArgs e)
        {
            dtpVenda.Value = DateTime.Now;
            carregarGrid("", DateTime.Now);
            lblTotal.Text = (dgvVendas.Rows.Count - 1).ToString();
        }

        
    }
}
