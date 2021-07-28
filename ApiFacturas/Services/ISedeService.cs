﻿using ApiFacturas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFacturas.Services
{
    public interface ISedeService
    {
        Task AddSede(Sede sede);
        Task<Sede> GetId(int id);
        List<Sede> GetAll();
        void UpdateSede(Sede sede);
        Task DeleteSede(Sede sede);
        Task DeleteId(int id);
    }
}
