
namespace Learn.Api.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddLearnCases(this IServiceCollection services)
    {
        
        services.AddScoped<IRegisterLoanInputPort, RegisterLoanHandler>();
        services.AddScoped<IUpdateLoanInputPort, UpdateLoanHandler>();
        services.AddScoped<IGetLoanInputPort, GetLoanHandler>();
        return services;
    }
}
