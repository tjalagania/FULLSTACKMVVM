using FULLSTACKMVVM.State.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FULLSTACKMVVM.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public Inavigator Navigator { get; set; } = new Navigator();
    }
}
