using System;
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

namespace ManipulatedBBox
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class BoundingBox : _BBox
    {
        //public BUC_Manipulated uc;
        //public ManipulatedContentControl control;

        public BoundingBox()
        {
            InitializeComponent();
            control = cont;
        }

        //trying to move to base -- need
        private void control_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            uc.change_focus();
        }
    }
}