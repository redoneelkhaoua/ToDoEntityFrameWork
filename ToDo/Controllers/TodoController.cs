using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Domain.Models;
using Todo.RepositoryAbstraction;

namespace ToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        IToDoRepository _toDoRepository;

        public TodoController(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        [HttpGet]
        public Task<IEnumerable<TodoTask>> GetAll()
        {
            return _toDoRepository.GetAll();
        }
        [HttpGet ("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _toDoRepository.GetById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public Task<int> Add(TodoTask todoTask )
        {
            return _toDoRepository.Add(todoTask);
        }
        [HttpPut ("{id}")]
        public async Task<int> Modify(int id ,TodoTask todoTask)
        {
            var result = await _toDoRepository.Modify(id,todoTask);
            return result;
        }
        [HttpDelete("{id}")]
         public Task<int> Delete(int id)
        {
            return _toDoRepository.Delete(id);
        }

    }
}
