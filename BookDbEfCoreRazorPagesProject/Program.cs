using BookDbEfCoreRazorPagesProject.Data;
using Microsoft.EntityFrameworkCore;

namespace BookDbEfCoreRazorPagesProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Verbindung zur MySQL-Datenbank mit Oracle-Provider
            builder.Services.AddDbContext<BookContext>(options =>
                options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddRazorPages();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapRazorPages();

            app.MapGet("/", context =>
            {
                context.Response.Redirect("/Books");
                return Task.CompletedTask;
            });

            app.Run();
        }
    }
}
