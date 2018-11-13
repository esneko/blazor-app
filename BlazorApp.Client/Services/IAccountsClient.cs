using System.Threading.Tasks;

namespace BlazorApp.Client.Services
{
    public interface IAccountsClient
    {
        Task<PagedResult<Account>> SearchAccounts(string term, int page);
    }
}
