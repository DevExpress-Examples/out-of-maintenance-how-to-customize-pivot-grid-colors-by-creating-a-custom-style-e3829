using System.Windows;
using DXPivotGrid_CustomizeBrushes.DataSet1TableAdapters;

namespace DXPivotGrid_CustomizeBrushes {
    public partial class MainWindow : Window {
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataAdapter.GetData();
        }
    }
}
