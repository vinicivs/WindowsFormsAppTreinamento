using ClassLibraryBus;
using ClassLibraryMd;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTreinamento
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        // ObservableCollection para armazenar os CEPs
        readonly ObservableCollection<MdClass> ceps = new ObservableCollection<MdClass>();

        public MainWindow()
        {
            // Inicializa os componentes da janela
            InitializeComponent();
            // Carrega os CEPs ao iniciar a aplicação
            ceps = new ObservableCollection<MdClass>(BusClass.Listagem());
            // Define o ItemsSource do DataGrid para a coleção de CEPs
            dgCeps.ItemsSource = ceps;
        }
    }
}
