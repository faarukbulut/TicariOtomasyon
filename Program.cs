using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.AdminRepositories;
using TicariOtomasyon.Repositories.CariRepositories;
using TicariOtomasyon.Repositories.DepartmanRepositories;
using TicariOtomasyon.Repositories.FaturaKalemsRepositories;
using TicariOtomasyon.Repositories.FaturaRepositories;
using TicariOtomasyon.Repositories.KategoriRepositories;
using TicariOtomasyon.Repositories.PersonelRepositories;
using TicariOtomasyon.Repositories.SatisHareketRepositories;
using TicariOtomasyon.Repositories.ToDoRepositories;
using TicariOtomasyon.Repositories.UrunDetayRepositories;
using TicariOtomasyon.Repositories.UrunRepositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddDbContext<Context>();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
    x.LoginPath = "/Login/Index";
});


builder.Services.AddScoped<IKategoriRepository, KategoriRepository>();
builder.Services.AddScoped<IUrunRepository, UrunRepository>();
builder.Services.AddScoped<IDepartmanRepository, DepartmanRepository>();
builder.Services.AddScoped<IPersonelRepository, PersonelRepository>();
builder.Services.AddScoped<ISatisHareketRepository, SatisHareketRepository>();
builder.Services.AddScoped<ICariRepository, CariRepository>();
builder.Services.AddScoped<IFaturaRepository, FaturaRepository>();
builder.Services.AddScoped<IFaturaKalemRepository, FaturaKalemRepository>();
builder.Services.AddScoped<IUrunDetayRepository, UrunDetayRepository>();
builder.Services.AddScoped<IToDoRepository, ToDoRepository>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();


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

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
