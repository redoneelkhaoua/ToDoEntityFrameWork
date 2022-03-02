using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Todo.Domain.Models;
using Todo.Repository;
using Todo.RepositoryAbstraction;
using ToDo.Services;

namespace Todo.DeoendencyInjection
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddTodoList(this IServiceCollection services)
        {
            services.AddScoped<IToDoRepository, TaskToDoRepository>();
            services.AddScoped<IToDoService, ToDoService>();
            // todo une connection par request => open à reception de request / fermeture une fois une reponse est donnée
           
            services.AddDbContext<TodoAppContext>(o =>
            {
                o.UseNpgsql();
            });
            return services;
        }
    }
}
