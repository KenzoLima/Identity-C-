using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoLogin.Models;

namespace ApiIdentityEndpoint.Data
{
    // Corrigido: Definimos o parâmetro 'options' com o tipo correto
    internal class AppDbContext(DbContextOptions<AppDbContext> options)
        : IdentityDbContext<User>(options)
    {
        // O corpo pode ficar vazio se você não tiver DbSets personalizados aqui,
        // pois o IdentityDbContext já traz as tabelas de User, Role, etc.
    }
}