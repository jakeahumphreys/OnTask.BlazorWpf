using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;


namespace OnTask.BlazorWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddMudServices();

            Resources.Add("services", serviceCollection.BuildServiceProvider());

            InitializeComponent();
        }
    }
}
