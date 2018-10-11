using System.Threading.Tasks;
using AEGDemo.Root.Repository;
using AEGDemo.Implementation.ViewModel;
using AEGDemo.Interface.Repository;
using AEGDemo.Interface.Service;

namespace AEGDemo.Implementation.Repository
{
    public class LoginRepository<T> : ProjectBaseRepository, ILoginRepository<T>
    {
        ILoginService<T> _Service;

        public LoginRepository(IMasterRepository masterRepository, ILoginService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task<T> YourMethodNameAsync(LoginViewModel model)
        {
            return await _Service.YourMethodNameAsync(model);
        }
    }
}