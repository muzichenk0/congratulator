﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication5LVL.DataAccess.Db;
using WebApplication5LVL.Infrastructure.Repositories;
using WebApplication5LVL.AppData.Contexts.User;
using WebApplication5LVL.DataAccess.Contexts.User;

namespace WebApplication5LVL.Register
{
    public static class Register
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        => services
            .AddScoped((Func<IServiceProvider, DbContext>)(sp => sp.GetRequiredService<DbAppContext>()))
            .AddScoped(typeof(IRepository<>), typeof(Repository<>))
            .AddTransient<IUserService, UserService>()
            .AddTransient<IUserRepository, UserRepository>();
    }
}