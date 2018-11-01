using passwordManager.ViewModel;
using System.Windows;

namespace passwordManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new MainWindowVM(this);
        }
    }
}
