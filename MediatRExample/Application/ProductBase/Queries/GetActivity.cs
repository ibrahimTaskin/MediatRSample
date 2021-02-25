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
    public class GetActivity
    {
        public class Query : IRequest<Product>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Product>
        {
            private readonly MediatrContext _context;

            public Handler(MediatrContext context)
            {
                _context = context;
            }

            public async Task<Product> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Products.FindAsync(request.Id);
            }
        }
    }
}
