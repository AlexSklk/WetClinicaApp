using System;
using System.Windows;
using System.Windows.Controls;

namespace WetClinica
{
    public partial class BookingWindow : Window
    {
        public BookingWindow()
        {
            InitializeComponent();
        }

        private void BookAppointment_Click(object sender, RoutedEventArgs e)
        {
            string service = (ServiceComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            string dateTime = DateTimeTextBox.Text;
            string contact = ContactTextBox.Text;

            if (!string.IsNullOrWhiteSpace(service) && !string.IsNullOrWhiteSpace(dateTime) && !string.IsNullOrWhiteSpace(contact))
            {
                AppointmentsWindow.AddAppointment(service, dateTime, contact);
                MessageBox.Show("Запись успешно добавлена!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля.");
            }
        }
    }
}
