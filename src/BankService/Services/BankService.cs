using BankService.Interfaces;
using Newtonsoft.Json;

namespace BankService.Services
{
    public class BankService : IBankService
    {
        private readonly HttpClient _httpClient;

        public BankService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<string>> GetAllBanksAsync()
        {
            var response = await _httpClient.GetStringAsync("https://apiplayground.alat.ng/debit-wallet/api/Shared/GetAllBanks");
            return JsonConvert.DeserializeObject<IEnumerable<string>>(response);
        }
    }
}
