using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RepositoryPatternDemo.DL;
using RepositoryPatternDemo.EFRepositories;
using RepositoryPatternDemo.IRepositories;
using RepositoryPatternDemo.IServices;
using RepositoryPatternDemo.Repositories.EFRepositories;
using RepositoryPatternDemo.Services;
using RepositoryPatternDemo.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HOSPITALDBContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IBaseRepository<Patient>, EFPatientRepository>();
            services.AddScoped<IBaseRepository<Doctor>, EfDoctorRepository>();
            services.AddScoped<IBaseRepository<Hospital>, EfHospitalRepository>();
            services.AddScoped<IBaseRepository<Appointment>, EfAppointmentRepository>();
            services.AddTransient<IPatientService, PatientService>();
            services.AddTransient<IHospitalService, HospitalService>();
            services.AddTransient<IDoctorService, DoctorService>();
            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
