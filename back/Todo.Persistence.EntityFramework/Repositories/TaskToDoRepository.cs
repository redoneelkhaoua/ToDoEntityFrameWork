using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todo.Domain.Models;
using Todo.RepositoryAbstraction;

namespace Todo.Repository
{
    public class TaskToDoRepository : IToDoRepository
    {
        TodoAppContext context;

        public TaskToDoRepository(TodoAppContext context)
        {
            this.context = context;
        }

        public Task<int> Delete(int id)
        {
            context.Remove(GetById(id));
            return context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TodoTask>> GetAll()
        {
            return await context.TodoTasks.ToListAsync();
        }

        public Task<TodoTask> GetById(int id)
        {
            return context.TodoTasks.FirstOrDefaultAsync(s => s.Id == id);
        }

        public Task<int> Add(TodoTask todoTasks)
        {
            context.Add(todoTasks);
            return context.SaveChangesAsync();
        }

        public async Task<int> Modify(int id, TodoTask todoTasks)
        {
            var todo = await context.TodoTasks.FirstOrDefaultAsync(s => s.Id == id);
            if (todo == null) return 0;
            todo.Status = todoTasks.Status;
            todo.Details = todoTasks.Details;
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}