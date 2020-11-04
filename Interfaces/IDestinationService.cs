using System.Threading.Tasks;
using Refit;
using webmobiapi.wemobiapi.Model;

namespace webmobiapi.wemobiapi.Interfaces
{
    public interface IDestinationService
    {
        [Get("/places/searchDestination?originId={id}")]
        Task<BaseContent<DestinationViewModel>> GetDestinationAsync(int id);
    }
}