using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using OnTask.BlazorWpf.Data.Activities;
using OnTask.BlazorWpf.Data.Collections;
using OnTask.BlazorWpf.Data.Tasks;

namespace OnTask.BlazorWpf.Data;

public class AppDbContext : DbContext
{
    private string DbPath { get; }

    public AppDbContext()
    {
        var applicationDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OnTaskDesktop");
        DbPath = Path.Join(applicationDirectory, "OnTaskData.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    
    public DbSet<Collection> Collections { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Activity> Activities { get; set; }
}