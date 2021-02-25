using MediatR;
using MediatRExample.Domain;
using MediatRExample.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Application.Categoriess.Queries
{
    /// <summary>
    /// Query ve Handler iç içe kullanım
    /// </summary>
    public class List
    {        
        public class Query : IRequest<List<Category>>{}

        public class Handler : IRequestHandler<Query, List<Category>>
        {
            private MediatrContext _context;

            public Handler(MediatrContext context) => _context = context;

            public async Task<List<Category>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await this._context.Categories.ToListAsync();
            }
        }
    }
}
