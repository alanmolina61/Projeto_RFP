using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RFP_05_12.Models
{
    public class ProdutosContext : DbContext
    {
        public ProdutosContext (DbContextOptions<ProdutosContext> options)
            : base(options)
        {
        }

        public DbSet<RFP_05_12.Models.Produto> Produto { get; set; }
    }
}
