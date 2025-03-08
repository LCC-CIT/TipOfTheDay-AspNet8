#define SQLITE // use SQLSERVER, MySQL or SQLITE
// After changing the database provider:
// drop the db, remove old migrations and add a new migration, update the db

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TipOfTheDay.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#if SQLSERVER 
var connectionString = builder.Configuration.GetConnectionString("SqlServerConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
#elif MYSQL
var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
#elif SQLITE
var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
#endif

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Apply pending migrations and create the database if it does not exist.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    // Check if the database exists and migrations are  up to date
    if (context.Database.GetPendingMigrations().Any() || !context.Database.CanConnect())
    {
        context.Database.Migrate();
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
