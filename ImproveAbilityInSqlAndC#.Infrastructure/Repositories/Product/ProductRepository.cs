using ImproveAbilityInSqlAndC_.Application.Interfaces.Repositories;
using ImproveAbilityInSqlAndC_.Infrastructure.Context;
using System.Data;

namespace ImproveAbilityInSqlAndC_.Infrastructure.Repositories.Product
{
    public class ProductRepository: IProductRepository
    {
        private readonly AdoNetContext _context;
        public ProductRepository(AdoNetContext context)
        {
            _context = context;
        }

        public async Task<DataTable> GetExpensiveProductByCategory(string query)
        {
            return await _context.ExecuteQueryAsync(query);
        }
    }
}
