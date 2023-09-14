using Entidades.Models;

namespace DataAccess.InterfaceRepository
{
    public interface IUsuarioRepositoy
    {
        int InsertUsuario(Usuario usuario);
        bool GetListUsuario(Usuario usuario);
    }
}
