using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
 
namespace DAL
{
    public class Cliente
    {
        #region CRUD
        //C
        /// <summary>
        /// Insere um cliente no banco de dados
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool CadastraCliente(Clientes cliente)
        {
            try
            {
                using (var Padaria = new PadariaBDEntities())
                {
                    Padaria.Clientes.Add(cliente);
                    Padaria.SaveChanges();
                }
                return true;
            }


            catch (Exception e)
            {
                string erro = e.Message;
                return false;
            }
        }
        //R
        /// <summary>
        /// Busca um cliente no banco de dados a partir do CPF informado
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public Clientes BuscaClientesCPF(string cpf)
        {
            Clientes ClienteRetornado;
            using (var Padaria = new PadariaBDEntities())
            {                
                ClienteRetornado = Padaria.Clientes.FirstOrDefault(cliente => cliente.Cpf == cpf);                     
            }
            return ClienteRetornado;
        }
        /// <summary>
        /// Busca um cliente no banco de dados a partir do nome informado
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public Clientes BuscaClientesNome(string nome)
        {
            Clientes ClienteRetornado;
            using (var Padaria = new PadariaBDEntities())
            {
                ClienteRetornado = Padaria.Clientes.FirstOrDefault(cliente => cliente.Nome == nome);
            }
            return ClienteRetornado;
        }
        /// <summary>
        /// Retorna uma lista com todos os numeros de CPF dos clientes cadastrados no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaCpf() 
        {
            List<string> ListaDeCpf = new List<string>();
            using(var Padaria = new PadariaBDEntities())
            {   
                var Consulta = from cliente in Padaria.Clientes select cliente.Cpf;
                if (Consulta != null)
                {
                    foreach (string cpf in Consulta)
                    {
                        ListaDeCpf.Add(cpf);
                    }
                }
                else
                {
                    ListaDeCpf = null;
                }
            }
            return ListaDeCpf;
        }
        /// <summary>
        /// Retorna uma lista com todos os nomes dos clientes cadastrados no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaNomes() 
        {
            List<string> ListaDeNomes = new List<string>();
            using (var Padaria = new PadariaBDEntities())
            {
                var Consulta = from cliente in Padaria.Clientes select cliente.Nome;
                foreach (string nome in Consulta)
                {
                    ListaDeNomes.Add(nome);
                }
            }
            return ListaDeNomes;
        }
        //U
        /// <summary>
        /// Atualiza os dados de um cliente no banco de dados
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool AtualizaCliente(Clientes cliente)
        {
            try
            {
                using (var Padaria = new PadariaBDEntities())
                {
                    Clientes ClienteAtualizado = Padaria.Clientes.Single(c => c.Id == cliente.Id);
                    
                    ClienteAtualizado.Nome = cliente.Nome;
                    ClienteAtualizado.Cpf = cliente.Cpf;
                    ClienteAtualizado.Cidade = cliente.Cidade;
                    ClienteAtualizado.Bairro = cliente.Bairro;
                    ClienteAtualizado.Endereco = cliente.Endereco;

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
        /// <summary>
        /// Deleta o cliente no banco de dados a apartir do Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeletaCliente(int Id)
        {
            try
            {
                using (var Padaria = new PadariaBDEntities())
                {
                    Clientes ClienteDeletado = Padaria.Clientes.Single(c => c.Id == Id);
                    Padaria.Clientes.Remove(ClienteDeletado);
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
