using Xamarin.Forms;

namespace Xamarin.NS.Toolkit
{
    public class CountedLabel : Label
    {
        static readonly BindablePropertyKey WordCountKey =
            BindableProperty.CreateReadOnly("WordCount", typeof(int),
                                            typeof(CountedLabel), 0);

        public static readonly BindableProperty WordCountProperty = WordCountKey.BindableProperty;

        public CountedLabel()
        {

            //Set the WordCount property when the Text property changes.
            PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName != "Text") return;
                WordCount = string.IsNullOrEmpty(Text) ? 0 : Text.Split(' ', '-', '\u2014').Length;
            };

        }

        public int WordCount
        {
            private set => SetValue(WordCountKey, value);
            get => (int)GetValue(WordCountProperty);
        }
    }
}