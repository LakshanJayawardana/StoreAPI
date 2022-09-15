using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;

namespace StoreAPI.Data
{
    public class StoreAPIContext : DbContext
    {
        public StoreAPIContext (DbContextOptions<StoreAPIContext> options)
            : base(options)
        {
        }

        public DbSet<StoreAPI.Models.ProductDetail> ProductDetail { get; set; } = default!;
        public DbSet<StoreAPI.Models.LoginModel> LoginModels { get; set; } = default!;

        public DbSet<StoreAPI.Models.RegisterModel> RegisterModels { get; set; } = default!;    

    }
}
