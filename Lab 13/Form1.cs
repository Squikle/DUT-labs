using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_13
{
    public partial class Form1 : Form
    {
        private readonly int _countOfNumbers = 16;
        private readonly List<int> _numbersSet;
        private readonly HashSet<int> _addedNumbers;
        private int _currentNumber = 1;
        
        public Form1()
        {
            InitializeComponent();
            _addedNumbers = new HashSet<int>(_countOfNumbers);
            _numbersSet = new List<int>(_countOfNumbers);
            InitButtonsLayout();
        }

        private void InitButtonsLayout()
        {
            Random random = new Random();
            _numbersSet.AddRange(Enumerable.Range(1, 16));
            
            int size = 35;
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < _countOfNumbers / 4; j++) {
                    Button button = new Button {
                        Size = new Size(size, size), 
                        Location = new Point((size + 5) * i, (size + 5) * j)
                    };
                    button.Click += NextButtonClick;
                        
                    int number = RandomNumber(random);
                    _addedNumbers.Add(number);

                    button.Text = number.ToString();
                    
                    Task2.Controls.Add(button);
                }
            }
            
            _addedNumbers.Clear();
        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            if (currentButton != null && _currentNumber == int.Parse(currentButton.Text)) {
                if (_currentNumber == _countOfNumbers) {
                    Reset();
                    TextBox.Text = "Молодець!";
                    TextBox.Dock = DockStyle.Bottom;
                    TextBox.ReadOnly = true;
                    Task2.Controls.Add(TextBox);
                }
                currentButton.Visible = false;
                _currentNumber++;
                ShuffleNumbers();
                return;
            }

            Reset();
        }

        private void Reset()
        {
            _currentNumber = 1;
            Task2.Controls.Clear();
            InitButtonsLayout();
        }        
        private void ShuffleNumbers()
        {
            Random random = new Random();
            List<Button> buttons = new List<Button>();
            List<string> currentButtonValues = new List<string>();
            foreach (object currentElement in Task2.Controls) {
                if (currentElement is Button button) {
                    if (button.Visible) {
                        currentButtonValues.Add(button.Text);
                        buttons.Add(button);
                    }
                }
            }
                
            int n = currentButtonValues.Count;  
            while (n > 1) {  
                n--;  
                int k = random.Next(n + 1);  
                string value = currentButtonValues[k];  
                currentButtonValues[k] = currentButtonValues[n];  
                currentButtonValues[n] = value;  
            }

            for (int i = 0; i < currentButtonValues.Count; i++) {
                buttons[i].Text = currentButtonValues[i];
            }
        }
        private int RandomNumber(Random random)
        {
            int number;
            do {
                number = _numbersSet[random.Next(_countOfNumbers)];
            } while (_addedNumbers.Contains(number));

            return number;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox.Text)) {

                MessageBox.Show("Введите текст!");
                TextBox.BackColor = Color.NavajoWhite;
                return;
            }
            TextBox.BackColor = Color.White;
            ComboBox.Items.Add(TextBox.Text);
            TextBox.Text = string.Empty;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox.Text)) {
                MessageBox.Show("Введите текст!");
                TextBox.BackColor = Color.NavajoWhite;
                return;
            }

            TextBox.BackColor = Color.White;
            if (!ComboBox.Items.Contains(TextBox.Text)) {
                MessageBox.Show("Такого текста нет!");
                return;
            }
            ComboBox.Items.Remove(TextBox.Text);
            TextBox.Text = string.Empty;
        }
    }
}