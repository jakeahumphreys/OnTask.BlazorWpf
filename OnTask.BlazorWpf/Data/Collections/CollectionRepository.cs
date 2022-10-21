using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace OnTask.BlazorWpf.Data.Collections;

public class CollectionRepository
{
    private readonly AppDbContext _context;

    public CollectionRepository()
    {
        _context = new AppDbContext();
    }

    public List<Collection> GetAll()
    {
        return _context.Collections
            .Include(x => x.Tasks)
            .ThenInclude(y => y.Activities)
            .ToList();
    }

    public Collection GetById(Guid id)
    {
        return _context.Collections
            .Include(x => x.Activities)
            .SingleOrDefault(x => x.Id == id);
    }

    public void Create(Collection collection)
    {
        _context.Collections.Add(collection);
        _context.SaveChanges();
    }

    public void Update(Collection collection)
    {
        _context.Collections.Update(collection);
        _context.SaveChanges();
    }

    public void Delete(Collection collection)
    {
        _context.Collections.Remove(collection);
        _context.SaveChanges();
    }
}