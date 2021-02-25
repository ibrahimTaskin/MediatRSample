using MediatR;
using MediatRExample.Application.Categoriess.Queries;
using MediatRExample.Application.Productss;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatRExample.Controllers
{
    /// <summary>
    /// Thin Controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public async Task<IActionResult> Products()
        //{
        //    return Ok(await _mediator.Send(new ProductsAllQuery()));
        //}


        [HttpGet("{id}")]
        public async Task<IActionResult> Product([FromRoute] GetProductQuery request)
        {
            return Ok(await _mediator.Send(request));
        }


        [HttpGet]
        public async Task<IActionResult> Categories()
        {
            return Ok(await _mediator.Send(new List.Query()));
        }
    }
}
