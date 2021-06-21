using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab_16
{
    public partial class MainWindow
    {
        private int _numberNow = 1;
        private readonly HashSet<int> _tempNumbers;
        private readonly Random _random;
        private readonly List<int> _numbers;
        private const int BUTTON_SIZE = 64;
        private const int BUTTONS_COUNTER = 16;
        
        public MainWindow()
        {
            _tempNumbers = new HashSet<int>();
            _random = new Random();
            _numbers = new List<int>();
            
            InitializeComponent();
            CreateButtons();
        }

        private void AddButtonOnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SentenceTextBox.Text)) {
                return;
            }
            
            SentenceBox.Items.Add(SentenceTextBox.Text);
            SentenceTextBox.Text = string.Empty;
        }

        private void RemoveButtonOnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SentenceTextBox.Text)) {
                return;
            }

            if (!SentenceBox.Items.Contains(SentenceTextBox.Text)) {
                return;
            }
            
            SentenceBox.Items.Remove(SentenceTextBox.Text);
            SentenceTextBox.Text = string.Empty;
        }
        
        private void CreateButtons()
        {
            _numbers.AddRange(Enumerable.Range(1, BUTTONS_COUNTER));

            Buttons.ItemHeight = BUTTON_SIZE;
            Buttons.ItemWidth = BUTTON_SIZE;
            
            for (int i = 0; i < BUTTONS_COUNTER; i++) {
                int number = RandomNumber(0, BUTTONS_COUNTER);
                _tempNumbers.Add(number);
                Buttons.Children.Add(CreateButtonForLayout(number));
            }
            
            _tempNumbers.Clear();
        }

        private Button CreateButtonForLayout(int number)
        {
            Button button = new Button
            {
                Background = new SolidColorBrush(Colors.Gray),
                BorderBrush = new SolidColorBrush(Colors.White),
                FontSize = 18,
                Content = number.ToString(),
                Margin = new Thickness(8)
            };
            
            button.Click += ButtonClick;
            return button;
        }
        
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button)) {
                return;
            }

            if (!int.TryParse(button.Content.ToString(), out int number) || number != _numberNow) {
                ResetButton();
            }
            else {
                if (_numberNow == 16) {
                    ResetButton();
                    return;
                }

                button.IsEnabled = false;
                _numberNow++;
                ChangeNumber();
            }
        }
        
        private void ChangeNumber()
        {
            foreach (object children in Buttons.Children) {
                if (!(children is Button button)) {
                    continue;
                }

                if (!button.IsEnabled) {
                    continue;
                }
                
                int number = RandomNumber(_numberNow - 1, BUTTONS_COUNTER);
                _tempNumbers.Add(number);
                button.Content = number.ToString();
            }
            
            _tempNumbers.Clear();
        }
        
        private void ResetButton()
        {
            _numberNow = 1;
            Buttons.Children.Clear();
            CreateButtons();
        }
        
        private int RandomNumber(int min,int max)
        {
            int number;
            
            do {
                int index = _random.Next(min, max);
                number = _numbers[index];
            } while (_tempNumbers.Contains(number));
            
            return number;
        }
    }
}