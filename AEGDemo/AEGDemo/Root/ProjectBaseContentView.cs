using AEGDemo.Root.ViewModel;
using AEGDemo.Root.ViewController;
using AEGDemo.Trunk.Repository.Implementation;
using Xamarin.Forms;

namespace AEGDemo.Root.View
{
    public abstract class ProjectBaseContentView<T, M> : Grid
        where T : ProjectBaseViewController<M>, new()
        where M : ProjectBaseViewModel
    {
        protected T _ViewController;

        protected ProjectBaseContentView()
        {
            _ViewController = new T();
            SetSVGCollection();
            _ViewController._MasterRepo = MasterRepository.MasterRepo;
            _ViewController.SetRepositories();
        }

        protected abstract void SetSVGCollection();
    }
}