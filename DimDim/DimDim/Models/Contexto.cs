﻿using Microsoft.EntityFrameworkCore;
using DimDim.Models;

namespace DimDim.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
            {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DimDim.Models.Conta>? Conta { get; set; }
    }
}
