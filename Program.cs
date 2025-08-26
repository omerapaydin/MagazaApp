using MagazaApp.Data.Abstract;
using MagazaApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(options =>{
    options.UseSqlite(builder.Configuration.GetConnectionString("sql_connection"));
});

builder.Services.AddScoped<IProductRepository,EfProductRepository>();
builder.Services.AddScoped<ICategoryRepository,EfCategoryRepository>();



var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
