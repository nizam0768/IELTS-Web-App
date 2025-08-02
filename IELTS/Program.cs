using IELTS.Components;
using IELTS.EntityModels;
using IELTS.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped(sp => new HttpClient());
// Register the IELTSStoreDbContext with the dependency injection container
builder.Services.AddDbContextFactory<IELTSStoreDbContext>(options =>
{
    var configuration = builder.Configuration;
    var connectionString = configuration.GetConnectionString("CMTConnection");
    options.EnableSensitiveDataLogging()
           .UseLazyLoadingProxies()
           .UseSqlServer(connectionString);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Seed reading data
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<IELTSStoreDbContext>();
    try
    {
        await context.Database.EnsureCreatedAsync();
        await ReadingSampleData.SeedReadingData(context);
    }
    catch (Exception ex)
    {
        // Log error in production
        Console.WriteLine($"Error seeding reading data: {ex.Message}");
    }
}

app.Run();
