using System.Threading.Tasks;
using AEGDemo.Implementation.Repository;
using AEGDemo.Implementation.Service;
using AEGDemo.Implementation.ViewModel;
using AEGDemo.Interface.Repository;
using AEGDemo.Interface.Service;
using AEGDemo.Interface.ViewController;
using AEGDemo.Root.ViewController;

namespace AEGDemo.Implementation.ViewController
{
    public class LoginViewController : ProjectBaseViewController<LoginViewModel>, ILoginViewController
    {
        ILoginRepository<LoginViewModel> _Reposetory;
        ILoginService<LoginViewModel> _Service;

        public override void SetRepositories()
        {
            _Service = new LoginService<LoginViewModel>((U, C, A) => 
                                                           ExecuteQueryWithReturnTypeAndNetworkAccessAsync<LoginViewModel>(U, C, A));
            _Reposetory = new LoginRepository<LoginViewModel>(_MasterRepo, _Service);
        }

        public async Task YourMethodNameAsync()
        {
            
        }
    }
}