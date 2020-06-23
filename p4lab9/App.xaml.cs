using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows;

namespace p4lab9
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var builder = new ContainerBuilder();

            //którą klase rejestrujemy do kontenera. Self sam zczytuje nazwe
            builder.RegisterType<MainWindow>().AsSelf();
           // builder.RegisterType<LabelGenerator>().As<IControlGenerator>();
            builder.RegisterType<ButtonGenerator>().As<IControlGenerator>();
            builder.RegisterType<PanelFiller>().AsImplementedInterfaces();

            var container = builder.Build();

            using(var scope = container.BeginLifetimeScope())
            {
                var window = scope.Resolve<MainWindow>();
                window.Show();
            }
        }
    }
}
