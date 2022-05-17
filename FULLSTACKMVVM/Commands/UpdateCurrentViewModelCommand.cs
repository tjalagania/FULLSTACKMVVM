using FULLSTACKMVVM.State.Navigation;
using FULLSTACKMVVM.ViewModels;
using SimpleTrader.Financy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FULLSTACKMVVM.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Inavigator _navigator;

        public UpdateCurrentViewModelCommand(Inavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is ViewType viewType)
            {
                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel(StatementViewModel.LoadStatementViewModel(new StatementServices()));
                        break;
                    case ViewType.Protfolio:
                        _navigator.CurrentViewModel = new PortfolioViewModel();
                        break;
                }
            }
            
        }
    }
}
