namespace BankService.Interfaces
{
    public interface IBankService
    {
        Task<IEnumerable<string>> GetAllBanksAsync();
    }
}
