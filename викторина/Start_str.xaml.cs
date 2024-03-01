using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Логика взаимодействия для Start_str.xaml
    /// </summary>
    public partial class Start_str : Window
    {
        MediaPlayer playClickSound = new MediaPlayer();//для воспроизведения звковых файлов
        Uri ClickedSound;//где файл со звуком
        public Start_str()
        {
            InitializeComponent();
            ClickedSound = new Uri("C:\\Users\\Хрюша\\Desktop\\ФУ\\WFP\\викторина\\викторина\\pictures\\1.mp3");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();


            playClickSound.Open(ClickedSound);
            playClickSound.Play();
        }
    }
}
