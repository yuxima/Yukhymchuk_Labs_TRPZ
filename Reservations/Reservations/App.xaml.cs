using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Reservations.BussinessLogic;
using Reservations.Data;
using Reservations.User_Interface;

namespace Reservations
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;
        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IShopNetwork, ShopNetwork>();
            services.AddTransient<IDataController<ShopNetwork>, DataController<ShopNetwork>>();
            services.AddSingleton<MainWindow, MainWindow>();
            services.AddTransient<IModel, Model>();
            services.AddTransient<ViewModel, ViewModel>();
            services.AddTransient<DataLoader, DataLoader>();
            services.AddTransient<ReservationCreator, ReservationCreator>();
        }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            e.Handled = true;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new MainWindow();
            MainWindow.Show();
        }
    }
}
