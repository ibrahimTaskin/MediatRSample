using MediatR;
using MediatRExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExample.Application.Productss
{
    public class GetProductQuery:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
