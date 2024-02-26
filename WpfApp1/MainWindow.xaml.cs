using System.Windows;

namespace WpfApp1
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
        
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TbNumberX.Text, out double x))
            {
                MessageBox.Show("Введены некорректные данные");
                return;
            }

            TextBlockAnswer.Text = CheckNumberX(x);

        }

        /// <summary>
        /// Проверяет принадлежность точки закрашенным областям
        /// </summary>
        /// <param name="x">Координата точки на прямой (x — действительное число)</param>
        /// <returns>Возвращает строку с ответом</returns>
        public static string CheckNumberX(double x)
        {
            if (x >= -9 && x <= 3 || x >= 5 && x <= 20)
            {
                return "принадлежит";
            }

            return "не принадлежит";
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
