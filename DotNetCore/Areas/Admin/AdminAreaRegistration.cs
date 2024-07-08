using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Areas.Admin
{
    public class AdminAreaRegistration : AreaAttribute
    {
        public AdminAreaRegistration() : base("Admin") { }
    }
}
