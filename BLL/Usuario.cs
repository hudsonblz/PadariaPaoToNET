using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Usuario
    {
        public static int UsuarioLogado { get; private set; }
        private DAL.Usuario OperadorDAL = new DAL.Usuario();

        #region CRUD
        //C
        public bool CadastraUsuarios(Model.Usuario usuario)
        {
            Usuarios novoUsuario = new Usuarios
            {
                Nome = usuario.Nome.ToUpper(),
                Cpf = usuario.Cpf.Replace(".", "").Replace("-", ""),
                Login = usuario.Login,
                Senha = usuario.Senha,
                Acesso = usuario.Acesso.ToUpper()
            };

            if (OperadorDAL.CadastraUsuario(novoUsuario))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //R
        public Model.Usuario BuscaUsuarioCpf(string Cpf)
        {
            Model.Usuario usuarioRetornadoBLL;
            DAL.Usuarios usuarioRetornadoDAL = OperadorDAL.BuscaUsuarioCPF(Cpf);
            if (usuarioRetornadoDAL != null)
            {
                usuarioRetornadoBLL = new Model.Usuario
                {
                    Id = usuarioRetornadoDAL.Id,
                    Nome = usuarioRetornadoDAL.Nome,
                    Cpf = usuarioRetornadoDAL.Cpf,
                    Login = usuarioRetornadoDAL.Login,
                    Senha = usuarioRetornadoDAL.Senha,
                    Acesso = usuarioRetornadoDAL.Acesso.ToUpper()
                };

                return usuarioRetornadoBLL;
            }
            else
            {
                return null;
            }
        }
        public Model.Usuario BuscaUsuarioNome(string nome)
        {
            Model.Usuario usuarioRetornadoBLL;
            DAL.Usuarios usuarioRetornadoDAL = OperadorDAL.BuscaUsuarioNome(nome);
            if (usuarioRetornadoDAL != null)
            {
                usuarioRetornadoBLL = new Model.Usuario
                {
                    Id = usuarioRetornadoDAL.Id,
                    Nome = usuarioRetornadoDAL.Nome,
                    Cpf = usuarioRetornadoDAL.Cpf,
                    Login = usuarioRetornadoDAL.Login,
                    Senha = usuarioRetornadoDAL.Senha,
                    Acesso = usuarioRetornadoDAL.Acesso.ToUpper(),
                };

                return usuarioRetornadoBLL;
            }
            else
            {
                return null;
            }
        }
        public List<string> ListaUsuarioCpf()
        {
            return OperadorDAL.ListaCpf();
        }
        public List<string> ListaUsuarioNome()
        {
            return OperadorDAL.ListaNomes();
        }
        //U
        public bool AlteraUsuario(Model.Usuario usuarios)
        {
            DAL.Usuarios usuarioAlterado = new DAL.Usuarios
            {
                Id = usuarios.Id,
                Nome = usuarios.Nome.ToUpper(),
                Cpf = usuarios.Cpf.Replace(".", "").Replace("-", ""),
                Login = usuarios.Login,
                Senha = usuarios.Senha,
                Acesso = usuarios.Acesso.ToUpper()
            };
            if (OperadorDAL.AtualizaUsuarios(usuarioAlterado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //D
        public bool DeletaUsuario(int Id)
        {
            if (OperadorDAL.DeletaUsuario(Id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        public Model.Usuario VerificaLogin(string login, string senha) 
        {
            Usuarios retornoDAL = OperadorDAL.VerificaLogin(login, senha); 
            if(retornoDAL != null)
            {
                return new Model.Usuario 
                { 
                    Id = retornoDAL.Id,
                    Nome = retornoDAL.Nome,
                    Cpf = retornoDAL.Cpf,
                    Login = retornoDAL.Login,
                    Senha = retornoDAL.Senha,
                    Acesso = retornoDAL.Acesso,                
                };
                UsuarioLogado = retornoDAL.Id;
            }
            else
            {
                return null;
            }
        }
            
    }
}
