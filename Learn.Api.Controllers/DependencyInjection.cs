

using Learn.Api.BusinessObjects.Residents.Interface.Loan.GetLoan;
using Learn.Api.BusinessObjects.Residents.Interface.Loan.RegisterLoan;
using Learn.Api.BusinessObjects.Residents.Interface.Loan.UpdateLoan;
using Learn.Api.Controllers.Loan.GetLoan;
using Learn.Api.Controllers.Loan.RegisterLoan;
using Learn.Api.Controllers.Loan.UpdateLoan;
using Microsoft.Extensions.DependencyInjection;

namespace Learn.Api.Controllers;

public static class DependencyInjection
{
    public static IServiceCollection AddLoanControllers(this IServiceCollection services)
    {
        services.AddScoped<IRegisterLoanController, RegisterLoanController>();
        services.AddScoped<IUpdateLoanController, UpdateLoanController>();
        services.AddScoped<IGetLoanController, GetLoanController>();
        return services;

    }
}
