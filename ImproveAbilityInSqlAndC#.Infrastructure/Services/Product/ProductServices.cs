using ImproveAbilityInSqlAndC_.Application.DTOs;
using ImproveAbilityInSqlAndC_.Application.Interfaces.Patterns;
using ImproveAbilityInSqlAndC_.Application.Interfaces.Repositories;
using ImproveAbilityInSqlAndC_.Application.Interfaces.Services;
using ImproveAbilityInSqlAndC_.Application.Mappings;
using System.Data;

namespace ImproveAbilityInSqlAndC_.Infrastructure.Services.Product
{
    public class ProductServices: IProductServices
    {
        private IProductRepository _repository;
        private IQueryFactory _queryFactory;
        public ProductServices(IProductRepository repository, IQueryFactory queryFactory)
        {
            _repository = repository;
            _queryFactory = queryFactory;
        }

        public async Task<ApiResponse<List<DtoProducts>>> GetMoreExpensiveProductByCategory()
        {
            ApiResponse<List<DtoProducts>>? response = default;
            try
            {
                string query = _queryFactory.GetQuery("maxExpensiveProductByCategory");
                DataTable dt = await _repository.GetExpensiveProductByCategory(query);
                ProductDataTableMapper mapper = new();
                List<DtoProducts> products = mapper.MapDataTableToList(dt);
                response = ApiResponse<List<DtoProducts>>.Success(products);
                return response;

            }
            catch (Exception ex)
            {
                response = ApiResponse<List<DtoProducts>>.Error(ex.Message);
                return response;
            }
        }
    }
}
