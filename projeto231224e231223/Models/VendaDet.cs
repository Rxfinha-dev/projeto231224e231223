using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto231224e231223.Models
{
    public class VendaDet
    {
        public int id { get; set; }
        public int idVendaCab {  get; set; }
        public int idProduto { get; set; }
        public double qtde {  get; set; }
        public double valorUnitario { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                    "insert into vendaDet(idVendaCab, idProduto, qtde, valorUnitario) " +
                    "values (@idVendaCab, @idProduto, @qtde, @valorUnitario)",
                    Banco.Conexao
                );
                Banco.Comando.Parameters.AddWithValue("@idVendaCab", idVendaCab);
                Banco.Comando.Parameters.AddWithValue("@idProduto", idProduto);
                Banco.Comando.Parameters.AddWithValue("@qtde", qtde);
                Banco.Comando.Parameters.AddWithValue("@valorUnitario", valorUnitario);
                Banco.Comando.ExecuteNonQuery();
                Banco.Comando.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
