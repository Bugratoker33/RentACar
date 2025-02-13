using Application.Features.Brands.Queries.GetList;
using Application.Features.Models.Queries.GetList;
using Application.Features.Models.Queries.GetListByDynaic;
using Core.Aplication.Requests;
using Core.Aplication.Responses;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : BaseControler
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {//kulanıcıdan hangi sayfayı istiyorsun kaçarlı istiyorsun onu istiyoruz 
            GetListModelQuery getListModelQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListModelListItemDto> response = await Mediator.Send(getListModelQuery);
            return Ok(response);

        }
        [HttpPost("GetList/ByDynamic")]
        public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
        {
            GetListByDynamicModelQuery getListByDynamicModelQuery = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
            GetListResponse<GetListByDynamicModelListItemDto> response = await Mediator.Send(getListByDynamicModelQuery);
            return Ok(response);
        }
    }
}
