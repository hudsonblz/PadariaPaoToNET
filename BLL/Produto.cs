using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Produto
    {
        private DAL.Produto OperadorDAL = new DAL.Produto();

        #region CRUD
        //C
        public bool CadastraProduto(Model.Produto produto)
        {
            DAL.Produtos NovoProduto = new DAL.Produtos
            {
                Codigo = produto.Codigo,
                Nome = produto.Nome.ToUpper(),
                PrecoVenda = produto.PrecoVenda,
                Unidade = produto.Unidade.ToUpper(),
                Ativo = produto.Ativo
            };
            if (OperadorDAL.CadastraProduto(NovoProduto)) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        //R
        public Model.Produto BuscaProdutoId(int Id) 
        {
            DAL.Produtos retornoDAL = OperadorDAL.BuscaProdutosId(Id);
            Model.Produto produtoRetornado = new Model.Produto 
            {
                Id = retornoDAL.Id,
                Codigo = retornoDAL.Codigo,
                Nome = retornoDAL.Nome,
                PrecoVenda = retornoDAL.PrecoVenda,
                Unidade = retornoDAL.Unidade,
                Ativo = retornoDAL.Ativo
            };
            return produtoRetornado;
        }
        public Model.Produto BuscaProdutoCodigo(string codigo) 
        {
            DAL.Produtos retornoDAL = OperadorDAL.BuscaProdutosCodigo(codigo);
            Model.Produto produtoRetornado = new Model.Produto 
            {
                Id = retornoDAL.Id,
                Codigo = retornoDAL.Codigo,
                Nome = retornoDAL.Nome,
                PrecoVenda = retornoDAL.PrecoVenda,
                Unidade = retornoDAL.Unidade,
                Ativo = retornoDAL.Ativo
            };
            return produtoRetornado;
        }
        public Model.Produto BuscaProdutoNome(string nome)
        {
            DAL.Produtos retornoDAL = OperadorDAL.BuscaProdutosNome(nome.ToLower());
            Model.Produto produtoRetornado = new Model.Produto
            {
                Id = retornoDAL.Id,
                Codigo = retornoDAL.Codigo,
                Nome = retornoDAL.Nome,
                PrecoVenda = retornoDAL.PrecoVenda,
                Unidade = retornoDAL.Unidade,
                Ativo = retornoDAL.Ativo
            };
            return produtoRetornado;
        }
        public List<string> ListaCodigoAtivos() 
        {
            return OperadorDAL.ListaCodigoAtivo();
        }
        public List<string> ListaNomeAtivos()
        {
            return OperadorDAL.ListaNomeAtivo();
        }
        public List<string> ListaCodigos()
        {
            return OperadorDAL.ListaCodigo();
        }
        public List<string> ListaNome()
        {
            return OperadorDAL.ListaNome();
        }
        //U
        public bool AtualizarProduto(Model.Produto produto) 
        {
            DAL.Produtos produtoAtualizado = new DAL.Produtos
            {
                Id = produto.Id,
                Codigo = produto.Codigo,
                Nome = produto.Nome.ToUpper(),
                PrecoVenda = produto.PrecoVenda,
                Unidade = produto.Unidade.ToUpper(),
                Ativo = produto.Ativo
            };
            if (OperadorDAL.AlteraProduto(produtoAtualizado)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //D
        public bool DeletaProduto(int Id) 
        {
            if (OperadorDAL.DeletarUsuario(Id)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
