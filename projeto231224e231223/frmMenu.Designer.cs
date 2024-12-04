namespace projeto231224e231223
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnVendas = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.pnProdutos = new System.Windows.Forms.Panel();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.pnClientes = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnCat = new System.Windows.Forms.Panel();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.pnMarcas = new System.Windows.Forms.Panel();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.pnCidades = new System.Windows.Forms.Panel();
            this.btnCidades = new System.Windows.Forms.Button();
            this.pnFechar = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnVendas.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnProdutos.SuspendLayout();
            this.pnClientes.SuspendLayout();
            this.pnCat.SuspendLayout();
            this.pnMarcas.SuspendLayout();
            this.pnCidades.SuspendLayout();
            this.pnFechar.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 31);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Principal";
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(41, 22);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.pnVendas);
            this.sidebar.Controls.Add(this.pnProdutos);
            this.sidebar.Controls.Add(this.pnClientes);
            this.sidebar.Controls.Add(this.pnCat);
            this.sidebar.Controls.Add(this.pnMarcas);
            this.sidebar.Controls.Add(this.pnCidades);
            this.sidebar.Controls.Add(this.pnFechar);
            this.sidebar.Location = new System.Drawing.Point(3, 32);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(191, 1920);
            this.sidebar.TabIndex = 3;
            // 
            // pnVendas
            // 
            this.pnVendas.Controls.Add(this.panel9);
            this.pnVendas.Controls.Add(this.btnVendas);
            this.pnVendas.Location = new System.Drawing.Point(3, 3);
            this.pnVendas.Name = "pnVendas";
            this.pnVendas.Size = new System.Drawing.Size(188, 46);
            this.pnVendas.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button8);
            this.panel9.Location = new System.Drawing.Point(3, 315);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(173, 46);
            this.panel9.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(-38, -19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(244, 84);
            this.button8.TabIndex = 0;
            this.button8.Text = "Cidades";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.Black;
            this.btnVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(-32, -19);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnVendas.Size = new System.Drawing.Size(244, 84);
            this.btnVendas.TabIndex = 0;
            this.btnVendas.Text = "      Vendas";
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // pnProdutos
            // 
            this.pnProdutos.Controls.Add(this.btnProdutos);
            this.pnProdutos.Location = new System.Drawing.Point(3, 55);
            this.pnProdutos.Name = "pnProdutos";
            this.pnProdutos.Size = new System.Drawing.Size(188, 46);
            this.pnProdutos.TabIndex = 8;
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.Black;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(-33, -18);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnProdutos.Size = new System.Drawing.Size(244, 84);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "      Produtos";
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // pnClientes
            // 
            this.pnClientes.Controls.Add(this.btnClientes);
            this.pnClientes.Location = new System.Drawing.Point(3, 107);
            this.pnClientes.Name = "pnClientes";
            this.pnClientes.Size = new System.Drawing.Size(188, 46);
            this.pnClientes.TabIndex = 7;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Black;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-34, -17);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(244, 84);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "      Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnCat
            // 
            this.pnCat.Controls.Add(this.btnCategorias);
            this.pnCat.Location = new System.Drawing.Point(3, 159);
            this.pnCat.Name = "pnCat";
            this.pnCat.Size = new System.Drawing.Size(188, 46);
            this.pnCat.TabIndex = 6;
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Black;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(-35, -19);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(244, 84);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "      Categorias";
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // pnMarcas
            // 
            this.pnMarcas.Controls.Add(this.btnMarcas);
            this.pnMarcas.Location = new System.Drawing.Point(3, 211);
            this.pnMarcas.Name = "pnMarcas";
            this.pnMarcas.Size = new System.Drawing.Size(173, 46);
            this.pnMarcas.TabIndex = 5;
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.Black;
            this.btnMarcas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnMarcas.ForeColor = System.Drawing.Color.White;
            this.btnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcas.Image")));
            this.btnMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.Location = new System.Drawing.Point(-34, -18);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnMarcas.Size = new System.Drawing.Size(244, 84);
            this.btnMarcas.TabIndex = 0;
            this.btnMarcas.Text = "      Marcas";
            this.btnMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // pnCidades
            // 
            this.pnCidades.Controls.Add(this.btnCidades);
            this.pnCidades.Location = new System.Drawing.Point(3, 263);
            this.pnCidades.Name = "pnCidades";
            this.pnCidades.Size = new System.Drawing.Size(173, 46);
            this.pnCidades.TabIndex = 5;
            // 
            // btnCidades
            // 
            this.btnCidades.BackColor = System.Drawing.Color.Black;
            this.btnCidades.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCidades.ForeColor = System.Drawing.Color.White;
            this.btnCidades.Image = ((System.Drawing.Image)(resources.GetObject("btnCidades.Image")));
            this.btnCidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCidades.Location = new System.Drawing.Point(-34, -19);
            this.btnCidades.Name = "btnCidades";
            this.btnCidades.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnCidades.Size = new System.Drawing.Size(244, 84);
            this.btnCidades.TabIndex = 0;
            this.btnCidades.Text = "      Cidades";
            this.btnCidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCidades.UseVisualStyleBackColor = false;
            this.btnCidades.Click += new System.EventHandler(this.btnCidades_Click);
            // 
            // pnFechar
            // 
            this.pnFechar.Controls.Add(this.panel10);
            this.pnFechar.Controls.Add(this.btnFechar);
            this.pnFechar.Location = new System.Drawing.Point(3, 315);
            this.pnFechar.Name = "pnFechar";
            this.pnFechar.Size = new System.Drawing.Size(173, 57);
            this.pnFechar.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button1);
            this.panel10.Location = new System.Drawing.Point(3, 315);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(173, 46);
            this.panel10.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-38, -19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cidades";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Black;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(-30, -12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnFechar.Size = new System.Drawing.Size(244, 84);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "      Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 746);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu do Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnVendas.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnProdutos.ResumeLayout(false);
            this.pnClientes.ResumeLayout(false);
            this.pnCat.ResumeLayout(false);
            this.pnMarcas.ResumeLayout(false);
            this.pnCidades.ResumeLayout(false);
            this.pnFechar.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnCidades;
        private System.Windows.Forms.Button btnCidades;
        private System.Windows.Forms.Panel pnMarcas;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Panel pnCat;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Panel pnClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnProdutos;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Panel pnVendas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnFechar;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFechar;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

