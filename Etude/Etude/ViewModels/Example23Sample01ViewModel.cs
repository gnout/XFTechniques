using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Etude.ViewModels
{
    public class Example23Sample01ViewModel : ReactiveObject
    {
        [DataMember]
        public string UserName 
        { 
            get => _userName;
            set => this.RaiseAndSetIfChanged(ref _userName, value);
        }

        [DataMember]
        public string Password
        {
            get => _password;
            set => this.RaiseAndSetIfChanged(ref _password, value);
        }

        #region Backing variables
        private string _userName;
        private string _password;
        #endregion
    }
}
