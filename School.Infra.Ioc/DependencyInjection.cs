using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using School.Domain.Interfaces;
using School.Infra.Data.Context;
using School.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IRegistrationRepository, RegistrationRepository>();
            services.AddScoped<IScoreRepository, ScoreRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
