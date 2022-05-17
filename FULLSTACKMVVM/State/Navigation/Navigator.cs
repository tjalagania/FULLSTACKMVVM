using FULLSTACKMVVM.Commands;
using FULLSTACKMVVM.Models;
using FULLSTACKMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FULLSTACKMVVM.State.Navigation
{
    public enum ViewType
    {
        Home,
        Protfolio
    }
    public class Navigator :ObservableObject,  Inavigator
    {
        private ViewModelBase _viewModel;
        public ViewModelBase CurrentViewModel 
        { 
            get => _viewModel; 
            set
            {
                _viewModel = value;
                OnPoreptyChanged();
            }
        }

       
        public ICommand UpdateCurrentViewModel => new UpdateCurrentViewModelCommand(this);

        
    }
}
