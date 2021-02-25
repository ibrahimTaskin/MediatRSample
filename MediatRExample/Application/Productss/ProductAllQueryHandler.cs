using MediatR;
using MediatRExample.Domain;
using MediatRExample.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Application.Productss
{
    public class ProductAllQueryHandler : IRequestHandler<ProductsAllQuery, List<Product>>
    {
        private MediatrContext _context;

        public ProductAllQueryHandler(MediatrContext context) => _context = context;

        public async Task<List<Product>> Handle(ProductsAllQuery request, CancellationToken cancellationToken)
        {
            return await this._context.Products.ToListAsync();
        }
    }
}
