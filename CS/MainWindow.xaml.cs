using DevExpress.Xpf.Core;
using System.Windows;

namespace How_to_Drag_and_Drop_Between_GridControls {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            gridControl1.ItemsSource = Staff.GetStaff1();
            gridControl2.ItemsSource = Staff.GetStaff2();
        }

        void OnDragRecordOver(object sender, DragRecordOverEventArgs e) {
            if(e.IsFromOutside && typeof(Employee).IsAssignableFrom(e.GetRecordType())) {
                e.Effects = DragDropEffects.Move;
                e.Handled = true;
            }
        }
    }
}
