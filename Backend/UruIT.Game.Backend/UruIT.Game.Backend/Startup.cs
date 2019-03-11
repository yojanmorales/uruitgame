using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using UruIT.Game.Bll;
using UruIT.Game.Bll.Context;
using UruIT.Game.Bll.Dao.games;
using UruIT.Game.Bll.Dao.moves;
using UruIT.Game.Bll.Dao.users;
using UruIT.Game.Model;
using UruIT.Game.Service.Layers.Games;
using UruIT.Game.Service.Layers.Moves;
using UruIT.Game.Service.Layers.Users;
//using UruIT.Game.Context;

namespace UruIT.Game.Backend
{
    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOData();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<GameDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUsersBll, UsersBll>();
            services.AddTransient<IGameDbContext, GameDbContext>();

            //games
            services.AddTransient<IGamesService, GamesService>();
            services.AddTransient<IGamesBll, GamesBll>();

            //moves
            services.AddTransient<IMovesService, MovesService>();
            services.AddTransient<IMovesBll, MovesBll>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(builder =>
                   builder.WithOrigins("*")
                       .AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(b =>
            {
                b.MapODataServiceRoute("odata", "odata", GetEdmModel());
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Working on it!");
            });
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<User>("Users");
            builder.EntitySet<Move>("Moves");
            builder.EntitySet<Game.Model.Game>("Games");
            var userSet = builder.EntitySet<User>("Users");
            userSet.EntityType.Count().Filter().OrderBy().Expand().Select();
            var gameSet = builder.EntitySet<Game.Model.Game>("Games");
            gameSet.EntityType.Count().Filter().OrderBy().Expand().Select();
            var moveSet = builder.EntitySet<Move>("Moves");
            moveSet.EntityType.Count().Filter().OrderBy().Expand().Select();


            return builder.GetEdmModel();
        }
    }
}
