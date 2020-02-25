using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NetCoreWithAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NetCoreWithAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;    

        public TodoController(TodoContext context)
        {
            _context = context;

            if(_context.TodoItems.Count()==0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<TodoItem>> GetAll()
        {
           return _context.TodoItems.ToList();
        }

        [HttpGet("{Id}", Name= "GetTodo")]
        public ActionResult<TodoItem> GetById(long Id)
        {
            var item = _context.TodoItems.Find(Id);
            if(item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}
