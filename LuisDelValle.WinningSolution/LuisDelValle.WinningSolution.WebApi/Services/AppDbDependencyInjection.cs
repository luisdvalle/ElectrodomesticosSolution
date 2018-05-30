using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuisDelValle.WinningSolution.WebApi.Services
{
    public static class AppDbDependencyInjection
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddDbContext<AppDbContext>(options => options.UseMongoDb("mongodb://localhost"));
        }
    }
}
