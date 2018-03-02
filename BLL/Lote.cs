using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Lote
    {
        private DAL.Lote OperadorLoteDAL = new DAL.Lote();
        private DAL.Produto OperadorProdutoDAL = new DAL.Produto();
        //C
        public bool cadastraLote(Model.Lote lote) 
        {
            DAL.Lotes novoLote = new DAL.Lotes
            {
                Codigo = lote.Codigo.ToUpper(),
                Produto = OperadorProdutoDAL.BuscaProdutosNome(lote.Produto).Id,
                Validade = lote.Validade,
                Quantidade = lote.Quantidade,
                PrecoCusto = lote.PrecoCusto,
                Ativo = lote.Ativo
            };
            if (OperadorLoteDAL.cadastraLote(novoLote)) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        //R
        public Model.Lote BuscaLote(string codigo) 
        {
            DAL.Lotes LoteRetornadoDAL = OperadorLoteDAL.buscaLote(codigo);
            Model.Lote LoteRetornadoBLL = new Model.Lote 
            {
                Id = LoteRetornadoDAL.Id,
                Codigo = LoteRetornadoDAL.Codigo,
                Produto = OperadorProdutoDAL.BuscaProdutosId(LoteRetornadoDAL.Produto).Nome,
                Validade = LoteRetornadoDAL.Validade,
                Quantidade = LoteRetornadoDAL.Quantidade,
                PrecoCusto = LoteRetornadoDAL.PrecoCusto,
                Ativo = LoteRetornadoDAL.Ativo
            };
            return LoteRetornadoBLL;
        }
        public List<string> ListaCodigos(string produto)
        {
            int idProduto = OperadorProdutoDAL.BuscaProdutosNome(produto).Id;
            return OperadorLoteDAL.listaLotes(idProduto);
        }
        //U
        public bool atualizaLote(Model.Lote lote)
        {
            DAL.Lotes LoteAtualizado = new DAL.Lotes
            {
                Id = lote.Id,
                Codigo = lote.Codigo.ToUpper(),
                Produto = OperadorProdutoDAL.BuscaProdutosNome(lote.Produto).Id,
                Validade = lote.Validade,
                Quantidade = lote.Quantidade,
                PrecoCusto = lote.PrecoCusto,
                Ativo = lote.Ativo
            };
            if (OperadorLoteDAL.atualizaLote(LoteAtualizado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //D
        public bool deletaLote(int Id) 
        {
            if (OperadorLoteDAL.deletaLote(Id)) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public List<Model.Lote> LotesVencidos() 
        {
            var LotesVencidosDAL = OperadorLoteDAL.LotesVencendo();
            List<Model.Lote> ListaDeLotes = new List<Model.Lote>();
            if (LotesVencidosDAL != null) 
            {
                foreach (var lotes in LotesVencidosDAL) 
                {
                    ListaDeLotes.Add(new Model.Lote 
                    {
                        Id = lotes.Id,
                        Codigo = lotes.Codigo,
                        Produto = OperadorProdutoDAL.BuscaProdutosId(lotes.Produto).Nome,
                        Validade = lotes.Validade,
                        Quantidade = lotes.Quantidade,
                        PrecoCusto = lotes.PrecoCusto,
                        Ativo = lotes.Ativo,
                    });
                }
                return ListaDeLotes;
            }
            else
            {
                return null;
            }
        }
    }
}
