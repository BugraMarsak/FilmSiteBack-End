using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module //using Autofac
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArtistManager>().As<IArtistService>();
            builder.RegisterType<EfArtistDal>().As<IArtistDal>();

            builder.RegisterType<MovieManager>().As<IMovieService>();
            builder.RegisterType<EfMovieDal>().As<IMovieDal>();

            builder.RegisterType<MovieTypeManager>().As<IMovieTypeService>();
            builder.RegisterType<EfMovieTypeDal>().As<IMovieTypeDal>();

            builder.RegisterType<MovieAndArtistManager>().As<IMovieAndArtistService>();
            builder.RegisterType<EfMovieAndArtistDal>().As<IMovieAndArtistDal>();

            builder.RegisterType<GenreOfMovieManager>().As<IGenreOfMovieService>();
            builder.RegisterType<EfGenreOfMovieDal>().As<IGenreOfMovieDal>();

            builder.RegisterType<CommentManager>().As<ICommentService>();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();


            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
