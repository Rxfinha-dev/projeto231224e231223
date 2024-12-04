using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto231224e231223.Models
{
    public class Caixa
    {
        public int Id { get; set; }
        public int idVendaCab {  get; set; }

        public double dinheiro { get; set; }
        public double pix {  get; set; } 

        public double cartao { get; set; }

        public double cheque { get; set; }

        public double boleto {  get; set; }

        public void Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                    "insert into caixa (idVendaCab, dinheiro, pix, cartao, cheque ,boleto)" +
                    "values (@idVendaCab, @dinheiro, @pix, @cartao, @cheque, @boleto)", Banco.Conexao
                    );
                Banco.Comando.Parameters.AddWithValue("@idVendaCab", idVendaCab);
                Banco.Comando.Parameters.AddWithValue("@dinheiro", dinheiro);
                Banco.Comando.Parameters.AddWithValue("@pix", pix);
                Banco.Comando.Parameters.AddWithValue("@cartao", cartao);
                Banco.Comando.Parameters.AddWithValue("cheque", cheque);
                Banco.Comando.Parameters.AddWithValue("@boleto", boleto);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
