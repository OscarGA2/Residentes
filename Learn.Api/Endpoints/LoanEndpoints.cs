using Learn.Api.BusinessObjects.Residents.Interface.Loan.GetLoan;
using Learn.Api.BusinessObjects.Residents.Interface.Loan.RegisterLoan;
using Learn.Api.BusinessObjects.Residents.Interface.Loan.UpdateLoan;
using Learn.Api.Domain.Entities.Dtos.Loan;

namespace Learn.Api.Endpoints;

public static class LoanEndpoints
{
    public static WebApplication MapUserEndpoints(this WebApplication app)
    {
        var routeGroupBuilder = app.MapGroup("api/loan");

        //Guardar

        routeGroupBuilder.MapPost("/add", async (IRegisterLoanController controller, RegisterLoanDto loan)=>
        {
            await controller.RegisterLoanAsync(loan);
            return Results.Ok();
        });

        //Obtener

        routeGroupBuilder.MapGet("/get", async (IGetLoanController controller) =>
        {
            return Results.Ok( await controller.GetAllLoanAsync());
           
        });

        //Actualizar

        routeGroupBuilder.MapPut("/CancelLoan", async (IUpdateLoanController controller, UpdateLoanDto loan) =>
        {
            await controller.UpdateLoanAsync(loan);
            return Results.Ok();
        });

        return app;
    }
}
