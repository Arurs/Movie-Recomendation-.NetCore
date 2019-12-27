using DataBaseService.Repository;
using Infrastructure.Repository;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseService
{
    public class DataBaseServiceModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //throw new NotImplementedException();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IMovieRepository, MovieRepository>();
            containerRegistry.Register<IUserRepository, UserRepository>();
            containerRegistry.Register<IRatingRepository, RatingRepository>();
        }
    }
}
