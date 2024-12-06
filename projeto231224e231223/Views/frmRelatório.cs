using projeto231224e231223.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace projeto231224e231223.Views
{
    public partial class frmRelatório : Form
    {
        Relatorio r;
        public frmRelatório()
        {
            InitializeComponent();
        }

        void carregarGrid(string pesquisa)
        {
            r = new Relatorio()
            {
                pesquisa = pesquisa
            };

            DataTable data = r.Consulta(); // Assuming Consulta() returns a DataTable

            // Dictionary to store category and its corresponding value
            Dictionary<string, double> categoryValues = new Dictionary<string, double>();

            // Loop through the data and accumulate values
            foreach (DataRow row in data.Rows)
            {
                string category = row["categoria"].ToString(); // Replace with actual column name
                double value = Convert.ToDouble(row["quantidadeVendas"].ToString()); // Replace with actual column name

                if (categoryValues.ContainsKey(category))
                {
                    categoryValues[category] += value;
                }
                else
                {
                    categoryValues.Add(category, value);
                }
            }

            // Access chart control and populate pie chart
            this.chtCategorias.Series.Clear();
            var pieSeries = new Series("Category Breakdown") { ChartType = SeriesChartType.Pie };
            foreach (var item in categoryValues)
            {
                pieSeries.Points.AddXY(item.Key, item.Value);
            }
            this.chtCategorias.Series.Add(pieSeries);

            dgvLista.DataSource = data;


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
            carregarGrid("");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisar.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvLista.DataSource == null)
            {
                MessageBox.Show("Não há dados para imprimir. Por favor, realize uma pesquisa primeiro.");
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Obter o DataGridView e seus dados
            DataGridView dgv = dgvLista;
            DataTable data = (DataTable)dgv.DataSource;

            // Definir margens e fonte
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int rightMargin = e.MarginBounds.Right;
            int bottomMargin = e.MarginBounds.Bottom;
            Font font = new Font("Arial", 10, FontStyle.Regular);

            // Calcular a área de impressão disponível
            float yPos = topMargin;
            float xPos = leftMargin;
            float maxWidth = e.MarginBounds.Width - (leftMargin + rightMargin);

            // Imprimir o cabeçalho
            foreach (DataColumn column in data.Columns)
            {
                float columnWidth = GetColumnWidthInPoints(dgv, column.ColumnName);
                e.Graphics.DrawString(column.ColumnName, font, Brushes.Black, xPos, yPos);
                xPos += columnWidth;
            }



            yPos += font.GetHeight(); // Mover para a próxima linha

            // Imprimir cada linha de dados
            foreach (DataRow row in data.Rows)
            {
                xPos = leftMargin; // Resetar xPos para cada linha

                for (int i = 0; i < data.Columns.Count; i++)
                {
                    float columnWidth = GetColumnWidthInPoints(dgv, data.Columns[i].ColumnName);
                    string cellValue = row[i].ToString();
                    e.Graphics.DrawString(cellValue, font, Brushes.Black, xPos, yPos);
                    xPos += columnWidth;
                }

                yPos += font.GetHeight(); // Mover para a próxima linha


                // Verificar se atingimos o final da página
                if (yPos >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Não há mais páginas
            e.HasMorePages = false;


        }

        private float GetColumnWidthInPoints(DataGridView dgv, string columnName)
        {
            DataGridViewColumn column = dgv.Columns[columnName];
            // Assuming the width is already in pixels relative to the DataGridView
            return column.Width;
        }

    }
}
