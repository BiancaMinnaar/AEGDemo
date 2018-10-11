using System.Threading.Tasks;
using AEGDemo.Implementation.ViewModel;

namespace AEGDemo.Interface.Repository
{
    public interface ILoginRepository<T>
    {
        Task<T> YourMethodNameAsync(LoginViewModel model);
    }
}
