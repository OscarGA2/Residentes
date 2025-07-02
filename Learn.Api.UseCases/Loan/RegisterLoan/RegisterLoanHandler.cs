


namespace Learn.Api.UseCases.Loan.RegisterLoan;

internal class RegisterLoanHandler(IRegisterLoanRepository registerLoanRepository):IRegisterLoanInputPort
{
    public async Task RegisterLoanAsync(RegisterLoanDto loan)
    {
       bool IsRegistered = await registerLoanRepository.RegisterLoanAsync(loan);
        await registerLoanRepository.SaveChangesAsync();
    }
}
