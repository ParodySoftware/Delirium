using System.Threading.Tasks;
using Delirium.Shared.Services.Base;
using Delirium.Shared.Services.DataContracts;
using Delirium.Shared.Services.Interfaces;

namespace Delirium.Shared.Services
{    
    public class LoginService : RestService, ILoginService
    {
        public LoginService(string baseAddress) : base(baseAddress)
        {
        }

        public async Task<User> GetUsers()
        {
            return await this.GetAsAsync<User>("oldcrap-rest/user/mail");
        }
    }
}
