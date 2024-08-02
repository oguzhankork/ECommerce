using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Abstracts.BaseAbstract;
using ECommerce.BLL.Repositories.Concretes;
using ECommerce.BLL.Repositories.Concretes.BaseConcrete;
using ECommerce.DAL.Context;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ECommerce.IOC.DependencyResolvers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Dependency Injection Services
//AddDbContext
builder.Services.AddECommerceDb();



//Repository Services
builder.Services.AddRepositoryService();




//User Manager

builder.Services.AddIdentityService();

//Session
builder.Services.AddSession(x =>
{
    x.Cookie.Name = "Ecommerce_Cart_Session";
    x.IdleTimeout=TimeSpan.FromMinutes(5);
});



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
//session
app.UseSession();

app.UseAuthentication(); //kimlik yönetimi
app.UseAuthorization(); //yetkilendirme


app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );



    endpoints.MapControllerRoute(
      name: "default",
   pattern: "{controller=Home}/{action=Index}/{id?}"
   );
});



app.Run();
