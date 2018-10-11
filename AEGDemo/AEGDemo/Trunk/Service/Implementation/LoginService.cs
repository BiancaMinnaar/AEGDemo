using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BaseBonsai.DataContracts;
using BaseBonsai.Networking;
using AEGDemo.Implementation.ViewModel;
using AEGDemo.Interface.Service;

namespace AEGDemo.Implementation.Service
{
    public class LoginService<T> : BaseService<T>, ILoginService<T>
    {
        public LoginService(Func<string, Dictionary<string, ParameterTypedValue>, BaseNetworkAccessEnum, Task<T>> networkInterface)
            :base(networkInterface)
        {
        }

        public async Task<T> YourMethodNameAsync(LoginViewModel model)
        {
            string requestURL = "/path/{Parameter}";
            var httpMethod = BaseNetworkAccessEnum.Get;
            var parameters = new Dictionary<string, ParameterTypedValue>()
            {
                //{"Parameter", model.Property},
            };
            return await _NetworkInterfaceWithOutput(requestURL, parameters, httpMethod);
        }
    }
}
