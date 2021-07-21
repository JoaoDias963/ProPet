using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo
{
    class CachorroDoacaoDAO
    {
        public void Criar(CachorroDoacao c)
        {
            Propet.Database db = Propet.Database.GetInstance();
            string qry = string.Format("INSERT INTO cachorro(cpfDono,nomeCao,raca,sexo,idade,cor,bairro,porte,vacinado,observacao,dataRegistro,falecido) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
            c.Dono.Cpf,c.NomeCao, c.Raca, c.Sexo, c.Idade, c.Cor, c.Bairro, c.Porte, c.Vacinado ? 1 : 0, c.Observacao, c.DataRegistro.ToString("yyyy-MM-dd"), c.Falecido ? 1 : 0);

            db.ExecuteSQL(qry);
        }
    }
}
