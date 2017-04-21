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
using System.Text.RegularExpressions;
using System.Globalization;

namespace Kontener
{
    /// <summary>
    /// Interaction logic for AddParcel.xaml
    /// </summary>
    public partial class AddParcel : Window
    {
        bool correctParcelID = false;
        bool correctParcelSizeX = true;
        bool correctParcelSizeY = true;
        public AddParcel()
        {
            InitializeComponent();
        }
        private void btnAddParcel_Click(object sender, RoutedEventArgs e)
        {
            if (correctParcelID && correctParcelSizeX && correctParcelSizeY) //checking if sizes are correct
            {
                Parcel parcelItem = new Parcel(txtParcelNumberID.Text, 
                                                Double.Parse(txtParcelSizeX.Text, CultureInfo.InvariantCulture), 
                                                Double.Parse(txtParcelSizeY.Text, CultureInfo.InvariantCulture)); //create new parcel
                MainWindow.parcels.Add(parcelItem); //add parcel to list of parcels
                MessageBox.Show("Paczka została dodana do listy.", "Potwierdzenie", MessageBoxButton.OK, MessageBoxImage.Information); //message box with confirmation
                this.Close();   //closing window
            }
            else if(!correctParcelID) 
            {
                MessageBox.Show("Podaj numer paczki.", "Brak numeru paczki", MessageBoxButton.OK, MessageBoxImage.Error); //message box with information that number of parcel was not given
            }
            else
                MessageBox.Show("Wymiary paczki są niepoprawne. Popraw wymiary.", "Błędne dane", MessageBoxButton.OK, MessageBoxImage.Error);//message box with information that size of parcel is wrong
        }

        private void txtParcelSizeIsNumerable(object sender, RoutedEventArgs e)
        {
            TextBox parcelSizeTextBox = (TextBox) sender;
            parcelSizeTextBox.Text = parcelSizeTextBox.Text.ToString().Replace(",", "."); //change ',' to '.'
            Regex regex = new Regex(@"(^[1-4]{1}$)|(^(0\.[4-9])$)|(^([1-3]\.[0-9])$)|(^(4\.0)$)"); //verification is it number from range
            if (!regex.IsMatch(parcelSizeTextBox.Text))
            {
                MessageBox.Show("Zły wymiar paczki. Wpisz liczbę z zakresu. Maksymalnie jedna liczba po kropce.", "Podaj prawidłowe dane", MessageBoxButton.OK, MessageBoxImage.Error); //message box with information that size of parcel is wrong
                if (parcelSizeTextBox.Name == "txtParcelSizeX")
                    correctParcelSizeX = false;
                else
                    correctParcelSizeY = false;
            }
            else
            {
                if (parcelSizeTextBox.Name == "txtParcelSizeX") //checking which button is sender
                    correctParcelSizeX = true;
                else
                    correctParcelSizeY = true;
            }

        }
        private void txtParcelNumberIDIsNumerable(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$"); //user can input only numbers
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
                correctParcelID = false;
            }
            else
            { 
                e.Handled = false;
                correctParcelID = true;
            }
        }

        private void btnAddParcelCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); //closing window
        }
    }
}
