using WebApplication8.Pages.Models;
using WebApplication8.Pages.Services;

namespace WebApplication8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.Configure<BookDatabaseSettings>(
                builder.Configuration.GetSection("BookDatabase"));
            builder.Services.AddSingleton<BookService>();

            builder.Services.Configure<SubscribersDatabaseSettings>(
                builder.Configuration.GetSection("SubscribersDatabase"));
            builder.Services.AddSingleton<SubscribersService>();

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}