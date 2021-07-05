using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebUI.Client.Services;
using WebUI.Client.ViewModels.Departments;

namespace WebUI.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<DepartmentService>();
            builder.Services.AddScoped<CourseService>();
            builder.Services.AddScoped<InstructorService>();
            builder.Services.AddScoped<StudentService>();
            builder.Services.AddScoped<DepartmentsViewModel>();

            await builder.Build().RunAsync();
        }
    }
}
