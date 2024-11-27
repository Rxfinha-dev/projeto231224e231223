using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto231224e231223.Models
{
    public class VendaCab
    {
        public int id { get; set; }
        public int idCliente { get; set; }

        public DateTime data { get; set; }
        public double total { get; set; }


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
                Banco.Comando.Parameter.AddWithValue("@idCliente", idCliente);
                Banco.Comando.Parameter.AddWithValue("@data", data);
                Banco.Comando.Parameter.AddWithValue("@total", total);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
                return (int)Banco.Comando.LastInsertedId;


            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return 0;
            }

    }
}
