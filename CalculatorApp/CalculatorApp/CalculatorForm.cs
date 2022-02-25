using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        private string _defaultValue, _operation;
        private readonly Regex _regexFloat = new Regex(@"^[0-9]+(,\d+)?$"); 
        private double _value, _savedResult;
        private bool _operationIsPressed, _equalIsPressed, _msIsPressed;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _defaultValue = "0";
            _value = 0;
            _savedResult = 0;
            _operation = String.Empty;
            _operationIsPressed = _equalIsPressed = _msIsPressed = false;
        }

       
        private void buttonAC_Click(object sender, EventArgs e)
        {
            _value = 0;
            TextLabel.Text = _defaultValue;
        }

        private void ClickNumberButton(object sender, EventArgs e)
        {
            if (TextLabel.Text.Equals("0") || _operationIsPressed || _equalIsPressed)
                 TextLabel.Text = String.Empty; 
            _operationIsPressed = _equalIsPressed = _msIsPressed = false;
            Button button = (Button)sender;
            try
            {
                string temp = TextLabel.Text + button.Text;
                TextLabel.Text = temp;
                if (button.Text == @",")
                    temp += "2";
                if (!_regexFloat.IsMatch(temp) )
                {
                    throw new Exception("wrong value");
                }
               
            }
            catch (Exception exception)
            {
                TextLabel.Text = TextLabel.Text.Remove(TextLabel.Text.Length-1); // удалить лишнюю ,
                Debug.WriteLine(exception.Message);
                MessageBox.Show(exception.Message);
            }
            finally
            {
                Debug.WriteLine("Number Button is clicked");
            }

        }
        
        private void ClickEqualButton(object sender, EventArgs e)
        {
            tempTextLabel.Text = String.Empty;
            switch (_operation)
            {
                case "+":
                    TextLabel.Text = (_value += Double.Parse(TextLabel.Text)).ToString(CultureInfo.InvariantCulture); 
                    break;
                case "-":
                    TextLabel.Text = (_value -= Double.Parse(TextLabel.Text)).ToString(CultureInfo.InvariantCulture); 
                    break;
                case "*":
                    TextLabel.Text = (_value *= Double.Parse(TextLabel.Text)).ToString(CultureInfo.InvariantCulture); 
                    break;
                case "/":
                    TextLabel.Text = (_value /= Double.Parse(TextLabel.Text)).ToString(CultureInfo.InvariantCulture); 
                    break;
                case "%":
                    TextLabel.Text = (_value %= Double.Parse(TextLabel.Text)).ToString(CultureInfo.InvariantCulture); 
                    break;
                case "$":
                    _value = Math.Floor(_value);
                    TextLabel.Text = _value.ToString(CultureInfo.InvariantCulture);
                    break;
                case "^":
                    _value = Math.Pow(_value, Double.Parse(TextLabel.Text));
                    TextLabel.Text = _value.ToString(CultureInfo.InvariantCulture);
                    break;
            }

            _equalIsPressed = true;
        }

        private void ClickIntPartButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _operation = button.Text;
            _value = Double.Parse(TextLabel.Text);
            _operationIsPressed = true;
            tempTextLabel.Text = _value + @" " + _operation;
            TextLabel.Text = Math.Floor(_value).ToString(CultureInfo.InvariantCulture); 
        }
        private void ClickOperationButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _operation = button.Text;
            if(!_msIsPressed)
                _value = Double.Parse(TextLabel.Text);
            _operationIsPressed = true;
            tempTextLabel.Text = _value + @" " + _operation;
        }
        private void buttonMS_Click(object sender, EventArgs e)
        {
            _savedResult = _value;
            saveLabel.Text = $@"Saved Result: {_savedResult}";
        }
        private void buttonMR_Click(object sender, EventArgs e)
        {
            _value = _savedResult;
            _msIsPressed = true;
        }

    }
}