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
    public partial class frmRelatório : Form
    {
        Relatorio r;
        public frmRelatório()
        {
            InitializeComponent();
        }

        void carregarGrid(DateTime dtpMaxData)
        {
            r = new Relatorio()
            {
                maxData = dtpMaxData,
                
            };
            dgvLista.DataSource = r.Consulta();
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            if (chtCategorias.Visible) 
            {
                chtCategorias.Visible = false;
            }
            else
            {
                chtCategorias.Visible = true;
            }
        }

        private void frmRelatório_Load(object sender, EventArgs e)
        {
            carregarGrid(DateTime.Now );
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(dtpMaxData.Value);
        }
    }
}
