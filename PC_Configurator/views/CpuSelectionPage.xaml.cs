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
            _cpuList = _db.Cpus.ToList();
            CpusListView.ItemsSource = _cpuList;
        }
        public event EventHandler<Cpu> ItemSelected;

        private void CpusListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ItemSelected.Invoke(this, _db.Cpus.FirstOrDefault(u=>u.Id==_cpuList[CpusListView.SelectedIndex].Id)!);
            NavigationService!.Content = null;
        }
    }
}
