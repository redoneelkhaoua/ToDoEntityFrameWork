using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Models;
using Todo.RepositoryAbstraction;

namespace ToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        IRepository repository;

        public TodoController(IRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
        [HttpGet ("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(repository.GetById(id));
        }
        [HttpPost]
        public void Add(Task task )
        {
            repository.Add(task);

        }
        [HttpPut ("{id}")]
        public void Modify(int id ,Task task)
        {
            repository.Modify(id,task);

            
        }
        [HttpDelete("{id}")]
         public void Delete(int id)
        {
            repository.Delete(id);
        }

    }
}
