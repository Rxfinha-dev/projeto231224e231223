using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;



namespace projeto231224e231223.Models
{
    public class Relatorio
    {
        public DateTime maxData { get; set; }

   

        public DataTable Consulta()
        {

            try
            {
                Banco.Comando = new MySqlCommand("select c.categoria, count(*) from categorias c " +
               "inner join produtos p on p.idCategoria = c.id " +
               "inner join vendadet vd on vd.idProduto = p.id inner " +
               "join vendacab vc on vc.id = vd.idVendaCab " +
               "where vc.data <= @maxData", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@maxData", maxData);              
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
