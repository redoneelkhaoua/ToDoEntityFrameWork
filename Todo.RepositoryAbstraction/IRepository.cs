using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Domain.Models;

namespace Todo.RepositoryAbstraction
{
   public interface IRepository
    {
        List<Task> GetAll();
        Task GetById(int id);
        void Add(Task tasks);
        void Modify(int id,Task tasks);
        void Delete(int id);
    }
}
