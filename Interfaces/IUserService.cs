using System.Threading.Tasks;
using Refit;
using webmobiapi.wemobiapi.Model;

namespace webmobiapi.wemobiapi.Interfaces
{
    public interface IUserService
    {
        [Post("/customer/user")]
        Task<UserCreateContentViewModel> PostCreateUserAsync([Body(BodySerializationMethod.Serialized)] UserCreateViewModel parameters);
        
        [Post("/customer/account")]
        Task<UserContentViewModel> PostLoginUserAsync([Body(BodySerializationMethod.Serialized)] LoginViewModel parameters);

  
    }
}