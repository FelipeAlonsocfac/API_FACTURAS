﻿using ApiFacturas.Models;
using ApiFacturas.Request;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas.MapperProfiles
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<ProductoRequest, Producto>();
        }
    }
}
