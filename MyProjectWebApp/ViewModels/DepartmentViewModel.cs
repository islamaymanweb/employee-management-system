using System.ComponentModel.DataAnnotations;
using MyProjectWebApp.Models;
namespace MyProjectWebApp.ViewModels
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Department name is required.")]
        public string Name { get; set; }
    }
}
