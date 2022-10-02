using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Mediatr_and_CQRS.Models;

namespace Mediatr_and_CQRS.Queries
{
    public record GetProductsQuery : IRequest<IEnumerable<Product>>;

}