using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
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

            serviceCollection.AddSingleton<CollectionRepository>();
            serviceCollection.AddSingleton<CollectionService>();

            Resources.Add("services", serviceCollection.BuildServiceProvider());

            InitializeComponent();
        }
    }
}
