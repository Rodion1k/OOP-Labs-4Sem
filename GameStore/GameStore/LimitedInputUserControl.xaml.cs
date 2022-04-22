using System.Windows;
using System.Windows.Controls;

namespace GameStore
{
    public partial class LimitedInputUserControl : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string),
            typeof(LimitedInputUserControl),
            new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnTextPropertyChanged),
                new CoerceValueCallback(OnCoerceTextProperty)), new ValidateValueCallback(ValidateTextProperty));

        private static bool ValidateTextProperty(object value)
        {
            string text = value as string;
            if (text != null)
            {
                return text.Length <= 10;
            }

            return true;
        }

        private static object OnCoerceTextProperty(DependencyObject d, object basevalue)
        {
            string value = (string)basevalue;
            if (value.Contains(","))
            {
                return value.Replace(",", string.Empty);
            }

            return basevalue;
        }

        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            LimitedInputUserControl control = d as LimitedInputUserControl;
            if (control != null)
            {
                control.OnTextChanged((string)e.OldValue, (string)e.NewValue);
            }
        }

        private void OnTextChanged(string eOldValue, string eNewValue)
        {
            if (eNewValue.Length > MaxLength)
            {
                Text = eOldValue;
            }
        }

        public LimitedInputUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public int MaxLength { get; set; }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        private void TxtLimitedInput_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = txtLimitedInput.Text;
        }
    }
}