using MAUIEFCoreSQLite.Data;
using Microsoft.EntityFrameworkCore;

namespace MAUIEFCoreSQLite;

public partial class MainPage : ContentPage
{
    private readonly DataContext _context;
    int count = 0;

    public MainPage(DataContext context)
    {
        InitializeComponent();
        _context = context;
    }

    protected override async void OnAppearing()
    {
        var user = await _context.Users.FirstOrDefaultAsync();
        if(user is not null)
        {
            nameLbl.Text = $"Username from Database: {user.Name}";
        }
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

