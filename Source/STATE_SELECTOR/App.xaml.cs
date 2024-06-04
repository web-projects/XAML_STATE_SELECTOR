using System.Windows;
using STATE_SELECTOR.MVVM.ViewModels;

namespace STATE_SELECTOR
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                //DataContext = new ViewModelMain()
                DataContext = new StatesViewModel()
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
