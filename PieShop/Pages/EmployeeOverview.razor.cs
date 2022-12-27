using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace PieShop.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employess { get; set; } = default;

        protected override void OnInitialized()
        {
            Employess = MockDataService.Employees;
        }
    }
}



