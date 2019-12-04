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
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ManipulatedBBox"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ManipulatedBBox;assembly=ManipulatedBBox"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:ManipulatedContentControl/>
    ///
    /// </summary>
    public class ManipulatedContentControl : ContentControl
    {
        public IManipulated manipulated;

        public TransformGroup transformGroup = new TransformGroup();
        public ScaleTransform scaleTransform = new ScaleTransform();
        public SkewTransform skewTransform = new SkewTransform();
        public RotateTransform rotateTransform = new RotateTransform();
        public TranslateTransform translateTransform = new TranslateTransform();

        static ManipulatedContentControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ManipulatedContentControl), new FrameworkPropertyMetadata(typeof(ManipulatedContentControl)));
        }

        public ManipulatedContentControl()
        {
            rotateTransform.Angle = 0;
            transformGroup.Children.Add(scaleTransform);
            transformGroup.Children.Add(skewTransform);
            transformGroup.Children.Add(rotateTransform);
            transformGroup.Children.Add(translateTransform);
            this.RenderTransform = transformGroup;
        }

        public void change_focus()
        {
            bool selected = System.Windows.Controls.Primitives.Selector.GetIsSelected(this);
            System.Windows.Controls.Primitives.Selector.SetIsSelected(this, !selected);
        }
    }
}
