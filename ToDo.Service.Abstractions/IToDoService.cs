using Todo.Domain.Models;

namespace ToDo.Services;

public interface IToDoService
{
    Task<IEnumerable<TodoTask>> GetAll();
    Task<TodoTask> GetById(int id);
    Task<int> Add(TodoTask todoTask);
    Task<int> Modify(int id, TodoTask todoTask);
    Task<int> Delete(int id);
}