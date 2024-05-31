using System.Windows.Controls;
using PC_Configurator.core;
using PC_Configurator.models.products;

namespace PC_Configurator.views
{
    /// <summary>
    /// Interaction logic for CpuSelectionPage.xaml
    /// </summary>
    public partial class CpuSelectionPage : Page
    {
        readonly List<Cpu> _cpuList;
        private readonly Db _db = Db.GetInstance();

        public CpuSelectionPage()
        {
            InitializeComponent();
            if (MainWindow.Motherboard == null)
                _cpuList = _db.Cpus.ToList();
            else
                _cpuList = _db.Cpus.Where(u => u.Socket == MainWindow.Motherboard.Socket).ToList();
            CpusListView.ItemsSource = _cpuList;
        }
        public event EventHandler<Cpu> ItemSelected;
        public event EventHandler DeleteSelection;

        private void CpusListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ItemSelected.Invoke(this, _db.Cpus.FirstOrDefault(u=>u.Id==_cpuList[CpusListView.SelectedIndex].Id)!);
            NavigationService!.Content = null;
        }

        private void Border_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DeleteSelection?.Invoke(this, EventArgs.Empty);
        }
    }
}
