using ImproveAbilityInSqlAndC_.Application.DTOs;
using ImproveAbilityInSqlAndC_.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ImproveAbilityInSqlAndC_.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _services;
        public ProductsController(IProductServices productServices)
        {
            _services = productServices;
        }

        [HttpGet(Name = "GetMaxExpensiveProductByCategory")]
        public async Task<IActionResult> GetMaxExpensiveProductByCategory()
        {
            ApiResponse<List<DtoProducts>> response = await _services.GetMoreExpensiveProductByCategory();
            return Ok(response);
        }
    }
}
