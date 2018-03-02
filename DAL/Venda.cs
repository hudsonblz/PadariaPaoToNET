using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Venda
    {
        #region CRUD
        //C
        /// <summary>
        /// Regista uma venda completa(ajusta estoque e cria os itens de venda)
        /// </summary>
        /// <param name="Carrinho"></param>
        /// <param name="IdCliente"></param>
        /// <param name="IdUsuario"></param>
        /// <param name="Pagamento"></param>
        /// <returns></returns>
        public bool CadastraVenda(List<ItensVendas> Carrinho, int IdCliente, int IdUsuario, string Pagamento) 
        {
            try 
            {
                using(PadariaBDEntities Padaria = new PadariaBDEntities())
                {
                    //gera a venda
                    Vendas venda = new Vendas 
                    {
                        Vendedor = IdUsuario,
                        Cliente = IdCliente,
                        DataVenda = DateTime.Now,
                        Pagamento = Pagamento
                    };
                    Padaria.Vendas.Add(venda);
                    //gera os itens da venda e os abate no estoque
                    foreach (ItensVendas item in Carrinho) 
                    {
                        //gera o itemVenda
                        Padaria.ItensVendas.Add(new ItensVendas {
                            Venda = venda.Id,
                            Produto = item.Produto,
                            Quantidade = item.Quantidade,
                            Subtotal = item.Subtotal,
                        });
                        //abate no estoque
                        var loteAtivo = Padaria.Lotes.Where(lotes => lotes.Produto == item.Produto && lotes.Ativo).SingleOrDefault();
                        loteAtivo.Quantidade = loteAtivo.Quantidade - item.Quantidade;
                    }
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
