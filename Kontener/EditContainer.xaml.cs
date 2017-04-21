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
    /// Interaction logic for EditContainer.xaml
    /// </summary>
    public partial class EditContainer : Window
    {
        bool correctContainerSizeX = true;
        bool correctContainerSizeY = true;
        public EditContainer()
        {
            InitializeComponent();
            txtContainerSizeX.Text = MainWindow.container.containerSizeX.ToString(CultureInfo.InvariantCulture); //assign size of the container
            txtContainerSizeY.Text = MainWindow.container.containerSizeY.ToString(CultureInfo.InvariantCulture);
        }
        private void txtContainerSizeXIsNumerable(object sender, RoutedEventArgs e)
        {
            txtContainerSizeX.Text = txtContainerSizeX.Text.ToString().Replace(",", "."); //change ',' to '.' in textbox
            Regex regex = new Regex(@"(^[1-5]{1}$)|(^([1-4]\.[0-9])$)|(^(5\.0)$)"); //verification is it number from range
            if (!regex.IsMatch(txtContainerSizeX.Text))
            {
                MessageBox.Show("Zły wymiar kontenera. Wpisz liczbę z zakresu. Maksymalnie jedna liczba po kropce.", "Podaj prawidłowe dane", MessageBoxButton.OK, MessageBoxImage.Error);
                correctContainerSizeX = false;
            }
            else
            {
                correctContainerSizeX = true;
            }
        }
        private void txtContainerSizeYIsNumerable(object sender, RoutedEventArgs e)
        {
            txtContainerSizeY.Text = txtContainerSizeY.Text.ToString().Replace(",", "."); //change ',' to '.' in textbox
            Regex regex = new Regex(@"(^[5-9]{1}$)|(^1[0-9]{1}$)|(^20$)|(^([5-9]\.[0-9])$)|(^(1[0-9]\.[0-9])$)|(^(20\.0)$)"); //verification is it number from range
            if (!regex.IsMatch(txtContainerSizeY.Text))
            {
                MessageBox.Show("Zły wymiar kontenera. Wpisz liczbę z zakresu. Maksymalnie jedna liczba po kropce.", "Podaj prawidłowe dane", MessageBoxButton.OK, MessageBoxImage.Error); //messagebox with information that size is wrong
                correctContainerSizeY = false;
            }
            else
            {
                correctContainerSizeY = true;
            }
        }

        private void btnEditContainerConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (correctContainerSizeX && correctContainerSizeY) //checking if user gives correct container size X and Y
            {
                MainWindow.container.containerSizeX = Double.Parse(txtContainerSizeX.Text, CultureInfo.InvariantCulture); //changing the size of container
                MainWindow.container.containerSizeY = Double.Parse(txtContainerSizeY.Text, CultureInfo.InvariantCulture);
                MessageBox.Show("Rozmiar kontenera został zmieniony.", "Potwierdzenie", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close(); //closing window after change
            }
            else //if wrong then message show
            {
                MessageBox.Show("Dane są niepoprawne. Popraw dane.", "Błędne dane", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEditContainerCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); //closing window after click cancel
        }
    }
}
