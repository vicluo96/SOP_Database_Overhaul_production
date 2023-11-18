using Persistence;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using Application.Scholarships;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// builder.Services.AddDbContext<DataContext>(opt => 
// {
//     opt.UseMySQL(builder.Configuration.GetConnectionString("Default"));
// });

builder.Services.AddDbContext<Persistence.DataContext>(opt => 
{
    //opt.UseMySQL(builder.Configuration.GetConnectionString("Schl"));
    opt.UseMySql("server=localhost;user=root;database=schl;password=YL8416&st6y;port=3306", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql"));
});

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(List.Handler).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//Garbage collector
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;


try{
    var context = services.GetRequiredService<DataContext>();
    context.Database.Migrate();
}catch(Exception ex){
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occured during migration");
}

app.Run();
