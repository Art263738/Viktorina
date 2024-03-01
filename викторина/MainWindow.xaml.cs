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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace викторина
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           


        }
       
       

        private void CheckAnswersButton_Click(object sender, RoutedEventArgs e)
        {
            var correctAnswers = new[] { "1_2", "2_1", "3_4", "4_3", "5_4", "6_4", "7_2", "8_3", "9_4", "10_2" };

            var userAnswers = new string[10];
            userAnswers[0] = GetSelectedAnswer(Question1);
            userAnswers[1] = GetSelectedAnswer(Question2);
            userAnswers[2] = GetSelectedAnswer(Question3);
            userAnswers[3] = GetSelectedAnswer(Question4);
            userAnswers[4] = GetSelectedAnswer(Question5);
            userAnswers[5] = GetSelectedAnswer(Question6);
            userAnswers[6] = GetSelectedAnswer(Question7);
            userAnswers[7] = GetSelectedAnswer(Question8);
            userAnswers[8] = GetSelectedAnswer(Question9);
            userAnswers[9] = GetSelectedAnswer(Question10);
            // Добавляем вызовы GetSelectedAnswer для каждого нового вопроса

            int correctCount = 0;
            var results = new string[10];

            for (int i = 0; i < 10; i++)
            {
                results[i] = userAnswers[i] == correctAnswers[i] ? (correctCount++, "Правильно").Item2 : "Неправильно";
            }


          
            string grade = GetGrade(correctCount);

      /*      string resultMessage = $"Ваш результат: {correctCount} из 10\nОценка: {grade}";

            ResultLabel.Content = resultMessage;*/


            // создаем форму для вывода результатов
            var resultForm = new Itog();

            resultForm.CorrectAnswers = correctCount;
            resultForm.Grade = grade;
            // передаем результаты
            resultForm.CorrectAnswers = correctCount;
            resultForm.Grade = grade;

       

            resultForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            resultForm.ShowDialog();

            // ТОЛЬКО ПОСЛЕ ЭТОГО можно закрывать текущую форму
            this.Close();
        }

        private string GetSelectedAnswer(ListView listView)
        {
            foreach (var item in listView.Items)
            {
                var radioButton = item as RadioButton;
                if (radioButton != null && radioButton.IsChecked == true)
                {
                    return radioButton.Tag.ToString();
                }
            }

            return null;
        }

        private string GetGrade(int correctCount)
        {
            if (correctCount == 10)
                return "5";
            else if (correctCount >= 8)
                return "4";
            else if (correctCount >= 5)
                return "3";
            else
                return "2";
        }
    }
}

