﻿using ApiFacturas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface IEmpresaService
    {
        Task AddEmpresa(Empresa empresa);
        Task<Empresa> GetId(int id);
        List<Empresa> GetAll();
        void UpdateEmpresa(Empresa empresa);
        Task DeleteEmpresa(Empresa empresa);
        Task DeleteId(int id);
    }
}
