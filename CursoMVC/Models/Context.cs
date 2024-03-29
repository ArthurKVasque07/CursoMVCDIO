﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(http://127.0.0.1:56431/browser/#)\pgAdmin 4 - DB:CursoMVC;DataBase=CursoMVC; Biodiversidade=True");
        }

        public void SetModified(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
