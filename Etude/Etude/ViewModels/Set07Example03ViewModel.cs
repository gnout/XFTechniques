using Etude.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etude.ViewModels
{
    public class Set07Example03ViewModel : BaseViewModel
    {
        public Beer Model1
        {
            get => _model1;
            set => SetProperty(ref _model1, value);
        }

        public Beer Model2
        {
            get => _model2;
            set => SetProperty(ref _model2, value);
        }

        #region Backing Property Fields
        private Beer _model1 = new Beer { Name = "Rochefort 8", Alcohol = 9.2F };
        private Beer _model2 = new Beer { Name = "Leffe Blonde", Alcohol = 6.6F };
        #endregion

    }
}
