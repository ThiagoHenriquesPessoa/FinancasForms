using Entidades.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.InterfaceRepository
{
    public interface IRendaRepository
    {
        void InsertRenda(Renda renda);

        List<double> GetRendaAll();

        List<Renda> GetListRendaTotal();

        List<Renda> GetAllRendaPorData(DateTime inicail, DateTime fim);

        List<double> GetRendaAnoAtualall();

        List<double> GetRendaMesAtualAll();

        void UpdateRenda(Renda renda);

        void DeleteRenda(Int64 idRenda);
    }
}
