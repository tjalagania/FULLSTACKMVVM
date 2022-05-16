using FULLSTACKMVVM.Commands;
using FULLSTACKMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public class Navigator : Inavigator
    {
        public ViewModelBase CurrentViewModel 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public ICommand UpdateCurrentViewModel => new UpdateCurrentViewModelCommand(this);
    }
}
