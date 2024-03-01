using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace викторина
{
    /// <summary>
    /// Логика взаимодействия для Itog.xaml
    /// </summary>
    public partial class Itog : Window
    {
        public Itog()
        {
            InitializeComponent();
            Loaded += ResultForm_OnLoaded;

        }
        public int CorrectAnswers { get; set; }
        public string Grade { get; set; }

        private void ResultForm_OnLoaded(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = $"Ваш результат: {CorrectAnswers} из 10\nОценка: {Grade}";
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
