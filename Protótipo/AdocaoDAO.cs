using MySql.Data.MySqlClient;
using Propet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class AdocaoDAO
    {
        public void Criar(Adocao a)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO adocao(idCao,cpf,dataAdocao) VALUES({0},'{1}','{2}')",
            a.Cachorro.IdCao, a.Pessoa.Cpf,a.DataAdocao.ToString("yyyy=MM=dd"));

            db.ExecuteSQL(qry);
        }
        public int voltaMaxId()
        {
            int idMax = new int();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT MAX(idAdocao) FROM adocao;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                idMax = dr.GetInt32("MAX(idAdocao)");
            }
            conexao.Close();

            return idMax;

        }

        public int ContarAdocao()
        {
            int quantidade = new int();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT COUNT(*) FROM adocao;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                quantidade = dr.GetInt32("COUNT(*)");
            }
            conexao.Close();

            return quantidade;
        }

        public List<Adocao> ListaPorId(int id)
        {
            List<Adocao> lista = new List<Adocao>();
            Adocao adocao;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT a.idAdocao,a.DataAdocao, p.nome,p.cpf, p.telefone, p.celular, c.nomeCao,c.idCao, c.raca, c.sexo  FROM adocao a JOIN pessoa p ON a.cpf = p.cpf JOIN cachorro c ON a.idCao = c.idCao WHERE a.idAdocao = "+id+";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                adocao = new Adocao();
                adocao.Pessoa = new Pessoa();
                adocao.Cachorro = new Cachorro();
                adocao.DataAdocao = new DateTime();

                adocao.IdAdocao = dr.GetInt32("idAdocao");


                adocao.Pessoa.Nome = dr.GetString("nome");
                adocao.Pessoa.Cpf = dr.GetString("cpf");
                adocao.Pessoa.Telefone = dr.GetString("telefone");
                adocao.Pessoa.Celular = dr.GetString("celular");
                adocao.DataAdocao = dr.GetDateTime("dataAdocao");

                adocao.Cachorro.NomeCao = dr.GetString("nomeCao");
                adocao.Cachorro.IdCao = dr.GetInt32("idCao");
                adocao.Cachorro.Raca = dr.GetString("raca");
                adocao.Cachorro.Sexo = dr.GetChar("sexo");

                lista.Add(adocao);
            }
            conexao.Close();
            return lista;
        }

        public List<Adocao> ListaTodos()
        {
            List<Adocao> lista = new List<Adocao>();
            Adocao adocao;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT a.idAdocao,a.DataAdocao, p.nome,p.cpf, p.telefone, p.celular, c.nomeCao, c.raca, c.sexo  FROM adocao a, pessoa p, cachorro c WHERE a.idCao = c.idCao AND a.cpf = p.cpf;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                adocao = new Adocao();
                adocao.Pessoa = new Pessoa();
                adocao.Cachorro = new Cachorro();
                adocao.DataAdocao = new DateTime();

                adocao.IdAdocao = dr.GetInt32("idAdocao");


                adocao.Pessoa.Nome = dr.GetString("nome");
                adocao.Pessoa.Cpf = dr.GetString("cpf");
                adocao.Pessoa.Telefone = dr.GetString("telefone");
                adocao.Pessoa.Celular = dr.GetString("celular");
                adocao.DataAdocao = dr.GetDateTime("dataAdocao");

                adocao.Cachorro.NomeCao = dr.GetString("nomeCao");
                adocao.Cachorro.Raca = dr.GetString("raca");
                adocao.Cachorro.Sexo = dr.GetChar("sexo");

                lista.Add(adocao);
            }
            conexao.Close();
            return lista;
        }



        public List<Adocao> ListaData(DateTime data)
        {
            List<Adocao> lista = new List<Adocao>();
            Adocao adocao;


            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT p.nome, p.celular, p.telefone, c.nomeCao, c.idCao, a.dataAdocao FROM pessoa p, cachorro c, adocao a where a.dataAdocao ='"+data.ToString("yyyy-MM-dd")+"' AND a.idCao = c.idCao AND a.cpf = p.cpf; ";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                adocao = new Adocao();
                adocao.Pessoa = new Pessoa();
                adocao.Cachorro = new Cachorro();
                adocao.DataAdocao = dr.GetDateTime("dataAdocao");
                adocao.Pessoa.Nome = dr.GetString("nome");
                adocao.Pessoa.Celular = dr.GetString("celular");
                adocao.Pessoa.Telefone = dr.GetString("telefone");
                adocao.Cachorro.NomeCao = dr.GetString("nomeCao");

                lista.Add(adocao);
            }
            conexao.Close();
            return lista;
        }

        public List<Adocao> ListaPesquisa(string pesquisa)
        {
            List<Adocao> lista = new List<Adocao>();
            Adocao adocao;
            Pessoa pessoa;
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT a.idAdocao,a.DataAdocao, p.nome,p.cpf, p.telefone, p.celular, c.nomeCao, c.raca, c.sexo  FROM adocao a Join pessoa p on a.cpf =p.cpf join cachorro c on a.idCao = c.idCao where p.nome like ' %" +pesquisa +"% ' or c.nomeCao like '%"+pesquisa+"%';";


            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                adocao = new Adocao();
                adocao.Pessoa = new Pessoa();
                adocao.Cachorro = new Cachorro();
                adocao.DataAdocao = new DateTime();

                adocao.IdAdocao = dr.GetInt32("idAdocao");


                adocao.Pessoa.Nome = dr.GetString("nome");
                adocao.Pessoa.Cpf = dr.GetString("cpf");
                adocao.Pessoa.Telefone = dr.GetString("telefone");
                adocao.Pessoa.Celular = dr.GetString("celular");
                adocao.DataAdocao = dr.GetDateTime("dataAdocao");

                adocao.Cachorro.NomeCao = dr.GetString("nomeCao");
                adocao.Cachorro.Raca = dr.GetString("raca");
                adocao.Cachorro.Sexo = dr.GetChar("sexo");

                lista.Add(adocao);
            }

            conexao.Close();
            return lista;
        }
    }
}
