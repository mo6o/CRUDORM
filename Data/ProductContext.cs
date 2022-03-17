﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace minecraft.Data.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=products;user=root;password=Root;port3306");
        }
        public DbSet<Product> Products { get; set; }
    }
}

       