using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto231224e231223
{
    public class Banco
    {
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;
        public static DataTable datTabela;

        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                Conexao.Open();
            }
            catch (Exception e) { 
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("create database if not exists vendas;  USE vendas", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("create table if not exists cidades" +
                                            "(id integer auto_increment primary key, " +
                                            "nome char(40)," +
                                            "uf char(02))", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("create table if not exists marcas" +
                                            "(id integer auto_increment primary key, " +
                                            "marca char(40))" 
                                            , Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("create table if not exists categorias" +
                                          "(id integer auto_increment primary key, " +
                                          "categoria char(20))"
                                          , Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("create table if not exists clientes" +
                  "(id integer auto_increment primary key, " +
                  "nome char(40), " +
                  "idCidade integer, " +
                  "dataNasc date, " +
                  "renda decimal(10,2)," +
                  "cpf char(14)," +
                  "foto varchar(100)," +
                  "venda boolean)", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("create table if not exists produtos" +
                "(id integer auto_increment primary key, " +
                "descricao char(40), " +
                "idCategoria integer, " +
                "idMarca integer, " +
                "estoque decimal(10,3)," +
                "valorVenda decimal(10,2)," +
                "foto varchar(100))", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("create table if not exists vendaCab" +
                    "(id integer auto_increment primary key," +
                    "idCliente int," +
                    "data date," +
                    "total decimal(10,2))",Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("create table if not exists vendaDet" +
                    "(id integer auto_increment primary key," +
                    "idVendaCab int," +
                    "idProduto int," +
                    "qtde decimal(10,3)," +
                    "valorUnitario decimal(10,2))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("create table if not exists caixa" +
                    "(id integer auto_increment," +
                    "idVendaCab int," +
                    "dinheiro decimal(10,2)," +
                    "pix decimal(10,2)," +
                    "cartao decimal(10,2)," +
                    "cheque decimal(10,2)," +
                    "boleto decimal(10,2)", Conexao);
                Comando.ExecuteNonQuery();



                FecharConexao();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
