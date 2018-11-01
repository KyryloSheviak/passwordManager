using GalaSoft.MvvmLight.Command;
using passwordManager.View;
using System.Windows;
using System.Windows.Input;

namespace passwordManager.ViewModel
{
    public class OperationsVM
    {
        private readonly Operations operations;
        public OperationsVM (Operations operations)
        {
            this.operations = operations;
        }

        // закрытие программы
        public ICommand BtnClose => new RelayCommand(() => operations.Close());
        // сворачивание в панель (минимизация)
        public ICommand BtnHide => new RelayCommand(() => operations.WindowState = WindowState.Minimized);
    }
}
