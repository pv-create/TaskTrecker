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

        public TodoIthem FindById(int id)
        {
            return _context.Tasks.Where(all => all.Id == id).FirstOrDefault();
        }

        public void Create(TodoIthem item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        
        
        

       // public TodoIthem FindById(int id) => _context.Tasks.Where(all => all.Id == id).FirstOrDefault();


        public IEnumerable<TodoIthem> Get() => _context.Tasks.ToList();
        

        public IEnumerable<TodoIthem> Get(Func<TodoIthem, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(TodoIthem item)
        {
            _context.Tasks.Remove(item);
            _context.SaveChanges();
        }

        public void Update(TodoIthem item)
        {
            _context.Tasks.Update(item);
            _context.SaveChanges();
        }
    }
}

