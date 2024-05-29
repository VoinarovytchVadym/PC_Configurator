using System.Windows.Controls;
using PC_Configurator.models.gpus;

namespace PC_Configurator.views;

public partial class CurrentConfigurationPage : Page
{
    public CurrentConfigurationPage(Gpu? gpu)
    {
        InitializeComponent();
    }
}