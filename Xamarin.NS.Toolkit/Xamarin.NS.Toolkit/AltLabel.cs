using Xamarin.Forms;

namespace Xamarin.NS.Toolkit
{
    public class AltLabel : Label
    {
        public static readonly BindableProperty PointSizeProperty =
            BindableProperty.Create("PointSize", typeof(double), typeof(AltLabel), 8d,
                propertyChanged: OnPointSizeChanged
            
            );

        public AltLabel()
        {
            SetLabelFontSize((double) PointSizeProperty.DefaultValue);
        }

        public double PointSize
        {
            set => SetValue(PointSizeProperty, value);
            get => (double)GetValue(PointSizeProperty);
        }
        
        private void SetLabelFontSize(double pointSize)
        {
            FontSize = 160 * pointSize / 72;
        }

        private static void OnPointSizeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AltLabel aLabel = (AltLabel) bindable;

            ((AltLabel) bindable).OnPointSizeChanged((double)oldValue, (double)newValue);
        }



        void OnPointSizeChanged(double oldValue, double newValue)
        {
            SetLabelFontSize(newValue);
        }
    }
}
