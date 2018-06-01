﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EVETrader.Web2.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.OAuth;
using EveTrader.Web.Core;
using System.Net.Http.Headers;
using EveTrader.Web.Core.Repositories;

namespace EVETrader.Web2
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

			services.AddAuthentication()
				.AddEVEOnline(options =>
				{
					options.SaveTokens = true;
					options.ClientId = Configuration.GetSection("EveOnline")["ClientId"];
					options.ClientSecret = Configuration.GetSection("EveOnline")["ClientSecret"];
					options.Scope.Add("esi-alliances.read_contacts.v1");
					options.Scope.Add("esi-assets.read_assets.v1");
					options.Scope.Add("esi-assets.read_corporation_assets.v1");
					options.Scope.Add("esi-bookmarks.read_character_bookmarks.v1");
					options.Scope.Add("esi-bookmarks.read_corporation_bookmarks.v1");
					options.Scope.Add("esi-calendar.read_calendar_events.v1");
					options.Scope.Add("esi-calendar.respond_calendar_events.v1");
					options.Scope.Add("esi-characters.read_agents_research.v1");
					options.Scope.Add("esi-characters.read_blueprints.v1");
					options.Scope.Add("esi-characters.read_chat_channels.v1");
					options.Scope.Add("esi-characters.read_contacts.v1");
					options.Scope.Add("esi-characters.read_corporation_roles.v1");
					options.Scope.Add("esi-characters.read_fatigue.v1");
					options.Scope.Add("esi-characters.read_fw_stats.v1");
					options.Scope.Add("esi-characters.read_loyalty.v1");
					options.Scope.Add("esi-characters.read_medals.v1");
					options.Scope.Add("esi-characters.read_notifications.v1");
					options.Scope.Add("esi-characters.read_opportunities.v1");
					options.Scope.Add("esi-characters.read_standings.v1");
					options.Scope.Add("esi-characters.read_titles.v1");
					options.Scope.Add("esi-characters.write_contacts.v1");
					options.Scope.Add("esi-characterstats.read.v1");
					options.Scope.Add("esi-clones.read_clones.v1");
					options.Scope.Add("esi-clones.read_implants.v1");
					options.Scope.Add("esi-contracts.read_character_contracts.v1");
					options.Scope.Add("esi-contracts.read_corporation_contracts.v1");
					options.Scope.Add("esi-corporations.read_blueprints.v1");
					options.Scope.Add("esi-corporations.read_contacts.v1");
					options.Scope.Add("esi-corporations.read_container_logs.v1");
					options.Scope.Add("esi-corporations.read_corporation_membership.v1");
					options.Scope.Add("esi-corporations.read_divisions.v1");
					options.Scope.Add("esi-corporations.read_facilities.v1");
					options.Scope.Add("esi-corporations.read_fw_stats.v1");
					options.Scope.Add("esi-corporations.read_medals.v1");
					options.Scope.Add("esi-corporations.read_outposts.v1");
					options.Scope.Add("esi-corporations.read_standings.v1");
					options.Scope.Add("esi-corporations.read_starbases.v1");
					options.Scope.Add("esi-corporations.read_structures.v1");
					options.Scope.Add("esi-corporations.read_titles.v1");
					options.Scope.Add("esi-corporations.track_members.v1");
					options.Scope.Add("esi-fittings.read_fittings.v1");
					options.Scope.Add("esi-fittings.write_fittings.v1");
					options.Scope.Add("esi-fleets.read_fleet.v1");
					options.Scope.Add("esi-fleets.write_fleet.v1");
					options.Scope.Add("esi-industry.read_character_jobs.v1");
					options.Scope.Add("esi-industry.read_character_mining.v1");
					options.Scope.Add("esi-industry.read_corporation_jobs.v1");
					options.Scope.Add("esi-industry.read_corporation_mining.v1");
					options.Scope.Add("esi-killmails.read_corporation_killmails.v1");
					options.Scope.Add("esi-killmails.read_killmails.v1");
					options.Scope.Add("esi-location.read_location.v1");
					options.Scope.Add("esi-location.read_online.v1");
					options.Scope.Add("esi-location.read_ship_type.v1");
					options.Scope.Add("esi-mail.organize_mail.v1");
					options.Scope.Add("esi-mail.read_mail.v1");
					options.Scope.Add("esi-mail.send_mail.v1");
					options.Scope.Add("esi-markets.read_character_orders.v1");
					options.Scope.Add("esi-markets.read_corporation_orders.v1");
					options.Scope.Add("esi-markets.structure_markets.v1");
					options.Scope.Add("esi-planets.manage_planets.v1");
					options.Scope.Add("esi-planets.read_customs_offices.v1");
					options.Scope.Add("esi-search.search_structures.v1");
					options.Scope.Add("esi-skills.read_skillqueue.v1");
					options.Scope.Add("esi-skills.read_skills.v1");
					options.Scope.Add("esi-ui.open_window.v1");
					options.Scope.Add("esi-ui.write_waypoint.v1");
					options.Scope.Add("esi-universe.read_structures.v1");
					options.Scope.Add("esi-wallet.read_character_wallet.v1");
					options.Scope.Add("esi-wallet.read_corporation_wallets.v1");

					options.Events = new OAuthEvents()
					{

						OnTicketReceived = context =>
						{
							context.Properties.IsPersistent = true;
							context.Properties.ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7);
							return Task.FromResult(0);
						}


					};
				});

			services.AddScoped<ISalesOrderRepository, SalesOrderRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IShoppingListRepository, ShoppingListRepository>();
			services.AddHttpClient<EVETraderClient>("EveTraderApi", client =>
			{
				client.BaseAddress = new Uri("http://localhost:56362");
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			});


			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}