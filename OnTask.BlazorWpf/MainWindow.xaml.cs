using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using OnTask.BlazorWpf.Data.Collections;


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

            Resources.Add("services", serviceCollection.BuildServiceProvider());

            InitializeComponent();
        }
    }
}
