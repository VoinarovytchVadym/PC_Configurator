using System.Windows;
using System.Windows.Controls;
using PC_Configurator.core;
using PC_Configurator.models.gpus;

namespace PC_Configurator.views;

public partial class GpuSelectionPage : Page
{
    public GpuSelectionPage()
    {
        InitializeComponent();
    }
    public event EventHandler<Gpu> ItemSelected;

    private void Submit_OnClick(object sender, RoutedEventArgs e)
    {
        
    }
}