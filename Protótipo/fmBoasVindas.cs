using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protótipo
{
    public partial class fmBoasVindas : Form
    {
        public fmBoasVindas()
        {
            InitializeComponent();
        }

        private void fmBoasVindas_Load(object sender, EventArgs e)
        {
            CachorroDAO cachorroDAO = new CachorroDAO();
            lbTotalCachorros.Text = "Cachorros cadastrados: "+ cachorroDAO.ContarCachorros();

            AdocaoDAO adocaoDAO = new Protótipo.AdocaoDAO();
            lbTotalAdocao.Text = "Adoções feitas: " + adocaoDAO.ContarAdocao();

            ProdutoDAO produtoDAO = new ProdutoDAO();
            List<Produto> listaProduto = produtoDAO.ListaTodos();

            EstoqueDAO estoqueDAO = new Protótipo.EstoqueDAO();

            List<Estoque> listaEstoque = estoqueDAO.ListaTodos();

            foreach (Produto prod in listaProduto)
            {
                if (prod.Categoria== "Ração para Porte Mini")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, Math.Round(estoqueDAO.ListaSoma(prod) / ((0.047) * (cachorroDAO.SomaPorte(prod)))) + " dias");
                if (prod.Categoria == "Ração para Porte Pequeno")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, Math.Round(estoqueDAO.ListaSoma(prod) / ((0.102) * (cachorroDAO.SomaPorte(prod)))) + " dias");
                if (prod.Categoria == "Ração para Porte Pequeno/Médio")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, Math.Round(estoqueDAO.ListaSoma(prod) / ((0.169) * (cachorroDAO.SomaPorte(prod)))) + " dias");
                if (prod.Categoria == "Ração para Porte Médio")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, Math.Round(estoqueDAO.ListaSoma(prod) / ((0.251) * (cachorroDAO.SomaPorte(prod)))) + " dias");
                if (prod.Categoria == "Ração para Porte Grande")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, Math.Round(estoqueDAO.ListaSoma(prod) / ((0.345) * (cachorroDAO.SomaPorte(prod)))) + " dias");
                if (prod.Categoria == "Ração para Porte Gigante")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, Math.Round(estoqueDAO.ListaSoma(prod) / ((0.397) * (cachorroDAO.SomaPorte(prod)))) + " dias");
                if (prod.Categoria == "Shampoo")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, Math.Round(estoqueDAO.ListaSoma(prod) / (0.8)) + " banhos");
                if (prod.Categoria == "Vacina V8")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, estoqueDAO.ListaSoma(prod) + " vacinas");
                if (prod.Categoria == "Vacina V10")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, estoqueDAO.ListaSoma(prod) + " vacinas");
                if (prod.Categoria == "Vacina Anti-Rábica")
                    dgvPrevisao.Rows.Add(prod.Nome, prod.Categoria, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, estoqueDAO.ListaSoma(prod) + " vacinas");
                if (prod.Categoria == "Vacina Leishmaniose")
                    dgvPrevisao.Rows.Add(prod.Nome, estoqueDAO.ListaSoma(prod) + " " + prod.UnidadeMedida, estoqueDAO.ListaSoma(prod) + " vacinas");
            }
        }
    }
}
