using passwordManager.ViewModel;
using System.Windows;

namespace passwordManager.View
{
    /// <summary>
    /// Interaction logic for Operations.xaml
    /// </summary>
    public partial class Operations : Window
    {
        public Operations()
        {
            InitializeComponent();
            DataContext = new OperationsVM(this);
        }
    }
}
