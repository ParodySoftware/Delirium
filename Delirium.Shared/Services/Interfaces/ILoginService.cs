using System.Threading.Tasks;
using Delirium.Shared.Services.DataContracts;

namespace Delirium.Shared.Services.Interfaces
{
    interface ILoginService
    {
        Task<User> GetUsers();
    }
}
