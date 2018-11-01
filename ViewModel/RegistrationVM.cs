using GalaSoft.MvvmLight.Command;
using passwordManager.View;
using System.Windows;
using System.Windows.Input;

namespace passwordManager.ViewModel
{
    class RegistrationVM
    {
        private readonly Registration registration;

        public RegistrationVM(Registration registration)
        {
            this.registration = registration;
        }

        // закрытие программы
        public ICommand BtnClose => new RelayCommand(() => registration.Close());
        // сворачивание в панель (минимизация)
        public ICommand BtnHide => new RelayCommand(() => registration.WindowState = WindowState.Minimized);
    }
}
