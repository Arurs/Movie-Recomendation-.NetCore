using CommonServiceLocator;
using DataBaseService;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace movieRecomendation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {

        protected override Window CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>();
        }

        protected override void InitializeShell(Window shell)
        {

            base.InitializeShell(shell);
            shell.Show();

        }

        protected override void RegisterTypes(
            IContainerRegistry containerRegistry
        )
        {

        }

        protected override void ConfigureModuleCatalog(
            IModuleCatalog moduleCatalog
        )
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<DataBaseServiceModule>();
        }

        //protected override void ConfigureRegionAdapterMappings(
        //    RegionAdapterMappings regionAdapterMappings
        //)
        //{
        //    base.ConfigureRegionAdapterMappings(regionAdapterMappings);

        //    regionAdapterMappings.RegisterMapping(
        //        typeof(Ribbon),
        //        Container.Resolve<RibbonRegionAdapter>()
        //    );

        //    regionAdapterMappings.RegisterMapping(
        //        typeof(StackPanel),
        //        Container.Resolve<StackPanelRegionAdapter>()
        //    );
        //}
    }
}
