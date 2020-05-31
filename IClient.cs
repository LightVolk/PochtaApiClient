using System.Threading.Tasks;

namespace PochtaApiClient
{
    public interface IClient
    {
        Task<getOperationHistoryResponse> GetOperationHistory(string trackID);
    }
}