using DataAccess.InterfaceRepository;
using System;
using Dapper;
using Infraestrutura;
using System.Linq;
using Entidades.Models;

namespace DataAccess.Repository
{
    public class UsuarioRepositoy : IUsuarioRepositoy
    {
        public int InsertUsuario(Usuario usuario)
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var parameter = new
                    {
                        Email = usuario.Email,
                        Nome = usuario.Nome,
                        Senha = usuario.Senha
                    };
                    var sql = "Insert into Usuario (Email, Nome, Senha) values (@Email, @Nome, @Senha)";
                    connection.Query(sql, parameter);
                    return 1;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool GetListUsuario(Usuario usuario)
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var parameter = new
                    {
                        Email = usuario.Email,
                        Senha = usuario.Senha
                    };

                    string query = "SELECT * FROM Usuario where Email = @Email and Senha = @Senha";
                    var result = connection.Query<Usuario>(query, parameter).Any();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
