using MySql.Data.MySqlClient;
using Propet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class UsuarioDAO
    {
        public void Criar(Usuario u)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO usuario(nome,senha,administrador) VALUES('{0}','{1}','{2}')",
            u.Nome, u.Senha, u.Administrador ? 1 : 0);

            db.ExecuteSQL(qry);
        }

        public Boolean VerificaAdmin(string admin, string senha)
        {
            Usuario u = new Usuario();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, senha FROM usuario WHERE administrador = 1;";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                u.Nome = dr.GetString("nome");
                u.Senha = dr.GetString("senha");
            }
            conexao.Close();

            if (u.Senha == senha && u.Nome == admin)
                return true;
            else
                return false;
        }

        public Boolean VerificaUsuario(Usuario usuario)
        {
            Usuario u = new Usuario();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "SELECT nome, senha, administrador FROM usuario WHERE nome = '"+usuario.Nome+"' AND senha = '"+usuario.Senha+"';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                u.Nome = dr.GetString("nome");
                u.Senha = dr.GetString("senha");
                u.Administrador = dr.GetBoolean("administrador");
            }
            conexao.Close();

            if (u.Nome==usuario.Nome && u.Senha==usuario.Senha)
                return true;
            else
                return false;
        }

        public Boolean TrocaSenha(Usuario usuario)
        {
            Usuario u = new Usuario();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "UPDATE usuario SET senha = '1234' WHERE nome = '" + usuario.Nome + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                u.Nome = dr.GetString("nome");
                u.Senha = dr.GetString("senha");
                u.Administrador = dr.GetBoolean("administrador");
            }
            conexao.Close();

            if (u.Nome == usuario.Nome && u.Senha == usuario.Senha)
                return true;
            else
                return false;
        }

        public Boolean AlteraSenha(Usuario usuario)
        {
            Usuario u = new Usuario();

            MySqlConnection conexao = Database.GetInstance().GetConnection();

            string qry = "UPDATE usuario SET senha = '"+usuario.Senha+"' WHERE nome = '" + usuario.Nome + "';";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                u.Nome = dr.GetString("nome");
                u.Senha = dr.GetString("senha");
                u.Administrador = dr.GetBoolean("administrador");
            }
            conexao.Close();

            if (u.Nome == usuario.Nome && u.Senha == usuario.Senha)
                return true;
            else
                return false;
        }
    }
}
