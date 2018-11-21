using GalaSoft.MvvmLight.Command;
using passwordManager.View;
using System;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace passwordManager.ViewModel
{
    public class OperationsVM : ViewModelBase
    {
        private readonly Operations operations;
        public OperationsVM (Operations operations)
        {
            this.operations = operations;

            // GetNewPassword();
        }

        // закрытие программы
        public ICommand BtnClose => new RelayCommand(() => operations.Close());
        // сворачивание в панель (минимизация)
        public ICommand BtnHide => new RelayCommand(() => operations.WindowState = WindowState.Minimized);


        /* Код ниже необходим для генерации пароля */
        private Random random = new Random(DateTime.Now.Second);
        private StringBuilder stringBuilder;
        // длина пароля, по дефолту 20 символов
        private int _count = 20;
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged("Count");
                GetNewPassword();
            }
        }

        // включение чисел
        public bool Numbers { get; set; }

        // включение символов
        public bool Sumbols { get; set; }

        // включение заглавных букв
        public bool UppChar { get; set; }

        // пароль
        public string _Password;
        public string Password
        {
            get => _Password;
            set
            {
                _Password = value;
                OnPropertyChanged("Password");
            }
        }

        // вызов метода генерации пароля
        public ICommand GetPassword => new RelayCommand(() => GetNewPassword());

        private void GetNewPassword()
        {
            stringBuilder = new StringBuilder(Count);
            while (stringBuilder.Length != Count)
            {
                var r = random.Next(1, 4);
                switch (r)
                {
                    case 1:
                        if (Numbers)
                            stringBuilder.Append((char)random.Next(48, 57 + 1));
                        break;
                    case 2:
                        if (Sumbols)
                        {
                            char[] sumbol = {
                                (char) random.Next(33, 48),
                                (char) random.Next(58, 65),
                                (char) random.Next(91, 97),
                                (char) random.Next(123, 127)
                            };
                            var s = random.Next(0, sumbol.Length);
                            stringBuilder.Append((char)sumbol[s]);
                        }
                        break;
                    case 3:
                        r = random.Next(0, 2);
                        if (r == 1 && UppChar)
                            stringBuilder.Append((char)random.Next(65, 90 + 1));
                        else
                            stringBuilder.Append((char)random.Next(97, 122 + 1));
                        break;
                }
            }
            Password = stringBuilder.ToString();
            /*
            MessageBox.Show(
                Count.ToString() + "\n" +
                Numbers.ToString() + "\n" +
                Sumbols.ToString() + "\n" +
                UppChar.ToString() + "\n" +
                stringBuilder.Capacity);
            */
        }
    }
}
