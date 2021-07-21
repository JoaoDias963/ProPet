using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Propet;

namespace Protótipo
{
    class CachorroDAO
    {
        public void Criar(Cachorro c)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO cachorro(nomeCao,raca,sexo,idade,cor,bairro,porte,vacinado,observacao,dataRegistro,falecido) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
            c.NomeCao, c.Raca, c.Sexo,c.Idade,c.Cor,c.Bairro,c.Porte,c.Vacinado ? 1:0,c.Observacao,c.DataRegistro.ToString("yyyy-MM-dd"),c.Falecido ? 1:0);
            
            db.ExecuteSQL(qry);
        }

        public void CriarCaoExterno(Cachorro c)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO cachorro(nomeCao,raca,sexo,idade,cor,bairro,porte,vacinado,observacao,dataRegistro,falecido,idCao) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',(SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'cachorroDoacao'))",
            c.NomeCao, c.Raca, c.Sexo, c.Idade, c.Cor, c.Bairro, c.Porte, c.Vacinado ? 1 : 0, c.Observacao, c.DataRegistro.ToString("yyyy-MM-dd"), c.Falecido ? 1 : 0);

            db.ExecuteSQL(qry);
        }

        public void CriarCachorroDoacao(CachorroDoacao c)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO cachorroDoacao(cpfDono,nomeCao,raca,sexo,idade,cor,bairro,porte,vacinado,observacao,dataRegistro,falecido) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
            c.Dono.Cpf, c.NomeCao, c.Raca, c.Sexo, c.Idade, c.Cor, c.Bairro, c.Porte, c.Vacinado ? 1 : 0, c.Observacao, c.DataRegistro.ToString("yyyy-MM-dd"), c.Falecido ? 1 : 0);

            db.ExecuteSQL(qry);
        }
        public void Editar(Cachorro c)
        {
            Propet.Database db = Propet.Database.GetInstance();
            /*tentativa*/
            if(c.NomeCao!="Cachorro externo")
            {
                string qry = string.Format("UPDATE cachorro SET nomeCao = '" + c.NomeCao + "', raca = '" + c.Raca + "', sexo = '" + c.Sexo + "', idade = '" + c.Idade + "', cor = '" + c.Cor + "', bairro = '" + c.Bairro + "', porte = '" + c.Porte + "', vacinado = '{0}', observacao = '" + c.Observacao + "', dataRegistro ='" + c.DataRegistro.ToString("yyyy-MM-dd") + "', falecido = '{1}' WHERE idCao = " + c.IdCao.ToString(), c.Vacinado ? 1 : 0, c.Falecido ? 1 : 0);
                db.ExecuteSQL(qry);
            }
            else
            {
                string qry = string.Format("UPDATE cachorroDoacao SET nomeCao = '" + c.NomeCao + "', raca = '" + c.Raca + "', sexo = '" + c.Sexo + "', idade = '" + c.Idade + "', cor = '" + c.Cor + "', bairro = '" + c.Bairro + "', porte = '" + c.Porte + "', vacinado = '{0}', observacao = '" + c.Observacao + "', dataRegistro ='" + c.DataRegistro.ToString("yyyy-MM-dd") + "', falecido = '{1}' WHERE idCao = " + c.IdCao.ToString(), c.Vacinado ? 1 : 0, c.Falecido ? 1 : 0);
                db.ExecuteSQL(qry);
            }
        }

        public int SomaPorte(Produto p)
        {
            int quantidade = new int();
            string porte = "";

            if (p.Categoria == "Ração para Porte Mini")
                porte = "Mini";
            else if (p.Categoria == "Ração para Porte Pequeno")
                porte = "Pequeno";
            else if (p.Categoria == "Ração para Porte Pequeno/Médio")
                porte = "Pequeno/Médio";
            else if (p.Categoria == "Ração para Porte Médio")
                porte = "Médio";
            else if (p.Categoria == "Ração para Porte Grande")
                porte = "Grande";
            else if (p.Categoria == "Ração para Porte Gigante")
                porte = "Gigante";
            Console.WriteLine(porte);
            Console.WriteLine(porte);
            Console.WriteLine(porte);
            Console.WriteLine(porte);

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT COUNT(c.nomeCao) AS qt FROM cachorro c LEFT JOIN adocao a ON a.idCao = c.idCao WHERE c.porte = '"+porte+ "' AND a.idCao IS NULL AND c.Falecido = 0;";

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

        public int lastIdCao()
        {
            int lastIdCao = new int();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT AUTO_INCREMENT as lastId FROM information_schema.tables WHERE table_name = 'cachorro';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                lastIdCao = dr.GetInt32("lastId");
            }
            conexao.Close();

            return lastIdCao;
        }

        public int ContarCachorros()
        {
            int quantidade = new int();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT COUNT(*) FROM cachorro WHERE falecido = 0;";

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

        public List<CachorroDoacao> ListaCachorroDoacao()
        {
            List<CachorroDoacao> lista = new List<CachorroDoacao>();
            CachorroDoacao cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorroDoacao where falecido=false;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new CachorroDoacao();
                cachorro.Dono = new Pessoa();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public Pessoa VoltaDono(int id)
        {
            List<CachorroDoacao> lista = new List<CachorroDoacao>();
            Pessoa pessoa = new Pessoa();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT p.nome, p.cpf, p.endereco, p.cep, p.numero, p.complemento, p.bairro, p.cidade, p.telefone, p.celular, p.email, p.interesse, p.porteInteresse, p.semInteresse, p.dataRegistro FROM pessoa p WHERE cpf = (SELECT cpf FROM cachorroDoacao c WHERE c.idCao = "+id+");";

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

        public List<Cachorro> ListaFalecidos()
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorro where falecido=true;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<CachorroDoacao> ListaCachorroDoacaoCPF(Pessoa p)
        {
            List<CachorroDoacao> lista = new List<CachorroDoacao>();
            CachorroDoacao cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorrodoacao where cpfDono = '"+p.Cpf+"';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new CachorroDoacao();
                cachorro.Dono = new Pessoa();
                
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }



        public List<Cachorro> ListaTodos()
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorro;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<Cachorro> ListaPorId(int id)
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorro WHERE idCao = "+id+";";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<Cachorro> ListaTodosDisponiveis()
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT c.nomeCao, c.raca, c.sexo, c.idade, c.cor, c.bairro, c.porte, c.vacinado, c.observacao, c.idCao, c.dataRegistro, c.falecido FROM cachorro c LEFT JOIN adocao a ON c.idCao = a.idCao WHERE a.idCao IS NULL;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<Cachorro> ListaTodosDisponiveisExternos()
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT c.nomeCao, c.raca, c.sexo, c.idade, c.cor, c.bairro, c.porte, c.vacinado, c.observacao, c.idCao, c.dataRegistro, c.falecido FROM cachorroDoacao c LEFT JOIN adocao a ON c.idCao = a.idCao WHERE a.idCao IS NULL;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<Cachorro> ListaGenero(char genero)
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorro WHERE sexo = '" + genero + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<Cachorro> ListaRaca(string raca)
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorro WHERE raca = '" + raca + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<Cachorro> ListaPorte(string porte)
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorro WHERE porte = '" + porte + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<Cachorro> ListaPorteDisponiveis(string porte)
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT c.nomeCao, c.raca, c.sexo, c.idade, c.cor, c.bairro, c.porte, c.vacinado, c.observacao, c.idCao, c.dataRegistro, c.falecido FROM cachorro c LEFT OUTER JOIN adocao a on a.idCao = c.idCao WHERE porte = '" + porte + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<Cachorro> ListaGeneroRaca(char genero, string raca)
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorro WHERE sexo = '" + genero + "' AND raca = '" + raca + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }

        public List<Cachorro> ListaGeneroPorte(char genero, string porte)
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorro WHERE sexo = '" + genero + "' AND porte = '" + porte + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }
        public List<Cachorro> ListaPesquisa(string pesquisa)
        {
            List<Cachorro> lista = new List<Cachorro>();
            Cachorro cachorro;

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nomeCao, raca, sexo, idade, cor, bairro, porte, vacinado, observacao, idCao, dataRegistro, falecido FROM cachorro WHERE nomeCao LIKE '%"+pesquisa+"%' OR bairro LIKE '%"+pesquisa+ "%' OR raca LIKE '%" + pesquisa + "%';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cachorro = new Cachorro();
                cachorro.NomeCao = dr.GetString("nomeCao");
                cachorro.Raca = dr.GetString("raca");
                cachorro.Sexo = dr.GetChar("sexo");
                cachorro.Idade = dr.GetString("idade");
                cachorro.Cor = dr.GetString("cor");
                cachorro.Bairro = dr.GetString("bairro");
                cachorro.Porte = dr.GetString("porte");
                cachorro.Vacinado = dr.GetBoolean("vacinado");
                cachorro.Observacao = dr.GetString("observacao");
                cachorro.IdCao = dr.GetInt32("idCao");
                cachorro.DataRegistro = dr.GetDateTime("dataRegistro");
                cachorro.Falecido = dr.GetBoolean("falecido");
                lista.Add(cachorro);
            }
            conexao.Close();
            return lista;
        }
    }
}
