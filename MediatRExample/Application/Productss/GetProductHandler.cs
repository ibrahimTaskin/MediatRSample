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
    public class GetProductHandler : IRequestHandler<GetProductQuery, Product>
    {
        private MediatrContext _context;

        public GetProductHandler(MediatrContext context) => _context = context;

        public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await this._context.Products.SingleOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}
