using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HRManagementSystem.Models;

namespace HRManagementSystem.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _client.GetFromJsonAsync<List<Employee>>("http://localhost:8080/api/employees");
        }

        public async Task<Employee> GetEmployeeByIdAsync(long id)
        {
            return await _client.GetFromJsonAsync<Employee>($"http://localhost:8080/api/employees/{id}");
        }

        public async Task CreateEmployeeAsync(Employee employee)
        {
            await _client.PostAsJsonAsync("http://localhost:8080/api/employees", employee);
        }

        public async Task UpdateEmployeeAsync(long id, Employee employee)
        {
            await _client.PutAsJsonAsync($"http://localhost:8080/api/employees/{id}", employee);
        }

        public async Task DeleteEmployeeAsync(long id)
        {
            await _client.DeleteAsync($"http://localhost:8080/api/employees/{id}");
        }
}
}
    