using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace projeto231224e231223.Models
{
    public class VendaCab
    {
        public int Id { get; set; }
        public int idCliente { get; set; }

        public DateTime Data { get; set; }
        public double Total { get; set; }


        public int Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                (
                    "insert into vendaCab(idCliente, data, total) " +
                    "values (@idCliente, @data, @total)", Banco.Conexao
                );
                Banco.Comando.Parameters.AddWithValue("@idCliente", idCliente);
                Banco.Comando.Parameters.AddWithValue("@data", Data);
                Banco.Comando.Parameters.AddWithValue("@total", Total);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
                return (int)Banco.Comando.LastInsertedId;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }
    }
}
