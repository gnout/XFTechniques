using System;
using System.Collections.Generic;
using System.Text;

namespace Etude.ViewModels
{
    public class Example01ViewModel : BaseViewModel
    {
        public string Fullname
        {
            get { return _fullname; }
            set { SetProperty(ref _fullname, value); }
        }

        #region Private Variables
        private string _fullname = string.Empty;
        #endregion

        public Example01ViewModel()
        {

        }
    }
}
