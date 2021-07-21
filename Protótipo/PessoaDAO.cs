using MySql.Data.MySqlClient;
using Propet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class PessoaDAO
    {
        public void Criar(Pessoa p)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO pessoa VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}', '{14}')",
            p.Nome, p.Cpf, p.Endereco, p.Cep, p.Numero, p.Complemento, p.Bairro, p.Telefone, p.Celular, p.Email, p.Interesse , p.PorteInteresse, p.DataRegistro.ToString("yyyy-MM-dd"),p.Cidade,p.Desinteressado);

            db.ExecuteSQL(qry);
        }

        public void Editar(Pessoa p)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("UPDATE pessoa SET nome = '" + p.Nome + "', cpf = '" + p.Cpf + "', endereco = '" + p.Endereco + "', cep = '" + p.Cep + "', numero = "+p.Numero+", complemento = '" + p.Complemento + "', bairro = '" + p.Bairro + "', cidade = '" + p.Cidade + "', telefone = '" + p.Telefone+"', celular = '" + p.Celular + "', email ='" + p.Email + "', semInteresse = '"+ p.Desinteressado +"', interesse = '"+ p.Interesse + "' WHERE cpf = '" + p.Cpf+"';");

            db.ExecuteSQL(qry);
        }
        public Pessoa AchaPessoa(string cpf)
        {
            Pessoa pessoa = new Pessoa();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, cpf, endereco, cep, numero, complemento, bairro, cidade, telefone, celular, email, interesse, porteInteresse, semInteresse, dataRegistro FROM pessoa WHERE cpf = '" + cpf + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.Nome = dr.GetString("nome");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Endereco = dr.GetString("endereco");
                pessoa.Cep = dr.GetString("cep");
                pessoa.Numero = dr.GetInt32("numero");
                pessoa.Complemento = dr.GetString("complemento");
                pessoa.Bairro = dr.GetString("bairro");
                pessoa.Telefone = dr.GetString("telefone");
                pessoa.Celular = dr.GetString("celular");
                pessoa.Email = dr.GetString("email");
                pessoa.Interesse = dr.GetString("interesse");
                pessoa.PorteInteresse = dr.GetString("porteInteresse");               
                pessoa.DataRegistro = dr.GetDateTime("dataRegistro");
                pessoa.Cidade = dr.GetString("cidade");
                pessoa.Desinteressado = dr.GetChar("semInteresse");
            }
            conexao.Close();
            return pessoa;
        }

        public List<Pessoa> ListaTodos()
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa pessoa;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, cpf, endereco, cep, numero, complemento, bairro, cidade, telefone, celular, email, interesse, porteInteresse, semInteresse, dataRegistro FROM pessoa WHERE semInteresse = 'N';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.Nome = dr.GetString("nome");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Endereco = dr.GetString("endereco");
                pessoa.Cep = dr.GetString("cep");
                pessoa.Numero = dr.GetInt32("numero");
                pessoa.Complemento = dr.GetString("complemento");
                pessoa.Bairro = dr.GetString("bairro");
                pessoa.Telefone = dr.GetString("telefone");
                pessoa.Celular = dr.GetString("celular");
                pessoa.Email = dr.GetString("email");
                pessoa.Interesse = dr.GetString("interesse");
                pessoa.PorteInteresse = dr.GetString("porteInteresse");               
                pessoa.DataRegistro = dr.GetDateTime("dataRegistro");
                pessoa.Cidade = dr.GetString("cidade");
                pessoa.Desinteressado = dr.GetChar("semInteresse");
              
                lista.Add(pessoa);
            }
            conexao.Close();
            return lista;
        }

        public List<Pessoa> ListaInteresse(string interesse)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa pessoa;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, cpf, endereco, cep, numero, complemento, bairro, cidade, telefone, celular, email, interesse, porteInteresse, semInteresse, dataRegistro FROM pessoa WHERE interesse = '" + interesse + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.Nome = dr.GetString("nome");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Endereco = dr.GetString("endereco");
                pessoa.Cep = dr.GetString("cep");
                pessoa.Numero = dr.GetInt32("numero");
                pessoa.Complemento = dr.GetString("complemento");
                pessoa.Bairro = dr.GetString("bairro");
                pessoa.Telefone = dr.GetString("telefone");
                pessoa.Celular = dr.GetString("celular");
                pessoa.Email = dr.GetString("email");
                pessoa.Interesse = dr.GetString("interesse");
                pessoa.PorteInteresse = dr.GetString("porteInteresse");              
                pessoa.DataRegistro = dr.GetDateTime("dataRegistro");
                pessoa.Cidade = dr.GetString("cidade");
                pessoa.Desinteressado = dr.GetChar("semInteresse");
                lista.Add(pessoa);
            }
            conexao.Close();
            return lista;
        }

        public List<Pessoa> ListaPessoaInteressada(string porte)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa pessoa;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, cpf, endereco, cep, numero, complemento, bairro, cidade, telefone, celular, email, interesse, porteInteresse, semInteresse, dataRegistro FROM pessoa WHERE (porteInteresse = '" + porte + "' OR porteInteresse = 'Qualquer Porte') AND interesse = 'Adotar';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.Nome = dr.GetString("nome");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Endereco = dr.GetString("endereco");
                pessoa.Cep = dr.GetString("cep");
                pessoa.Numero = dr.GetInt32("numero");
                pessoa.Complemento = dr.GetString("complemento");
                pessoa.Bairro = dr.GetString("bairro");
                pessoa.Telefone = dr.GetString("telefone");
                pessoa.Celular = dr.GetString("celular");
                pessoa.Email = dr.GetString("email");
                pessoa.Interesse = dr.GetString("interesse");
                pessoa.PorteInteresse = dr.GetString("porteInteresse");
                pessoa.DataRegistro = dr.GetDateTime("dataRegistro");
                pessoa.Cidade = dr.GetString("cidade");
                pessoa.Desinteressado = dr.GetChar("semInteresse");
                lista.Add(pessoa);
            }
            conexao.Close();
            return lista;
        }

        public List<Pessoa> ListaAdotarRaca(int interesse, string interesseRaca)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa pessoa;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, cpf, endereco, cep, numero, complemento, bairro, cidade, telefone, celular, email, interesse, porteInteresse, semInteresse, dataRegistro FROM pessoa WHERE interesse = " + interesse + " AND racaInteresse = '" + interesseRaca + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.Nome = dr.GetString("nome");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Endereco = dr.GetString("endereco");
                pessoa.Cep = dr.GetString("cep");
                pessoa.Numero = dr.GetInt32("numero");
                pessoa.Complemento = dr.GetString("complemento");
                pessoa.Bairro = dr.GetString("bairro");
                pessoa.Telefone = dr.GetString("telefone");
                pessoa.Celular = dr.GetString("celular");
                pessoa.Email = dr.GetString("email");
                pessoa.Interesse = dr.GetString("interesse");
                pessoa.PorteInteresse = dr.GetString("porteInteresse");                
                pessoa.DataRegistro = dr.GetDateTime("dataRegistro");
                pessoa.Cidade = dr.GetString("cidade");
                pessoa.Desinteressado = dr.GetChar("semInteresse");
                lista.Add(pessoa);
            }
            conexao.Close();
            return lista;
        }


        public List<Pessoa> ListaInteressePorte(string interesse, string interessePorte)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa pessoa;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, cpf, endereco, cep, numero, complemento, bairro, cidade, telefone, celular, email, interesse, semInteresse, porteInteresse, dataRegistro FROM pessoa WHERE interesse = '" + interesse + "' AND porteInteresse = '"+interessePorte+ "'  AND semInteresse = 'N';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.Nome = dr.GetString("nome");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Endereco = dr.GetString("endereco");
                pessoa.Cep = dr.GetString("cep");
                pessoa.Numero = dr.GetInt32("numero");
                pessoa.Complemento = dr.GetString("complemento");
                pessoa.Bairro = dr.GetString("bairro");
                pessoa.Telefone = dr.GetString("telefone");
                pessoa.Celular = dr.GetString("celular");
                pessoa.Email = dr.GetString("email");
                pessoa.Interesse = dr.GetString("interesse");
                pessoa.PorteInteresse = dr.GetString("porteInteresse");                
                pessoa.DataRegistro = dr.GetDateTime("dataRegistro");
                pessoa.Cidade = dr.GetString("cidade");
                pessoa.Desinteressado = dr.GetChar("semInteresse");
                lista.Add(pessoa);
            }
            conexao.Close();
            return lista;
        }

        public List<Pessoa> ListaPorteInteresse(string interessePorte)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa pessoa;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, cpf, endereco, cep, numero, complemento, bairro, cidade, telefone, celular,semInteresse, email, interesse, porteInteresse, dataRegistro FROM pessoa WHERE porteInteresse = '" + interessePorte + "' AND semInteresse = 'N';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.Nome = dr.GetString("nome");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Endereco = dr.GetString("endereco");
                pessoa.Cep = dr.GetString("cep");
                pessoa.Numero = dr.GetInt32("numero");
                pessoa.Complemento = dr.GetString("complemento");
                pessoa.Bairro = dr.GetString("bairro");
                pessoa.Telefone = dr.GetString("telefone");
                pessoa.Celular = dr.GetString("celular");
                pessoa.Email = dr.GetString("email");
                pessoa.Interesse = dr.GetString("interesse");
                pessoa.PorteInteresse = dr.GetString("porteInteresse");                
                pessoa.DataRegistro = dr.GetDateTime("dataRegistro");
                pessoa.Cidade = dr.GetString("cidade");
                pessoa.Desinteressado = dr.GetChar("semInteresse");
                lista.Add(pessoa);
            }
            conexao.Close();
            return lista;
        }

        public List<Pessoa> ListaSemInteresse(char semInteresse)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa pessoa;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, cpf, endereco, cep, numero, complemento, bairro, cidade, telefone, celular,semInteresse, email, interesse, porteInteresse, dataRegistro FROM pessoa WHERE semInteresse = '" + semInteresse + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.Nome = dr.GetString("nome");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Endereco = dr.GetString("endereco");
                pessoa.Cep = dr.GetString("cep");
                pessoa.Numero = dr.GetInt32("numero");
                pessoa.Complemento = dr.GetString("complemento");
                pessoa.Bairro = dr.GetString("bairro");
                pessoa.Telefone = dr.GetString("telefone");
                pessoa.Celular = dr.GetString("celular");
                pessoa.Email = dr.GetString("email");
                pessoa.Interesse = dr.GetString("interesse");
                pessoa.PorteInteresse = dr.GetString("porteInteresse");
                pessoa.DataRegistro = dr.GetDateTime("dataRegistro");
                pessoa.Cidade = dr.GetString("cidade");
                pessoa.Desinteressado = dr.GetChar("semInteresse");
                lista.Add(pessoa);
            }
            conexao.Close();
            return lista;
        }

        public List<Pessoa> ListaPesquisa(string pesquisa)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa pessoa;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, cpf, endereco, cep, numero, complemento, bairro, cidade, telefone, semInteresse, celular, email, interesse, porteInteresse, dataRegistro FROM pessoa WHERE nome LIKE '%" + pesquisa + "%' OR endereco LIKE '%" + pesquisa + "%' OR cpf LIKE '%" + pesquisa + "%' OR cep LIKE '%" + pesquisa + "%' OR bairro LIKE '%" + pesquisa + "%' OR email LIKE '%" + pesquisa + "%';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.Nome = dr.GetString("nome");
                pessoa.Cpf = dr.GetString("cpf");
                pessoa.Endereco = dr.GetString("endereco");
                pessoa.Cep = dr.GetString("cep");
                pessoa.Numero = dr.GetInt32("numero");
                pessoa.Complemento = dr.GetString("complemento");
                pessoa.Bairro = dr.GetString("bairro");
                pessoa.Telefone = dr.GetString("telefone");
                pessoa.Celular = dr.GetString("celular");
                pessoa.Email = dr.GetString("email");
                pessoa.Interesse = dr.GetString("interesse");
                pessoa.PorteInteresse = dr.GetString("porteInteresse");                
                pessoa.DataRegistro = dr.GetDateTime("dataRegistro");
                pessoa.Cidade = dr.GetString("cidade");
                pessoa.Desinteressado = dr.GetChar("semInteresse");
                lista.Add(pessoa);
            }
            conexao.Close();
            return lista;
        }
    }
}
