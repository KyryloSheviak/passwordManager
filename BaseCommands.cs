using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using GalaSoft.MvvmLight;

namespace passwordManager
{
    public class BaseCommands
    {
        public ICommand BtnInfo => 
            new RelayCommand (() => System.Diagnostics.Process.Start("https://mssg.me/sheviak"));
   
    }
}
