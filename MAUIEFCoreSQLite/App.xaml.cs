using MAUIEFCoreSQLite.Data;
using MAUIEFCoreSQLite.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MAUIEFCoreSQLite;

public partial class App : Application
{
    private readonly DataContext _context;

    public App(DataContext context)
    {
        InitializeComponent();

        _context = context;
        context.Database.Migrate();
        SeedDatabase();

        MainPage = new AppShell();
    }

    private void SeedDatabase()
    {
        if (_context.Users.Any())
            return; // We already seeded the database

        var user = new User
        {
            Name = "Abhay Prince"
        };
        _context.Users.Add(user);
        _context.SaveChanges();
    }
}
