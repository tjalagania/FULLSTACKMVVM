using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.Financy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FULLSTACKMVVM.ViewModels
{
    public class StatementViewModel
    {
        private readonly IMajorIndexService _statservices;

        public StatementViewModel(IMajorIndexService statservices)
        {
            _statservices = statservices;
        }
        public static StatementViewModel LoadStatementViewModel(IMajorIndexService majorservice)
        {
            StatementViewModel stvm = new StatementViewModel(majorservice);
            stvm.LoadStatemetn();
            return stvm;
        }
        //ETH,
        //GOGN,
        //LVCLY
        public Statement StatementETH { get; set; }
        public Statement StatementGOGN { get; set; }
        public Statement StatementLVCLY { get; set; }

        private void LoadStatemetn()
        {
            _statservices.GetStatement(StatementType.ETH).ContinueWith(task =>
            {
                if (task.Exception == null)
                    StatementETH = task.Result;
            });
            _statservices.GetStatement(StatementType.LVCLY).ContinueWith(task =>
            {
                if (task.Exception == null)
                    StatementLVCLY = task.Result;
            });
            _statservices.GetStatement(StatementType.GOGN).ContinueWith(task =>
            {
                if (task.Exception == null)
                    StatementGOGN = task.Result;
            });
        }
    }
}
