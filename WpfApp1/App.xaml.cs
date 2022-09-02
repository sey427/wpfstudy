using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Views;

namespace WpfApp1;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public sealed partial class App : Application
{
    //public App()
    //{
    //    Services = ConfigureServices();

    //    this.InitializeComponent();
    //}

    //public new static App Current => (App)Application.Current;

    //public IServiceProvider Services { get; }

    //private static IServiceProvider ConfigureServices()
    //{
    //    var services = new ServiceCollection();
    //    services.AddSingleton<Window8>();
    //    return services.BuildServiceProvider();
    //}

    //protected override void OnStartup(StartupEventArgs e)
    //{
    //    base.OnStartup(e);
    //}
}
