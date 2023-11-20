using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Builder;

namespace WebAPI
{
    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add serices to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Autofac, Ninject,CastleWindsor,SwtructureMap,LightInject, DryInject --> IoC Container
            //AOP 
            services.AddControllers();
            services.AddSingleton<ICourseService, CourseManager>();
            //AddSingleton = Arka planda bir referans oluştur. Ancak içerisinde veri tutulmuyorsa
            services.AddSingleton<ICourseDal, EfCourseDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
    }
}
