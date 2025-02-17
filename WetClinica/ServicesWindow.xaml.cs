using System.Windows;

namespace WetClinica
{
    public partial class ServicesWindow : Window
    {
        public ServicesWindow()
        {
            InitializeComponent();
            ServicesListBox.ItemsSource = new string[]
            {
                "Консультация ветеринара",
                "Вакцинация",
                "Хирургические операции",
                "Диагностика и анализы",
                "Стационарное лечение"
            };
        }
    }
}
