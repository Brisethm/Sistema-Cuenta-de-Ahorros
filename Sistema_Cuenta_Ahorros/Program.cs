using Sistema_Cuenta_Ahorros.Models;

var builder = WebApplication.CreateBuilder(args);

// Servicios MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

// Ruta por defecto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cuenta}/{action=Index}/{id?}");

app.Run();
