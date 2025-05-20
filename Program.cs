using Hydro.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using RazorTest.Conventions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.RootDirectory = "/Views";
    options.Conventions.Add(new TenantPageRouteModelConvention());

    // access restrict with policies.
    // options.Conventions.AuthorizeFolder("/", "Admin");

});

builder.Services.AddAuthorization(options =>
{
    // Add role policies etc....
    // options.AddPolicy("Admin",new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole("Admin").Build());
    // options.AddPolicy("Admin", p => p.RequireRole("Admin"));
});

builder.Services.AddHydro();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseHydro(builder.Environment);
app.Run();
