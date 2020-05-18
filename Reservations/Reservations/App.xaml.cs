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
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Reservations.BussinessLogic.Interfaces;
using Reservations.BussinessLogic.Services;

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
            //var connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            var connection = @"data source=(localdb)\MSSQLLocalDB;Initial Catalog=reservation;Integrated Security=True;";
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

            services.AddTransient<IShopNetwork, ShopNetwork>();
            services.AddTransient<IDataController<ShopNetwork>, DataController<ShopNetwork>>();
            services.AddSingleton<MainWindow, MainWindow>();
            services.AddTransient<IModel, Model>();
            services.AddTransient<ViewModel, ViewModel>();
            services.AddTransient<DataLoader, DataLoader>();
            services.AddTransient<ReservationCreator, ReservationCreator>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IShopService, ShopService>();
            services.AddScoped<IProductInShopService, ProductInShopService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton(new MapperConfiguration(conf => conf.AddProfile(new AutoMapperProfile())).CreateMapper());
        }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            e.Handled = true;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            ViewModel viewModel = serviceProvider.GetService<ViewModel>();
            new MainWindow { DataContext = viewModel };
            MainWindow.Show();
        }
    }
}
