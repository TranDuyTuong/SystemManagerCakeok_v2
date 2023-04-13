using ManagerCakeOk.ConnectApi.InterfaceApi.ICity_DI;
using ManagerCakeOk.ConnectApi.InterfaceApi.IDistrict_DI;
using ManagerCakeOk.ConnectApi.ServiceApi.City_DI;
using ManagerCakeOk.ConnectApi.ServiceApi.District_DI;
using Microsoft.AspNetCore.Authentication.Cookies;


var builder = WebApplication.CreateBuilder(args);

// Add service call api
builder.Services.AddHttpClient();

// Add services DI
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<IDistrictService, DistrictService>();


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = ".AspNetCore.Cookies";
        options.LoginPath = "/Home/Login";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
        options.SlidingExpiration = true;
    });
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Add services to the container.
builder.Services.AddControllersWithViews();
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
