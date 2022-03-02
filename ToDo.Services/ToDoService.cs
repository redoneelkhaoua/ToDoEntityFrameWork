using Ardalis.GuardClauses;
using Todo.Domain.Models;
using Todo.RepositoryAbstraction;

namespace ToDo.Services;

/// <summary>
/// Todo Service
/// 
/// </summary>
public class ToDoService : IToDoService
{
    private IToDoRepository _toDoRepository;

    public ToDoService(IToDoRepository toDoRepository)
    {
        this._toDoRepository = toDoRepository;
    }

    public Task<IEnumerable<TodoTask>> GetAll()
    {
        return _toDoRepository.GetAll();
    }

    public async Task<TodoTask> GetById(int id)
    {
        Guard.Against.NegativeOrZero(id, nameof(id));
        var x = await _toDoRepository.GetById(id);
        return x;
    }

    public Task<int> Add(TodoTask todoTask)
    {
        Guard.Against.Null(todoTask, nameof(todoTask));
        return _toDoRepository.Add(todoTask);
    }

    public Task<int> Modify(int id, TodoTask todoTask)
    {
        Guard.Against.NegativeOrZero(id, nameof(id));
        Guard.Against.Null(todoTask, nameof(todoTask));
        return _toDoRepository.Modify(id, todoTask);
    }

    public Task<int> Delete(int id)
    {
        return _toDoRepository.Delete(id);
    }
}