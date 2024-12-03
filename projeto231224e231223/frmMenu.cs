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
using projeto231224e231223.Views;

namespace projeto231224e231223
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidades form = new frmCidades();
            form.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas form = new frmMarcas();
            form.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias form = new frmCategorias();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes form = new frmClientes();
            form.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos form = new frmProdutos();
            form.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda form = new frmVenda();
            form.Show();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 62) {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

     
                }
            } else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 191) 
                { 
                    sidebarExpand= true;
                    sidebarTransition.Stop();

                   

                    
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

     
    }
}
