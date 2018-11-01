using System.Windows;
using passwordManager.ViewModel;

namespace passwordManager
{
    /// <summary>
    /// Interaction logic for Entrance.xaml
    /// </summary>
    public partial class Entrance : Window
    {
        public Entrance()
        {
            InitializeComponent();
            DataContext = new EntranceVM(this);
        }
    }
}
