using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace BlazorApp.Client.Services
{
    public class AccountsClient : IAccountsClient
    {
        private readonly HttpClient _httpClient;

        private const string FunctionsHost = "https://fn.azurewebsites.net/api";

        public AccountsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PagedResult<Account>> SearchAccounts(string term, int page)
        {
            var url = FunctionsHost + "/search/" + page + "/" + term;
            url += "&term=" + term;

            return await _httpClient.GetJsonAsync<PagedResult<Account>>(url);
        }
    }
}
