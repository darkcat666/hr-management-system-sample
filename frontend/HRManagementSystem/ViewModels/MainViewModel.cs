using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using HRManagementSystem.Models;
using HRManagementSystem.Services;
using HRManagementSystem.Helpers;

namespace HRManagementSystem.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ApiService _apiService;

        public MainViewModel(ApiService apiService)
        {
            _apiService = apiService;
            LoadEmployeesCommand = new RelayCommand(async () => await LoadEmployeesAsync());
        }

        public ObservableCollection<Employee> Employees { get; } = new ObservableCollection<Employee>();

        public ICommand LoadEmployeesCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async Task LoadEmployeesAsync()
        {
            var employees = await _apiService.GetAllEmployeesAsync();
            Employees.Clear();
            foreach (var employee in employees)
            {
                Employees.Add(employee);
            }
        }
    }
}

