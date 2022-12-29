using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace PieShop.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;
    }
}
