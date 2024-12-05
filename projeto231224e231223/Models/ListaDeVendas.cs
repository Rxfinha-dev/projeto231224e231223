using System;
using System.Collections.Generic;
using System.Data.Common;
using projeto231224e231223.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace projeto231224e231223.Models
{
    public class ListaDeVendas
    {
        public string descricao {  get; set; }
        public DateTime data { get; set; }

        public DataTable Consultar()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                "select vc.id, vc.data Data, c.nome Nome," +
                " p.descricao Produto, vd.qtde Quantidade," +
                " vd.valorUnitario from vendadet vd inner join" +
                " vendacab vc on vd.idVendaCab = vc.id " +
                "inner join clientes c on vc.idCliente = c.id " +
                "inner join produtos p on vd.idProduto = p.id where p.descricao like @descricao and vc.data <= @data",
                Banco.Conexao
               );
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao + "%");
                Banco.Comando.Parameters.AddWithValue("@data", data);
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.Conexao.Close();
                return Banco.datTabela;
            }
            catch(Exception e) { 
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
