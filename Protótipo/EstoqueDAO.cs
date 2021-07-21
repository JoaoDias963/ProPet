using MySql.Data.MySqlClient;
using Propet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class EstoqueDAO
    {
        public void CriarPrimeiro(Produto e)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO estoque(idProduto,quantidade,dataRegistro) VALUES((SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'produto')-1, '{0}' ,'{1}')", 0,DateTime.Today.ToString("yyyy-MM-dd"));

            db.ExecuteSQL(qry);
        }


        public void Criar(Estoque e)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO estoque(idProduto,quantidade,dataRegistro) VALUES({0},{1},'{2}')",
            e.Produto.IdProduto, e.Quantidade, DateTime.Today.ToString("yyyy-MM-dd"));

            db.ExecuteSQL(qry);
        }


        public List<Estoque> ListaTodos()
        {
            List<Estoque> lista = new List<Estoque>();
            Estoque estoque;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT e.idEstoque,e.quantidade, p.Nome,p.Categoria, p.idProduto, p.unidadeMedida, e.dataRegistro FROM estoque e, produto p WHERE e.idProduto = p.idProduto;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                estoque = new Estoque();
                estoque.Quantidade = dr.GetInt32("quantidade");
                estoque.DataRegistro = dr.GetDateTime("dataRegistro"); 
                estoque.Produto = new Produto();
                estoque.Produto.IdProduto = dr.GetInt32("idProduto");
                estoque.Produto.Nome = dr.GetString("nome");
                estoque.Produto.Categoria = dr.GetString("categoria");
                estoque.Produto.UnidadeMedida = dr.GetString("unidadeMedida");
                

                lista.Add(estoque);
            }
            conexao.Close();
            return lista;
        }

        public List<Estoque> ListaPesquisa(string pesquisa)
        {
            List<Estoque> lista = new List<Estoque>();
            Estoque estoque;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT e.idEstoque,e.quantidade, p.nome, p.categoria,p.idProduto, p.unidadeMedida, e.dataRegistro FROM estoque e JOIN produto p ON e.idProduto = p.idProduto WHERE p.Nome LIKE '%" + pesquisa+"%' OR p.Categoria LIKE '%"+pesquisa+"%'; ";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                estoque = new Estoque();
                estoque.Quantidade = dr.GetInt32("quantidade");
                estoque.DataRegistro = dr.GetDateTime("dataRegistro");
                estoque.Produto = new Produto();
                estoque.Produto.IdProduto = dr.GetInt32("idProduto");
                estoque.Produto.Nome = dr.GetString("nome");
                estoque.Produto.Categoria = dr.GetString("categoria");
                estoque.Produto.UnidadeMedida = dr.GetString("unidadeMedida");


                lista.Add(estoque);
            }
            conexao.Close();
            return lista;
        }
    

    public long ListaSoma(Produto p)
        {
            long quantidade = new long();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT SUM(e.quantidade) AS qt FROM estoque e, produto p WHERE e.idProduto = p.idProduto AND e.idProduto = "+p.IdProduto+";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                quantidade = dr.GetInt32("qt");
            }
            conexao.Close();

            return quantidade;
        }
    }
}
