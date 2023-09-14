using Dapper;
using DataAccess.InterfaceRepository;
using Entidades.Models;
using Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class RendaRepository : IRendaRepository
    {
        public void InsertRenda(Renda renda)
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var parameter = new
                    {
                        dblValorRenda = renda.dblValorRenda,
                        txtTipoRenda = renda.txtTipoRenda,
                        dteDataEntrada = renda.dteDataEntrada
                    };
                    var sql = "INSERT INTO [Renda] VALUES  (@dblValorRenda, @txtTipoRenda, @dteDataEntrada);";
                    connection.Query(sql, parameter);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<double> GetRendaAll()
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var ListaValores = connection.Query<double>("SELECT dblValorRenda FROM [Renda];").ToList();
                    return ListaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Renda> GetListRendaTotal()
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var ListaValores = connection.Query<Renda>("SELECT * FROM [Renda];").ToList();
                    return ListaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Renda> GetAllRendaPorData(DateTime inicail, DateTime fim)
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var parameter = new
                    {
                        param0 = Convert.ToDateTime(inicail.ToString("yyyy-MM-dd 00:00:00")),
                        param1 = Convert.ToDateTime(fim.ToString("yyyy-MM-dd 23:59:00"))
                    };
                    var sql = "SELECT * FROM [Renda] WHERE dteDataEntrada >= @param0 and dteDataEntrada < @param1;";
                    var ListaRenda = connection.Query<Renda>(sql, parameter).ToList();
                    return ListaRenda;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<double> GetRendaAnoAtualall()
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var parameter = new
                    {
                        param0 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-01-01 00:00:00"),
                        param1 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-12-31 23:59:59")
                    };
                    var sql = "SELECT dblValorRenda FROM [Renda] WHERE dteDataEntrada > @param0 and dteDataEntrada < @param1;";
                    var ListaValores = connection.Query<double>(sql, parameter).ToList();
                    return ListaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<double> GetRendaMesAtualAll()
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var parameter = new
                    {
                        param0 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-" + DateTime.Now.Date.Month.ToString() + "-01 00:00:00"),
                        param1 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-" + DateTime.Now.Date.AddMonths(1).Month + "-01 00:00:00")
                    };
                    var sql = "SELECT dblValorRenda FROM [Renda] WHERE dteDataEntrada >= @param0 and dteDataEntrada < @param1;";
                    var ListaValores = connection.Query<double>(sql, parameter).ToList();
                    return ListaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateRenda(Renda renda)
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var parameter = new
                    {
                        IdRenda = renda.IdRenda,
                        ValorRenda = renda.dblValorRenda,
                        TipoRenda = renda.txtTipoRenda,
                        DataEntrada = renda.dteDataEntrada
                    };
                    var sql = "UPDATE [Renda] SET [dblValorRenda] = @dblValorRenda, [txtTipoRenda] = @txtTipoRenda, [dteDataEntrada] = @dteDataEntrada WHERE [IdRenda] == @IdRenda;";
                    connection.Query(sql, parameter);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteRenda(Int64 idRenda)
        {
            try
            {
                using (var connection = DbConection.DbConnection())
                {
                    var parameter = new
                    {
                        IdRenda = idRenda
                    };
                    var sql = "DELETE FROM [Renda] WHERE [IdRenda] == @IdRenda;";
                    connection.Query(sql, parameter);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
