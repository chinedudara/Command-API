using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cmdApi.Models;

namespace cmdApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase 
    {

        private readonly CommandContext _context;
        public CommandsController(CommandContext context) => _context = context;

        // GET: api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetCommands()
        {
            return _context.CommandSet;
        }

        // GET: api/commands/n
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommand(int id)
        {
            var commandSet = _context.CommandSet.Find(id);
            if (commandSet == null)
            {
                return NotFound();
            }
            return commandSet;
        }

        // POST: api/commands
        [HttpPost]
        public ActionResult<Command> AddCommand(Command command)
        {
            _context.CommandSet.Add(command);
            _context.SaveChanges();
            return CreatedAtAction("GetCommand", new Command{Id = command.Id}, command);
        }

        // PUT: api/commands/n
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, Command command)
        {
            if (id != command.Id){
                return BadRequest();
            }
            _context.Entry(command).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/delete/n
        [HttpDelete("{id}")]
        public ActionResult<Command> DeleteCommand(int id)
        {
            var commandSet = _context.CommandSet.Find(id);
            if (commandSet == null){
                return BadRequest();
            }
            _context.CommandSet.Remove(commandSet);
            _context.SaveChanges();
            return commandSet;
        }
    }
}