using SongListApp.Data;
using SongListApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Registracija AppDbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registracija SongService
builder.Services.AddScoped<SongService>();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor(); // Blazor Server funkcionalnosti
builder.Services.AddSignalR();



var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

