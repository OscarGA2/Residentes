
using Learn.Api.Controllers;
using Learn.Api.Repository.EFCore;
using Learn.Api.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Learn.Api.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddLearnServices(this IServiceCollection services)
    {
        services.AddLearnCases();
        services.AddLearnRepositories();
        services.AddLoanControllers();
        return services;
    }
}
