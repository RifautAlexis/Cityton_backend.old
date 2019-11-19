using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using FluentValidation.AspNetCore;
using Cityton.Service.Validators;
using Cityton.Data;
using Cityton.Data.Models;
using Cityton.Repository;
using FluentValidation;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.AspNetCore.Identity;

namespace Cityton.Ui
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
            /*
             * Allow to configure FluentValidation
             */
            services.AddMvc().AddFluentValidation();

            /*
             * Add here all Fluent validators
             */
            services.AddTransient<IValidator<Company>, CompanyValidator>();
            services.AddTransient<IValidator<User>, UserValidator>();
            services.AddTransient<IValidator<Challenge>, ChallengeValidator>();
            services.AddTransient<IValidator<Achievement>, AchievementValidator>();
            services.AddTransient<IValidator<Group>, GroupValidator>();
            services.AddTransient<IValidator<ParticipantGroup>, ParticipantGroupValidator>();
            services.AddTransient<IValidator<ChallengeGiven>, ChallengeGivenValidator>();
            services.AddTransient<IValidator<Discussion>, DiscussionValidator>();
            services.AddTransient<IValidator<UserInDiscussion>, UserInDiscussionValidator>();
            services.AddTransient<IValidator<Message>, MessageValidator>();
            services.AddTransient<IValidator<Media>, MediaValidator>();

            /*
             * Register Context
             */
            services.AddDbContext<ApplicationContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
