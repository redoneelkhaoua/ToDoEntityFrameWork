using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Domain.Models;
using Todo.RepositoryAbstraction;

namespace Todo.Repository
{
    public class TaskRepository : IRepository
    {
        reddContext context;

        public TaskRepository(reddContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {

            context.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Task> GetAll()
        {
            return context.Tasks.ToList();

        }

        public Task GetById(int id)
        {
            return context.Tasks.Where(s => s.Id == id).First();
        }

        public void Add(Task tasks)
        {
            context.Add(tasks);
            context.SaveChanges();
        }

        public void Modify(int id,Task tasks)
        {
            var  task = context.Tasks.Where(s=> s.Id==id).First();
            task.Statue = tasks.Statue;
            task.Details = tasks.Details;
            context.SaveChanges();
        }
    }
}
