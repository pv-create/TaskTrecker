using System;
using Microsoft.EntityFrameworkCore;
using TodoList.Models;



namespace TodoList.Data.Repository;

public class StatusRepository: IGenericRepository<Status> 
{
    private readonly ApplicationDbContext _context;

        


    public StatusRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Status FindById(int id) => _context.Statuses.ToList().Where(all => all.Id == id).FirstOrDefault();
    

    public void Create(Status item)
    {
        _context.Add(item);
        _context.SaveChanges();
    }
        
        
        

    public async Task FindByIdasynk(int id) => _context.Tasks.Where(all => all.Id == id).FirstOrDefaultAsync();
       

    public IEnumerable<Status> Get()
    {
        return _context.Statuses.ToList();
    }

    public IEnumerable<Status> Get(Func<Status, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void Remove(Status Status)
    {
        throw new NotImplementedException();
    }

    public void Update(Status item)
    {
        throw new NotImplementedException();
    }
}