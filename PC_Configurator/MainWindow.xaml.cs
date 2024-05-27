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

using User = PC_Configurator.models.User;


namespace PC_Configurator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        DB db = DB.GetInstance();
        // User user = new User();
        // user.name = "user";
        // db.Users.Add(user);
        // db.SaveChanges();
    }
}