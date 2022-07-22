using PoolPlayingResource.data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PoolPlayingResourceContextConnection") ?? throw new InvalidOperationException("Connection string 'PoolPlayingResourceContextConnection' not found.");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();
builder.Services.AddRazorPages();

/*builder.Services.AddDefaultIdentity<PoolPlayingResourceUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<PoolPlayingResourceContext>();*/

WebApplication app = NewMethod(builder);

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

static WebApplication NewMethod(WebApplicationBuilder builder) { return builder.Build(); }