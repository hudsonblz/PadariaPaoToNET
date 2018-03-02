using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace DAL
{
    public class Produto
    {
        #region CRUD
        //C
        public bool CadastraProduto(Produtos produto) 
        {
            try 
            {
                using (PadariaBDEntities Padaria = new PadariaBDEntities())
                {
                    Padaria.Produtos.Add(produto);
                    Padaria.SaveChanges();
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
        //R
        /// <summary>
        /// Busca um produto no banco de dados a partir do codigo informado
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Produtos BuscaProdutosCodigo(string cod)
        {
            Produtos ProdutoRetornado;
            using (var Padaria = new PadariaBDEntities())
            {
                ProdutoRetornado = Padaria.Produtos.FirstOrDefault(produto => produto.Codigo == cod);
            }
            return ProdutoRetornado;
        }
        /// <summary>
        /// Busca um produto no banco de dados a partir do nome informado
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Produtos BuscaProdutosId(int Id)
        {
            Produtos ProdutoRetornado = null;
            using (var Padaria = new PadariaBDEntities())
            {
                ProdutoRetornado = Padaria.Produtos.FirstOrDefault(produto => produto.Id == Id);
            }
            return ProdutoRetornado;
        }
        /// <summary>
        /// Busca um produto no banco de dados a partir do nome informado
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Produtos BuscaProdutosNome(string nome)
        {
            Produtos ProdutoRetornado = null;
            using (var Padaria = new PadariaBDEntities())
            {
                ProdutoRetornado = Padaria.Produtos.FirstOrDefault(produto => produto.Nome == nome);
            }
            return ProdutoRetornado;
        }
        /// <summary>
        /// Retorna uma lista com todos os codigos de produtos cadastrados no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaCodigo() 
        {
            List<string> ListaDeCodigos = new List<string>();
            using (PadariaBDEntities Padaria = new PadariaBDEntities()) 
            {
                ListaDeCodigos.AddRange(from produtos in Padaria.Produtos select produtos.Codigo);
            }
            return ListaDeCodigos;
        }
        /// <summary>
        /// Retorna uma lista com todos os nomes de produtos cadastrados no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaNome()
        {
            List<string> ListaDeCodigos = new List<string>();
            using (PadariaBDEntities Padaria = new PadariaBDEntities())
            {
                ListaDeCodigos.AddRange(from produtos in Padaria.Produtos select produtos.Nome);
            }
            return ListaDeCodigos;
        }
        /// <summary>
        /// Retorna uma lista com todos os codigos de produtos ativos cadastrados no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaCodigoAtivo()
        {
            List<string> ListaDeCodigos = new List<string>();
            using (PadariaBDEntities Padaria = new PadariaBDEntities())
            {
                ListaDeCodigos.AddRange(from produtos in Padaria.Produtos.Where(produto => produto.Ativo) select produtos.Codigo);
            }
            return ListaDeCodigos;
        }
        /// <summary>
        /// Retorna uma lista com todos os nomes de produtos ativos cadastrados no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaNomeAtivo()
        {
            List<string> ListaDeCodigos = new List<string>();
            using (PadariaBDEntities Padaria = new PadariaBDEntities())
            {
                ListaDeCodigos.AddRange(from produtos in Padaria.Produtos.Where(produto => produto.Ativo) select produtos.Nome);
            }
            return ListaDeCodigos;
        }
        //U
        public bool AlteraProduto(Produtos produto) 
        {
            try
            {
                using (PadariaBDEntities Padaria = new PadariaBDEntities())
                {
                    Produtos ProdutoAtualizar = Padaria.Produtos.Single(prod => prod.Id == produto.Id);
                    ProdutoAtualizar.Codigo = produto.Codigo;
                    ProdutoAtualizar.Nome = produto.Nome;
                    ProdutoAtualizar.PrecoVenda = produto.PrecoVenda;
                    ProdutoAtualizar.Unidade = produto.Unidade;
                    ProdutoAtualizar.Ativo = produto.Ativo;

                    Padaria.SaveChanges();
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
        //D
        public bool DeletarUsuario(int Id) 
        {
            try 
            {
                using (PadariaBDEntities Padaria = new PadariaBDEntities()) 
                {
                    Produtos ProdutoDeletado = Padaria.Produtos.Single(produto => produto.Id == Id);
                    Padaria.Produtos.Remove(ProdutoDeletado);
                    Padaria.SaveChanges();
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
        #endregion
    }
}
