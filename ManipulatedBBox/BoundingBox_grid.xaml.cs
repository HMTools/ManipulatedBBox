using System;
using System.Collections.Generic;
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

namespace ManipulatedBBox
{
    /// <summary>
    /// Interaction logic for BoundingBox_grid.xaml
    /// </summary>
    public partial class BoundingBox_grid : _BBox
    {

        public BoundingBox_grid(int col_span=1, int row_span=1)
        {
            InitializeComponent();
            control = cont;

            Grid.SetColumnSpan(grid_container, col_span);
            Grid.SetColumnSpan(control, col_span);
            Grid.SetRowSpan(grid_container, row_span);
            Grid.SetRowSpan(control, row_span);

        }

        private void control_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            uc.change_focus();
        }
    }
}
