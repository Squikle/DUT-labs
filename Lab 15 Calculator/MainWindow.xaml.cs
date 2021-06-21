using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab_15_Calculator
{
    public partial class MainWindow
    {
        private const int KEYBOARD_BUTTONS_COUNT = 16;
        private const int BUTTON_SIZE = 64;
        private bool _operationActive;
        
        private readonly string[] _symbols = { "7", "8", "9", "/", "4", "5", "6", "*", "1", "2", "3", "-", "0", ".", "=", "+" };
        
        public MainWindow()
        {
            ResizeMode = ResizeMode.NoResize;
            InitializeComponent();
            ConstructCalculator();
        }

        private void ConstructCalculator()
        {
            Keyboard.ItemHeight = BUTTON_SIZE;
            Keyboard.ItemWidth = BUTTON_SIZE;
            
            for (int i = 0; i < KEYBOARD_BUTTONS_COUNT; i++) {
                Keyboard.Children.Add(CreateLayoutButton(i));
            }
        }

        private Button CreateLayoutButton(int symbol)
        {
            Button button = new Button
            {
                Background = new SolidColorBrush(Colors.Gray),
                BorderBrush = new SolidColorBrush(Colors.White),
                FontSize= 18,
                Content = _symbols[symbol],
            };

            button.Click += LayoutButtonClick;
            return button;
        }

        private void ButtonChangeSignClick(object sender, RoutedEventArgs e)
        {
            double number = double.Parse(NumberField.Text);

            if (number == 0) {
                return;
            }

            NumberField.Text =
                number > 0 ? "-" + NumberField.Text : (number * -1).ToString(CultureInfo.InvariantCulture);
        }
        
        private void ResetOnClearButton(object sender, RoutedEventArgs e)
        {
            NumberField.Clear();
            ArithmeticOperations.Reset();
            NumberField.Text = "0";
        }
        
        private void LayoutButtonClick(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button)) {
                return;
            }

            if (!double.TryParse(button.Content.ToString(), out _)) {
                switch (button.Content.ToString()) {
                    case "-":
                        _operationActive = true;
                        UpdateResult(ArithmeticOperations.ComputeResult(button.Content.ToString(),
                            double.Parse(NumberField.Text)));
                        break;
                    case "+":
                        _operationActive = true;
                        UpdateResult(ArithmeticOperations.ComputeResult(button.Content.ToString(),
                            double.Parse(NumberField.Text)));
                        break;
                    case "/":
                        _operationActive = true;
                        UpdateResult(ArithmeticOperations.ComputeResult(button.Content.ToString(),
                            double.Parse(NumberField.Text)));
                        break;
                    case "*":
                        _operationActive = true;
                        UpdateResult(ArithmeticOperations.ComputeResult(button.Content.ToString(),
                            double.Parse(NumberField.Text)));
                        break;
                    case ".":
                        if (_operationActive) {
                            return;
                        }
                        if (NumberField.Text.Any(t => t == '.')) {
                            return;
                        }
                        NumberField.Text += ".";
                        break;
                    case "=":
                        UpdateResult(ArithmeticOperations.ComputeResult(button.Content.ToString(),
                            double.Parse(NumberField.Text)));
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }
            else {
                if (_operationActive) {
                    NumberField.Clear();
                    _operationActive = !_operationActive;
                }

                if (NumberField.Text != "0" && NumberField.Text != "∞" && NumberField.Text != "-∞") {
                    NumberField.Text += button.Content.ToString();
                }
                else {
                    NumberField.Text = button.Content.ToString();
                }
            }
        }
        
        private void UpdateResult(string result)
        {
            if (!string.IsNullOrEmpty(result)) {
                NumberField.Text = result;
            }
        }
    }
}