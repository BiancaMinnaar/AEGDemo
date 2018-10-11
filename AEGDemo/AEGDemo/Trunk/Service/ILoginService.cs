using System.Threading.Tasks;
using AEGDemo.Implementation.ViewModel;

namespace AEGDemo.Interface.Service
{
    public interface ILoginService<T>
    {
        Task<T> YourMethodNameAsync(LoginViewModel model);
    }
}
