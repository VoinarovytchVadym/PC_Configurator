using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic.ApplicationServices;
using PC_Configurator.core;
using PC_Configurator.models;
using PC_Configurator.models.cpus.company;
using PC_Configurator.models.cpus.product;
using PC_Configurator.models.gpus.company;
using PC_Configurator.models.gpus.product;


namespace PC_Configurator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DB db = DB.GetInstance();
        ICpuCompany cpuCompany = new Intel();
        ICpu cpu = cpuCompany.CreateProduct("Line", "Socket", 4, 8, 4.2, "Intel UHD Graphics 770");
        if (cpu is AmdCpu amdCpu)
            db.AmdCpus.Add(amdCpu);
        else if (cpu is IntelCpu intelCpu)
            db.IntelCpus.Add(intelCpu);
        db.SaveChanges();
    }
}