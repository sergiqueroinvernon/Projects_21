using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CesarWeb.Models;

namespace CesarWeb.Data
{
    public class CesarWebContext : DbContext
    {
        public CesarWebContext (DbContextOptions<CesarWebContext> options)
            : base(options)
        {
        }

        public DbSet<CesarWeb.Models.CesarNum> CesarNum { get; set; }
    }
}
