

using Learn.Api.BusinessObjects.Residents.Interface.Loan.GetLoan;
using Learn.Api.BusinessObjects.Residents.Interface.Loan.RegisterLoan;
using Learn.Api.BusinessObjects.Residents.Interface.Loan.UpdateLoan;
using Learn.Api.Repository.EFCore.Commands.Loan;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Learn.Api.Repository.EFCore;

public static class DependencyContainer
{
    public static IServiceCollection AddLearnRepositories(this IServiceCollection services)
    {
       services.AddDbContext<AppLoanContext>(options =>
       options.UseSqlServer("Server=(local);Database=ESTADIA;" +
       "Trusted_Connection=True;MultipleActiveResultSets=true;" +
       "TrustServerCertificate=True;"));
       services.AddScoped<IRegisterLoanRepository, RegisterLoanRepository>();
       services.AddScoped<IUpdateLoanRepository, UpdateLoanRepository>();
       services.AddScoped<IGetLoanRepository, GetLoanRepository>();
       return services;
    }

    public static IHost InitializeLearnApiDb(this IHost app)
    {
        using IServiceScope scope = app.Services.CreateScope();
        var Context = scope.ServiceProvider.GetRequiredService<AppLoanContext>();
        Context.Database.EnsureCreated();
        return app;
    }
}
