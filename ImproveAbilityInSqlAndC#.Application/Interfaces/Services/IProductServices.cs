﻿using ImproveAbilityInSqlAndC_.Application.DTOs;

namespace ImproveAbilityInSqlAndC_.Application.Interfaces.Services
{
    public interface IProductServices
    {
        Task<ApiResponse<List<DtoProducts>>> GetMoreExpensiveProductByCategory();
    }
}
