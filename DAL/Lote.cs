using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Lote
    {
        #region CRUD
        //C
        public bool cadastraLote(Lotes lote) 
        {
            try 
            {
                using (PadariaBDEntities Padaria = new PadariaBDEntities()) 
                {
                    Padaria.Lotes.Add(lote);
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
        public Lotes buscaLote(string codigo) 
        {
            Lotes LoteRetornado = null;
            using (var Padaria = new PadariaBDEntities())
            {
                LoteRetornado = Padaria.Lotes.FirstOrDefault(lotes => lotes.Codigo == codigo);
            }
            return LoteRetornado; 
        }
        public List<string> listaLotes(int idProduto) 
        {
            List<string> listaDeLotes = new List<string>();
            using (PadariaBDEntities Padaria = new PadariaBDEntities()) 
            {
                listaDeLotes.AddRange(from lotes in Padaria.Lotes where lotes.Produto == idProduto select lotes.Codigo);
            }
            return listaDeLotes;
        }
        //U
        public bool atualizaLote(Lotes lote) 
        {
            try
            {
                using (PadariaBDEntities Padaria = new PadariaBDEntities())
                {
                    Lotes LoteAtualizado = Padaria.Lotes.Single(lotes => lotes.Id == lote.Id);
                    LoteAtualizado.Codigo = lote.Codigo;
                    LoteAtualizado.Produto = lote.Produto;
                    LoteAtualizado.Validade = lote.Validade;
                    LoteAtualizado.Quantidade = lote.Quantidade;
                    LoteAtualizado.PrecoCusto = lote.PrecoCusto;
                    LoteAtualizado.Ativo = lote.Ativo;

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
        public bool deletaLote(int Id)
        {
            try 
            {
                using (PadariaBDEntities Padaria = new PadariaBDEntities()) 
                {
                    Lotes loteDeletado = Padaria.Lotes.Single(lote => lote.Id == Id);
                    Padaria.Lotes.Remove(loteDeletado);
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

        /// <summary>
        /// Retorna uma lista com os lotes que vao vencer em ate 72 hrs
        /// </summary>
        /// <returns></returns>
        public List<Lotes> LotesVencendo() 
        {
            using (PadariaBDEntities Padaria = new PadariaBDEntities()) 
            {
                List<Lotes> listaVencendo = new List<Lotes>();
                DateTime dataVencimentos = DateTime.Today.Subtract(new TimeSpan(3,0,0,0));
                var lista = Padaria.Lotes.Where(lote => lote.Validade > dataVencimentos);
                if (lista.Count() > 0)
                {
                    listaVencendo.AddRange(lista);
                    return listaVencendo;
                }
                else 
                {
                    listaVencendo = null;
                    return listaVencendo;
                }
            }
        }
    }
}
