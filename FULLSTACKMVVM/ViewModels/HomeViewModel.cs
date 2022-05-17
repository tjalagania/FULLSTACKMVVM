using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FULLSTACKMVVM.ViewModels
{
    public class HomeViewModel: ViewModelBase
    {
        public StatementViewModel StatementViewModel { get; set; }
        public HomeViewModel(StatementViewModel statementViewModel)
        {
            StatementViewModel = statementViewModel;
        }
    }
}
