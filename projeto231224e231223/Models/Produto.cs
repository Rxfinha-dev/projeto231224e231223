using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace projeto231224e231223.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public decimal estoque { get; set; }
        public decimal valor { get; set; }
        public string foto { get; set; }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("select p.*, m.marca, c.categoria from " +
                "produtos p inner join marcas m on (m.id = p.idMarca) " +
                "inner join categorias c on (c.id = p.idCategoria)" +
                "where p.descricao like @descricao order by p.descricao", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                return Banco.datTabela;
            }
            catch(Exception e) {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
