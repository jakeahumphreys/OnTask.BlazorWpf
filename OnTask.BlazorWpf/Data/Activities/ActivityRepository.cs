using System;
using System.Collections.Generic;
using System.Linq;

namespace OnTask.BlazorWpf.Data.Activities;

public class ActivityRepository
{
    private readonly AppDbContext _context;

    public ActivityRepository()
    {
        _context = new AppDbContext();
    }

    public List<Activity> GetAll()
    {
        return _context.Activities.ToList();
    }

    public Activity GetById(Guid id)
    {
        return _context.Activities.SingleOrDefault(x => x.Id == id);
    }

    public void Add(Activity activity)
    {
        _context.Activities.Add(activity);
        _context.SaveChanges();
    }

    public void Update(Activity activity)
    {
        _context.Activities.Update(activity);
        _context.SaveChanges();
    }

    public void Delete(Activity activity)
    {
        _context.Activities.Remove(activity);
        _context.SaveChanges();
    }
}