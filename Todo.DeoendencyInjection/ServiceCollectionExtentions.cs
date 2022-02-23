using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Todo.Domain.Models;
using Todo.Repository;
using Todo.RepositoryAbstraction;

namespace Todo.DeoendencyInjection
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddTodoList(this IServiceCollection services)
        {
            services.AddTransient<IRepository, TaskRepository>();
            // todo une connection par request => open à reception de request / fermeture une fois une reponse est donnée
           
            services.AddDbContext<reddContext>(o =>
            {
                o.UseNpgsql("User ID=postgres;Password=0000;Host=localhost;Port=5432;Database=redd;Pooling=true;Connection Lifetime=0;");
            });
            return services;
        }
    }
}
