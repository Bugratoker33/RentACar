using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseControler
    {

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreteBrandCommand creteBrandCommand)
        {
          CretedBrandResponse response=  await Mediator.Send(creteBrandCommand);
        
            return Ok(response);
        }
    }
}
