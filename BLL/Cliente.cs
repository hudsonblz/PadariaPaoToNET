using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Cliente
    {
        private DAL.Cliente OperadorDAL = new DAL.Cliente();
        #region CRUD
        //C
        /// <summary>
        /// Transmorma o modelo cliente para o modelo de entidade e insere o cliente no banco de dados
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool CadastraClientes(Model.Cliente cliente)
        {
            Clientes novoCliente = new Clientes
            {
                Nome = cliente.Nome.ToUpper(),
                Cpf = cliente.Cpf.Replace(".", "").Replace("-", ""),
                Cidade = cliente.Cidade.ToUpper(),
                Bairro = cliente.Bairro.ToUpper(),
                Endereco = cliente.Endereco.ToUpper()
            };

            if (OperadorDAL.CadastraCliente(novoCliente))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //R
        /// <summary>
        /// Busca um cliente a partir do CPF informado
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public Model.Cliente BuscaClienteCpf(string Cpf) 
        {
            Model.Cliente clienteRetornadoBLL;
            DAL.Clientes clienteRetornadoDAL = OperadorDAL.BuscaClientesCPF(Cpf);
            if (clienteRetornadoDAL != null)
            {
                clienteRetornadoBLL = new Model.Cliente {
                    Id = clienteRetornadoDAL.Id,
                    Nome = clienteRetornadoDAL.Nome,
                    Cpf = clienteRetornadoDAL.Cpf,
                    Cidade = clienteRetornadoDAL.Cidade,
                    Bairro = clienteRetornadoDAL.Bairro,
                    Endereco = clienteRetornadoDAL.Endereco
                };

                return clienteRetornadoBLL;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Busca um cliente a partir do nome informado
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public Model.Cliente BuscaClienteNome(string nome)
        {
            Model.Cliente clienteRetornadoBLL;
            DAL.Clientes clienteRetornadoDAL = OperadorDAL.BuscaClientesNome(nome);
            if (clienteRetornadoDAL != null)
            {
                clienteRetornadoBLL = new Model.Cliente
                {
                    Id = clienteRetornadoDAL.Id,
                    Nome = clienteRetornadoDAL.Nome,
                    Cpf = clienteRetornadoDAL.Cpf,
                    Cidade = clienteRetornadoDAL.Cidade,
                    Bairro = clienteRetornadoDAL.Bairro,
                    Endereco = clienteRetornadoDAL.Endereco
                };

                return clienteRetornadoBLL;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Retorna uma lista com todos os numeros de CPF dos clientes cadastrados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaClienteCpf()
        {
            return OperadorDAL.ListaCpf();
        }
        /// <summary>
        /// Retorna uma lista com todos os nomes dos clientes cadastrados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaClienteNome()
        {
            return OperadorDAL.ListaNomes();
        }
        //U
        /// <summary>
        /// Atualiza os dados de um cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool AlteraCliente(Model.Cliente cliente) 
        {
            DAL.Clientes clienteAlterado = new DAL.Clientes
            {
                Id = cliente.Id,
                Nome = cliente.Nome.ToUpper(),
                Cpf = cliente.Cpf.Replace(".", "").Replace("-", ""),
                Cidade = cliente.Cidade.ToUpper(),
                Bairro = cliente.Bairro.ToUpper(),
                Endereco = cliente.Endereco.ToUpper()
            };
            if (OperadorDAL.AtualizaCliente(clienteAlterado)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //D
        /// <summary>
        /// Deleta o cliente a partir de um Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeletaCliente(int Id)
        {
            if (OperadorDAL.DeletaCliente(Id))
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
