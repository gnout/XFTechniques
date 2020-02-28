using Etude.Modules;
using Etude.ViewModels;
using MethodDecorator.Fody.Interfaces;
using System;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

[module: Interceptor]

namespace Etude.Modules
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Assembly | AttributeTargets.Module)]
    public class Interceptor : Attribute, IMethodDecorator
    {
        private BaseViewModel _baseViewModel;

        public void Init(object instance, MethodBase method, object[] args)
        {
            _baseViewModel = instance as BaseViewModel;
        }

        public void OnEntry()
        {
            if (_baseViewModel == null)
            {
                return;
            }

            Device.BeginInvokeOnMainThread(() => _baseViewModel.IsBusy = true);
        }

        public void OnExit()
        {
            if (_baseViewModel == null)
            {
                return;
            }
        }

        public void OnTaskContinuation(Task task)
        {
        }

        public void OnException(Exception exception)
        {
            if (_baseViewModel == null)
            {
                return;
            }
        }
    }
}
