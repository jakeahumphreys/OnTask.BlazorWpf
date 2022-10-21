using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using OnTask.BlazorWpf.Data.Activities;
using OnTask.BlazorWpf.Data.Collections;
using OnTask.BlazorWpf.Services;


namespace OnTask.BlazorWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddMudServices();

            serviceCollection.AddSingleton<IMessageService, MessageService>();

            serviceCollection.AddSingleton<CollectionRepository>();
            serviceCollection.AddSingleton<CollectionService>();
            serviceCollection.AddSingleton<ActivityRepository>();
            serviceCollection.AddSingleton<ActivityService>();

            Resources.Add("services", serviceCollection.BuildServiceProvider());

            InitializeComponent();
        }
    }
}
