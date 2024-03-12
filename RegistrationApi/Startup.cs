using System;
using AutoMapper;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using RegistrationApi.Data;
using RegistrationApi.Email;
using RegistrationApi.Profiles;
using RegistrationApi.MapperProfiles;
using RegistrationApi.Services.Users;
using RegistrationApi.Interfaces.Users;
using RegistrationApi.Services.Products;
using RegistrationApi.Repositories.Users;
using RegistrationApi.Interfaces.Products;
using RegistrationApi.Repositories.Products;

namespace RegistrationApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IEmailSender, EmailSenderHttp>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ICleaningRepository, CleaningRepository>();
            services.AddScoped<IDrinkRepository, DrinkRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<CustomerService>();
            services.AddScoped<EmployeeService>();
            services.AddScoped<UserService>();

            services.AddScoped<CleaningService>();
            services.AddScoped<DrinkService>();
            services.AddScoped<FoodService>();
            services.AddScoped<ProductService>();

            services.AddDbContext<EFContext>(opts => 
                opts.UseMySql(Configuration.GetConnectionString("MySQLConnection"), 
                ServerVersion.AutoDetect(Configuration.GetConnectionString("MySQLConnection"))));

            services.AddControllers();
            services.AddAutoMapper(cfg =>
            {
                AppDomain.CurrentDomain.GetAssemblies();
                cfg.AddProfile<UserProfile>();
                AppDomain.CurrentDomain.GetAssemblies();
                cfg.AddProfile<ProductProfile>();
            });
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RegistrationApi", Version = "v1" });});
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseDeveloperExceptionPage();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RegistrationApi v1"));
            }

            app.UseRouting();
            app.UseAuthorization();
            app.UseHttpsRedirection();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
