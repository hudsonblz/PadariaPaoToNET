using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Reflection;

namespace DAL
{
    public class Usuario
    {
        #region CRUD
        /// <summary>
        /// Insere um usuario no banco de dados
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool CadastraUsuario(Usuarios usuario)
        {
            try
            {
                using (var Padaria = new PadariaBDEntities())
                {
                    Padaria.Usuarios.Add(usuario);
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
        /// Busca um usuario no banco de dados a partir do CPF informado
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public Usuarios BuscaUsuarioCPF(string cpf)
        {
            Usuarios UsuarioRetornado;
            using (var Padaria = new PadariaBDEntities())
            {
                UsuarioRetornado = Padaria.Usuarios.FirstOrDefault(usuario => usuario.Cpf == cpf);
            }
            return UsuarioRetornado;
        }
        /// <summary>
        /// Busca um usuario no banco de dados a partir do nome informado
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public Usuarios BuscaUsuarioNome(string nome)
        {
            Usuarios UsuarioRetornado;
            using (var Padaria = new PadariaBDEntities())
            {
                UsuarioRetornado = Padaria.Usuarios.FirstOrDefault(usuario => usuario.Nome == nome);
            }
            return UsuarioRetornado;
        }
        /// <summary>
        /// Retorna uma lista com todos os numeros de CPF dos usuarios cadastrados no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaCpf()
        {
            List<string> ListaDeCpf = new List<string>();
            using (var Padaria = new PadariaBDEntities())
            {
                var Consulta = from usuario in Padaria.Usuarios select usuario.Cpf;
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
        /// Retorna uma lista com todos os nomes dos usuarios cadastrados no banco de dados
        /// </summary>
        /// <returns></returns>
        public List<string> ListaNomes()
        {
            List<string> ListaDeNomes = new List<string>();
            using (var Padaria = new PadariaBDEntities())
            {
                var Consulta = from usuario in Padaria.Usuarios select usuario.Nome;
                if (Consulta != null)
                {
                    foreach (string nome in Consulta)
                    {
                        ListaDeNomes.Add(nome);
                    }
                }
                else
                {
                    ListaDeNomes = null;
                }
            }
            return ListaDeNomes;
        }
        //U
        /// <summary>
        /// Atualiza os dados de um usuario no banco de dados
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool AtualizaUsuarios(Usuarios usuario)
        {
            try
            {
                using (var Padaria = new PadariaBDEntities())
                {
                    Usuarios UsuarioAtualizado = Padaria.Usuarios.Single(c => c.Id == usuario.Id);

                    UsuarioAtualizado.Nome = usuario.Nome;
                    UsuarioAtualizado.Cpf = usuario.Cpf;
                    UsuarioAtualizado.Login = usuario.Login;
                    UsuarioAtualizado.Senha = usuario.Senha;
                    UsuarioAtualizado.Acesso = usuario.Acesso;

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
        /// Deleta o usuario no banco de dados a partir de um Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeletaUsuario(int Id)
        {
            try
            {
                using (var Padaria = new PadariaBDEntities())
                {
                    Usuarios UsuarioDeletado = Padaria.Usuarios.Single(usuario => usuario.Id == Id);
                    Padaria.Usuarios.Remove(UsuarioDeletado);
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

       /* private bool executaComando()
        {
            string localBD = PegaCaminhoBD();
            using (SqlCeConnection conexao = new SqlCeConnection("Data Source="+localBD))
            {
                SqlCeCommand comando;
                conexao.Open();
                comando.Connection = conexao;
                if (comando.ExecuteNonQuery() > 0) 
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }*/

        public Usuarios VerificaLogin(string usuario, string senha)
        {
            string localBD = PegaCaminhoBD();
            Usuarios ListaDeUsuarios = null;
            using (SqlCeConnection conexao = new SqlCeConnection("Data Source=" + localBD))
            {
                SqlCeCommand comando = new SqlCeCommand("SELECT * FROM Usuarios WHERE Login = @login AND Senha = @senha");
                comando.Parameters.AddWithValue("login", usuario);
                comando.Parameters.AddWithValue("senha", senha);

                conexao.Open();
                comando.Connection = conexao;
                SqlCeDataReader leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    ListaDeUsuarios = new Usuarios{
                        Id = (int)leitor.GetValue(0),
                        Nome = leitor.GetValue(1).ToString(),
                        Cpf = leitor.GetValue(2).ToString(),
                        Login = leitor.GetValue(3).ToString(),
                        Senha = leitor.GetValue(4).ToString(),
                        Acesso = leitor.GetValue(5).ToString()
                    };
                }
                leitor.Close();
            }
            return ListaDeUsuarios;
        }
        private string PegaCaminhoBD() 
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string nome = assembly.Location;
            string[] listaPastas = nome.Split('\\');
            string caminho = "";
            for (int i = 0; i <= listaPastas.Count() - 5; i++)
            {
                caminho = caminho + listaPastas[i] + "\\";
            }
            caminho = caminho + "DAL\\Banco\\PadariaBD.sdf";

            return caminho;
        }
    }
}
