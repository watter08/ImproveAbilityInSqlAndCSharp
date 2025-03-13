using System.Data;

namespace ImproveAbilityInSqlAndC_.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<DataTable> GetExpensiveProductByCategory(string query);
    }
}
