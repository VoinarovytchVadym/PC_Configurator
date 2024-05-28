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
using PC_Configurator.models.gpus.company;
using PC_Configurator.models.gpus.product;


namespace PC_Configurator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DB db = DB.GetInstance();
        ICompany company = new AMD();
        IGpu gpu = company.CreateProduct("model", "vandor", "chip", 8, "type");
        if (company is NVIDIA)
        {
            db.NvidiaGpus.Add((NvidaGpu)gpu);
            db.SaveChanges();
        }

        if (company is AMD)
        {
            db.AmdGpus.Add((AmdGpu)gpu);
            db.SaveChanges();
        }
    }
}