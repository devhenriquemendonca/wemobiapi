using System.Threading.Tasks;
using Refit;
using webmobiapi.wemobiapi.Model;

namespace webmobiapi.wemobiapi.Interfaces
{
    public interface IVehiclesService
    {
       [Post("/vehicle/getVehicles")] 
       Task<VehiclesContentViewModel> GetVehiclesAsync([Body(BodySerializationMethod.Serialized)] VehiclesViewModel parameters);
 
    }
}