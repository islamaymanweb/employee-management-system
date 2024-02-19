using MyProjectWebApp.Models;
using MyProjectWebApp.ViewModels;

namespace MyProjectWebApp.Repositories
{
    public interface IEmployeeRepository
    {
        Task<EmployeeViewModel> GetByIdAsync(int id);
        IQueryable<EmployeeViewModel> GetAllAsync();
        Task AddAsync(EmployeeViewModel employee);
        Task UpdateAsync(EmployeeViewModel employee);
        Task DeleteAsync(int Id);

        Task<List<Department>> GetAllDepartments();
    }
}
