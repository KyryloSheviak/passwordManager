using passwordManager.ViewModel;
using System.Windows;

namespace passwordManager.View
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            //DataContext = new RegistrationVM(this);
        }
    }
}
