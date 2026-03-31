using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ProjetoLogin.Models;

namespace ProjetoLogin.Data
{
    internal class AppDbContext : IdentityDbContext<User>
    {
        
    }
}