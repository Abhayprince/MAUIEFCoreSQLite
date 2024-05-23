using MAUIEFCoreSQLite.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIEFCoreSQLite.Data;
public class DataContext : DbContext
{
    public DataContext()
    {
        
    }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "maui.db");

        optionsBuilder.UseSqlite($"Filename = {dbPath}");
    }
}
