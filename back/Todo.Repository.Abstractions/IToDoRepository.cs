using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Models;

namespace Todo.RepositoryAbstraction
{
    public interface IRepository<T>: IDisposable
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<int> Add(T todoTasks);
        Task<int> Modify(int id, T todoTasks);
        Task<int> Delete(int id);
    }


    public interface IToDoRepository : IRepository<TodoTask>
    {
    }
}