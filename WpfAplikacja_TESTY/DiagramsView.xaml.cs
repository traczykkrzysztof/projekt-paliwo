using FuelApplication.ViewModelClasses;
using System;
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.DataVisualization.Charting;
using System.Collections.Generic;
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

namespace WpfAplikacja_TESTY
{
    /// <summary>
    /// Interaction logic for DiagramsView.xaml
    /// </summary>
    public partial class DiagramsView : UserControl
    {
        public DiagramsView()
        {
            InitializeComponent();
            DataContext = new DiagramsViewModel();
        }
    }
}
