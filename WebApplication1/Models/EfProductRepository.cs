using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EfProductRepository : IProductRepository
    {
        private ApplicationDbContext context;


        public EfProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;

        }


        public IQueryable<Product> Products => context.Products;
    }
}
