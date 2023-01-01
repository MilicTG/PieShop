using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace PieShop.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employess { get; set; } = default;

        private Employee? _selectedEmployee;

        protected override void OnInitialized()
        {
            Employess = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee= selectedEmployee;
        }
    }
}



