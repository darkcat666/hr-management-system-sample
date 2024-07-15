using System.Net.Http;
using System.Windows;
using HRManagementSystem.Services;
using HRManagementSystem.ViewModels;

namespace HRManagementSystem
{
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            // Set up dependency
            var httpClient = new HttpClient();
            var apiService = new ApiService(httpClient);
            var mainViewModel = new MainViewModel(apiService);

            // Create and show the main window
            var mainWindow = new Views.MainWindow
            {
                DataContext = mainViewModel
            };
            mainWindow.Show();
        }
    }
}
