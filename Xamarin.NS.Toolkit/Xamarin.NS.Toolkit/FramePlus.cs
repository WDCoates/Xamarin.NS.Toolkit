﻿using Xamarin.Forms;

namespace Xamarin.NS.Toolkit
{
    public class FramePlus : Frame
    {
        public FramePlus(string text)
        {
            Label label = new Label {Text = $"text"};

            this.Content = label;
        }
    }
}
