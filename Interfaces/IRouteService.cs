using System.Threading.Tasks;
using Refit;
using webmobiapi.wemobiapi.Model;

namespace webmobiapi.wemobiapi.Interfaces
{
    public interface IRouteService
    {
        [Post("/route/getroutes")]
        Task<RoutesContentViewModel> PostRoutesAsync([Body(BodySerializationMethod.Serialized)] RouteViewModel parameters);
 
    }
}