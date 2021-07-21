using MySql.Data.MySqlClient;
using Propet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class ProdutoDAO
    {
        public void Criar(Produto p)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO produto(nome,unidadeMedida,categoria) VALUES('{0}','{1}','{2}')",
            p.Nome,p.UnidadeMedida,p.Categoria);
                
            
            db.ExecuteSQL(qry);
            
        }

        public List<Produto> ListaTodos()
        {
            List<Produto> lista = new List<Produto>();
            Produto produto;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT idProduto, nome, unidadeMedida, categoria FROM produto;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                produto = new Produto();
                produto.IdProduto = dr.GetInt32("idProduto");
                produto.Nome = dr.GetString("nome");
                produto.UnidadeMedida = dr.GetString("unidadeMedida");                
                produto.Categoria = dr.GetString("categoria");

                lista.Add(produto);
            }
            conexao.Close();
            return lista;
        }
    }
}
