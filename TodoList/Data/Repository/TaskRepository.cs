using System;
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data.Repository
{
    public class TaskRepository: IGenericRepository<TodoIthem> 
    {

        private readonly ApplicationDbContext _context;

        


        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public TodoIthem FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Create(TodoIthem item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
        
        
        

        public async Task FindByIdasynk(int id) => _context.Tasks.Where(all => all.Id == id).FirstOrDefaultAsync();
       

        public IEnumerable<TodoIthem> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoIthem> Get(Func<TodoIthem, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(TodoIthem item)
        {
            throw new NotImplementedException();
        }

        public void Update(TodoIthem item)
        {
            throw new NotImplementedException();
        }
    }
}

