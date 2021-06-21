using System;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace Lab_19
{
    public partial class MainWindow
    {
        private const string SETTINGS_PATH = @"appSettings.json";
        private AppSettings _appSettings;
        
        public MainWindow()
        {
            InitializeComponent();
            RestoreSettings();
        }

        private void RestoreSettings()
        {
            if (!TryLoadAndSetSettings()) {
                _appSettings = new AppSettings();
            }
        }
        
        private bool TryLoadAndSetSettings()
        {
            try {
                _appSettings = LoadSavedSettings();
                UpdateCurrentSettings(_appSettings);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        private AppSettings LoadSavedSettings()
        {
            if (!File.Exists(SETTINGS_PATH)) {
                throw new Exception("Settings file doesn't exist");
            }
            
            using (StreamReader streamReader = new StreamReader(SETTINGS_PATH)) {
                return JsonSerializer.Deserialize<AppSettings>(streamReader.ReadToEnd());
            }
        }

        private void UpdateCurrentSettings(AppSettings appSettings)
        {
            if (Application.Current.MainWindow != null) {
                Application.Current.MainWindow.Height = appSettings.HeightWindow;
                Application.Current.MainWindow.Width = appSettings.WidthWindow;
            }

            FirstCheckBox.IsChecked = appSettings.CheckBox1Status;
            SecondCheckBox.IsChecked = appSettings.CheckBox2Status;
            
            TextBox.Text = appSettings.TextBoxContent;
        }

        private void MainWindow_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (Application.Current.MainWindow == null) {
                return;
            }
            
            _appSettings.HeightWindow = Application.Current.MainWindow.Height;
            _appSettings.WidthWindow = Application.Current.MainWindow.Width;

            Save();
        }

        private void TextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox) {
                _appSettings.TextBoxContent = textBox.Text;
            }

            Save();
        }

        private void FirstCheckBox_OnClick(object sender, RoutedEventArgs e)
        {
            bool? isChecked = (sender as CheckBox)?.IsChecked;
            if (isChecked != null) {
                _appSettings.CheckBox1Status = isChecked.Value;
            }

            Save();
        }

        private void SecondCheckBox_OnClick(object sender, RoutedEventArgs e)
        {
            bool? isChecked = (sender as CheckBox)?.IsChecked;
            if (isChecked != null) {
                _appSettings.CheckBox2Status = isChecked.Value;
            }

            Save();
        }

        private void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter(SETTINGS_PATH)) {
                string settingsJson = JsonSerializer.Serialize(_appSettings);
                streamWriter.Write(settingsJson);
            }
        }
    }
}