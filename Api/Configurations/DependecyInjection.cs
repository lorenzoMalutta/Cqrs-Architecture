using Command.Commands.Artist.Requests;
using Command.Commands.Artist.Responses;
using Command.Commands.Music.Requests;
using Command.Commands.Music.Responses;
using Command.Common;
using Command.Dispatcher;
using Command.Entity;
using Command.Handler.ArtistHandler;
using Command.Handler.MusicHandler;
using Command.Repository;
using Command.Service;
using Command.Service.Interface;
using Query.Common;
using Query.Dispatcher;
using Utils.EntityFramework;
using Utils.Identity;

namespace Cqrs_architecture.Configurations
{
    public static class DependecyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            /* Add your dependecies here */
            //Begin
            services.AddScoped<CommandDbContext>();
            services.AddScoped<BaseDbContext>();
            services.AddScoped<SecurityDbContext>();
            services.AddScoped<IServiceProvider, ServiceProvider>();
            services.AddScoped<ICommandDispatcher, CommandDispatcher>();
            services.AddScoped<IQueryDispatcher, QueryDispatcher>();

            //Artist
            services.AddScoped<IArtistService, ArtistService>();
            services.AddScoped<IBaseService<Artist>, BaseService<Artist>>();
            services.AddScoped<ICommandRepository<Artist>, CommandRepository<Artist>>();
            services.AddScoped<ICommandHandler<CreateArtistRequest, CreateArtistResponse>, ArtistCreateHandler>();
            services.AddScoped<ICommandHandler<DeleteArtistRequest, DeleteArtistResponse>, ArtistDeleteHandler>();
            services.AddScoped<ICommandHandler<UpdateArtistRequest, UpdateArtistResponse>, ArtistUpdateHandler>();

            //Music
            services.AddScoped<IMusicService, MusicService>();
            services.AddScoped<IBaseService<Music>, BaseService<Music>>();
            services.AddScoped<ICommandRepository<Music>, CommandRepository<Music>>();
            services.AddScoped<ICommandHandler<CreateMusicRequest, CreateMusicResponse>, MusicCreateHandler>();
            services.AddScoped<ICommandHandler<DeleteMusicRequest, DeleteMusicResponse>, MusicDeleteHandler>();
            services.AddScoped<ICommandHandler<UpdateMusicRequest, UpdateMusicResponse>, MusicUpdateHandler>();
            //End
            return services;
        }
    }
}
