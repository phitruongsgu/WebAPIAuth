using Microsoft.AspNetCore.Identity;

namespace WebAPIAuth.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
