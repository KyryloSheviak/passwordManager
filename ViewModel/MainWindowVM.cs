using GalaSoft.MvvmLight.Command;
using passwordManager.View;
using System;
using System.Windows;
using System.Windows.Input;

namespace passwordManager.ViewModel
{
    public class MainWindowVM
    {
        enum FormOparetions {
            Add,
            Edit
        }

        private readonly MainWindow mainWindow;

        public MainWindowVM(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public ICommand BtnNew => new RelayCommand(() => ShowFormOperations(FormOparetions.Add));
        public ICommand BtnEdit => new RelayCommand(() => ShowFormOperations(FormOparetions.Edit));

        public ICommand BtnLock => new RelayCommand(() =>
        {
            Entrance entrance = new Entrance();
            entrance.Show();
            mainWindow.Close();
        });

        // закрытие программы
        public ICommand BtnClose => new RelayCommand(() => Environment.Exit(0));
        // сворачивание в панель (минимизация)
        public ICommand BtnHide => new RelayCommand(() => mainWindow.WindowState = WindowState.Minimized);

        private void ShowFormOperations(FormOparetions formOparetions)
        {
            Operations operations = new Operations();
            operations.DataContext = new OperationsVM(operations);
            operations.TitleForm.Text = formOparetions == FormOparetions.Add ? Properties.Resources.titleFormAdd : Properties.Resources.titleFormEdit;
            operations.ShowDialog();
        }
    }
}
