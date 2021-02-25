using MediatR;
using MediatRExample.Domain;
using MediatRExample.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Application.ProductBase.Queries
{
    public class List 
    {
      public class Query : IRequest<List<Product>>
        {
        }

        public class Handler : IRequestHandler<Query, List<Product>>
        {

            private readonly MediatrContext _context;

            public Handler(MediatrContext context)
            {
                _context = context;
            }

            public async Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                var products=await _context.Products.ToListAsync();
                return products;
            }
        }
    }

   
}
