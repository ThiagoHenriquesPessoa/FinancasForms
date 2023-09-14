using DataAccess.InterfaceRepository;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Domain.Business
{
    public class RendaBusiness
    {
        private readonly IRendaRepository _rendaRepository;

        public RendaBusiness(IRendaRepository rendaRepository)
        {
            _rendaRepository = rendaRepository;
        }

        public void InsertRenda(Renda renda)
        {
            _rendaRepository.InsertRenda(renda);
        }

        public double GetRendaTotal()
        {
            double valorTotal = 0;
            var listaValores = _rendaRepository.GetRendaAll();
            foreach (var valor in listaValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public List<Renda> GetListRendaTotal()
        {
            List<Renda> listRenda = _rendaRepository.GetListRendaTotal();
            return listRenda;
        }

        public List<Renda> GetAllRendaPorData(DateTime inicio, DateTime fim)
        {
            var listRenda = _rendaRepository.GetAllRendaPorData(inicio, fim);
            return listRenda;
        }

        public double GetRendaAnoAtualall()
        {
            double valorTotal = 0;
            var listaValores = _rendaRepository.GetRendaAnoAtualall();
            foreach (var valor in listaValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public double GetRendaMesAtualAll()
        {
            double valorTotal = 0;
            var listaValores = _rendaRepository.GetRendaMesAtualAll();
            foreach (var valor in listaValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public void UpdateRenda(Renda renda)
        {
            _rendaRepository.UpdateRenda(renda);
        }

        public void DeleteRenda(Int64 idRenda)
        {
            _rendaRepository.DeleteRenda(idRenda);
        }
    }
}
