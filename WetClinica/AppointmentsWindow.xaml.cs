using System.Collections.Generic;
using System.Windows;

namespace WetClinica
{
    public partial class AppointmentsWindow : Window
    {
        private static List<string> appointments = new List<string>();

        public AppointmentsWindow()
        {
            InitializeComponent();
            AppointmentsListBox.ItemsSource = appointments;
        }

        public static void AddAppointment(string service, string dateTime, string contact)
        {
            appointments.Add($"{service} - {dateTime} (Контакт: {contact})");
        }
    }
}
