using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;



namespace projeto231224e231223.Models
{
    public class Relatorio
    {
        
        public string pesquisa {  get; set; }
   

        public DataTable Consulta()
        {

            try
            {
                Banco.Comando = new MySqlCommand("SELECT c.categoria AS Categoria," +
                    " COUNT(vd.id) AS QuantidadeVendas " +
                    "FROM categorias c " +
                    "INNER JOIN produtos p ON c.id = p.idCategoria " +
                    "INNER JOIN vendaDet vd ON p.id = vd.idProduto " +
                    "INNER JOIN vendaCab vc ON vd.idVendaCab = vc.id " +
                    "WHERE c.categoria like @pesquisa " +
                    "group by c.categoria order by QuantidadeVendas  "
                    , Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@pesquisa", pesquisa + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                return Banco.datTabela;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }
    }
}
