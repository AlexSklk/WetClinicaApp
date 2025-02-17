using System;
using System.Collections.Generic;
using System.Windows;

namespace WetClinica
{
    public partial class MainWindow : Window
    {
        private List<Pet> pets = new List<Pet>();

        public MainWindow()
        {
            InitializeComponent();
            PetsListBox.ItemsSource = pets;
        }

        private void AddPetButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PetNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(OwnerNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(SpeciesTextBox.Text))
            {
                var newPet = new Pet
                {
                    Name = PetNameTextBox.Text,
                    Owner = OwnerNameTextBox.Text,
                    Species = SpeciesTextBox.Text
                };
                pets.Add(newPet);
                PetsListBox.Items.Refresh();
            }
        }

        private void OpenServicesWindow_Click(object sender, RoutedEventArgs e)
        {
            ServicesWindow servicesWindow = new ServicesWindow();
            servicesWindow.Show();
        }

        private void OpenBookingWindow_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            bookingWindow.Show();
        }

        private void OpenAppointmentsWindow_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsWindow appointmentsWindow = new AppointmentsWindow();
            appointmentsWindow.Show();
        }
    }

    public class Pet
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Species { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Species}) - Владелец: {Owner}";
        }
    }
}
