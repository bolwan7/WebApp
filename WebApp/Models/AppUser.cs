using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models
{
    public class AppUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }

    }
}
