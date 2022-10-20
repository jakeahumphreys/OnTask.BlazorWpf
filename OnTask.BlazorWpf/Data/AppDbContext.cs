using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace OnTask.BlazorWpf.Data;

public class AppDbContext : DbContext
{
    private string DbPath { get; }

    public AppDbContext()
    {
        var applicationDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OnTaskDesktop");
        DbPath = Path.Join(applicationDirectory, "OnTaskData.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
}