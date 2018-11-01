using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using passwordManager.View;
using System.Windows;
using System.Threading;

namespace passwordManager.ViewModel
{
    class EntranceVM
    {
        private MainWindow mainWindow;
        private Registration registration;
        private readonly Entrance entrance;

        public EntranceVM (Entrance entrance)
        {
            this.entrance = entrance;
        }
        // открытие сайта
        public ICommand BtnInfo => new RelayCommand(() => System.Diagnostics.Process.Start("https://mssg.me/sheviak"));
        // закрытие программы
        public ICommand BtnClose => new RelayCommand(() => entrance.Close());
        // сворачивание в панель (минимизация)
        public ICommand BtnHide => new RelayCommand(() => entrance.WindowState = WindowState.Minimized);
        // открытие окна регистрации
        public ICommand BtnRegistration => new RelayCommand(() =>
        {
            //if (registration == null)
            //{
            registration = new Registration();
            registration.DataContext = new RegistrationVM(registration);
            registration.ShowDialog();
            //}
            //else registration.ShowDialog();
        });
        // открытие главного окна приложения
        public ICommand BtnAccent => new RelayCommand(() => {
            //if (mainWindow == null)
            //{
                mainWindow = new MainWindow();
                mainWindow.DataContext = new MainWindowVM(mainWindow);
                mainWindow.Show();
                entrance.Close();
            //}
        });
    }
}
