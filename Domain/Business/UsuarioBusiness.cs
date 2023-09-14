using Entidades.Models;
using DataAccess.InterfaceRepository;

namespace Domain.Business
{
    public class UsuarioBusiness
    {
        private readonly IUsuarioRepositoy _usuarioRepositoy;

        public UsuarioBusiness(IUsuarioRepositoy usuarioRepositoy)
        {
            _usuarioRepositoy = usuarioRepositoy;
        }

        public int InsertUsuario(Usuario usuario)
        {
            return _usuarioRepositoy.InsertUsuario(usuario);
        }

        public bool GetListUsuario(Usuario usuario)
        {
            return _usuarioRepositoy.GetListUsuario(usuario);
        }
    }
}
