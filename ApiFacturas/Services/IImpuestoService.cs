using ApiFacturas.Models;
using System.Collections.Generic;

namespace ApiFacturas.Services
{
    interface IImpuestoService
    {
        public void AddImpuesto(Impuesto impuesto);
        public void DeleteImpuesto(int id);
        public void DeleteImpuesto(Impuesto impuesto);
        public List<Impuesto> GetImpuestos();
        public Impuesto GetImpuesto(int id);
        public Impuesto UpdateImpuesto(Impuesto impuesto);
    }
}
