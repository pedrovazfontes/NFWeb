using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebNotas.Data;
using WebNotas.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<INotasRepository, NotasRepository>();
// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<AplicationContext>(options => options.UseSqlServer("Server=DESKTOP-7PE6O6G\\SQLEXPRESS;Database=NotasFiscais;Integrated Security=true; Trusted_Connection =true;TrustServerCertificate=true"));


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
    pattern: "{controller=Home}/{action=Privacy}/{id?}");

app.Run();

