using System.Threading.Tasks;
using webmobiapi.wemobiapi.Model;
using Refit;


namespace webmobiapi.wemobiapi.Interfaces
{
    public interface IOriginService
    {
        [Get("/places/searchOrigin")]
        Task<BaseContent<OriginViewModel>> GetAllOriginAsync();
         
    }
}