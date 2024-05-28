using System.Windows;
using System.Windows.Forms;
using PC_Configurator.core;
using PC_Configurator.models.cpus;
using PC_Configurator.models.cpus.companies;
using PC_Configurator.models.gpus;
using PC_Configurator.models.gpus.companies;
using PC_Configurator.models.pcs;
using PC_Configurator.models.pcs.builders;
using PC_Configurator.models.rams;
using PC_Configurator.models.rams.companies;
using PC_Configurator.views;
using AMD = PC_Configurator.models.gpus.companies.AMD;


namespace PC_Configurator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DB db = DB.GetInstance();
    }

    private void Border_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        TestPage testPage = new TestPage();
        testPage.ItemSelected += SelectionPage_ItemSelected;
        MainFrame.Content = testPage;
    }
    private void SelectionPage_ItemSelected(object sender, string selectedItem)
    {
        
    }
}
