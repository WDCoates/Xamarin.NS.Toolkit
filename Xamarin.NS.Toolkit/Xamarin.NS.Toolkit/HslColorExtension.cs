using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.NS.Toolkit
{
    public class HslColorExtension : IMarkupExtension
    {
        public double H { get; set;}
        public double S { get; set; }
        public double L { get; set; }
        public double A { get; set; }

        public HslColorExtension()
        {
            A = 1;
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromHsla(H, S, L, A);
        }

        public object PureBlack()
        {
            return Color.FromHsla(0, 0, 0);
        }
    }
}
