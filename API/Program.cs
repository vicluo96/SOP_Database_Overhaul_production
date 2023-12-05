using Persistence;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using Application.Scholarships;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(opt => {
    opt.AddPolicy("CorsPolicy", policy => 
    {
        //policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("htttp://localhost:5173");
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

// Add services to the container.

builder.Services.AddControllers();
// builder.Services.AddDbContext<DataContext>(opt => 
// {
//     opt.UseMySQL(builder.Configuration.GetConnectionString("Default"));
// });


builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("Schl"), 
                     ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("Schl")))
);

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(List.Handler).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("CorsPolicy");

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
