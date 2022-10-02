using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Mediatr_and_CQRS.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mediatr_and_CQRS.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _sender;
        public ProductsController(ISender sender) => _sender = sender;

        [HttpGet]
        private async Task<ActionResult> GetProducts()
        {

            var products = _sender.Send(new GetProductsQuery());

            return Ok(products);
        }

    }
}