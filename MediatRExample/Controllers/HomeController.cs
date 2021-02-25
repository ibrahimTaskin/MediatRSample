using MediatRExample.Application.ProductBase.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExample.Controllers
{
    /// <summary>
    /// Thin Controller
    /// </summary>
    public class HomeController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> Products()
        {
            return Ok(await Mediator.Send(new List.Query()));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(await Mediator.Send(new GetActivity.Query()));
        }
    }
}
