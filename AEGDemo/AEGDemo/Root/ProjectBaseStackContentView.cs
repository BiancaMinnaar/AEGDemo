using AEGDemo.Root.ViewController;
using AEGDemo.Root.ViewModel;
using AEGDemo.Trunk.Repository.Implementation;
using Xamarin.Forms;

namespace AEGDemo.Root.View
{
    public abstract class ProjectBaseStackContentView<T, M> : StackLayout
        where T : ProjectBaseViewController<M>, new()
        where M : ProjectBaseViewModel
    {
        protected T _ViewController;

        protected ProjectBaseStackContentView()
        {
            _ViewController = new T();
            SetSVGCollection();
            _ViewController._MasterRepo = MasterRepository.MasterRepo;
            _ViewController.SetRepositories();
        }

        protected abstract void SetSVGCollection();
    }
}

