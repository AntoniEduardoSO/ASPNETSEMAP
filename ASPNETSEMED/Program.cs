using TesteMVC.Data;
using Microsoft.EntityFrameworkCore;
using TesteMVC.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<BancoContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("Database")));

builder.Services.AddScoped<IAnydeskRepositorio, AnydeskRepositorio>();
builder.Services.AddScoped<IEscolaRepositorio, EscolaRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
