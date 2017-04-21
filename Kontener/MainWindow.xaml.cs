using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Kontener
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Parcel> parcels = new ObservableCollection<Parcel>(); //list of parcel
        public static ObservableCollection<Parcel> parcelsChoosen = new ObservableCollection<Parcel>(); //list of choosen parcels
        Parcel[] parcelsChoosenSortBySize = null; //table of parcels sorted by size
        public static Container container = new Container(2.4, 13.6); //container
        double sizeOfParcels = 0.0; //size in m2
        int i = 0, j = 0; //iterators
        List<Coordinates> coordinates = new List<Coordinates>(); //list of rows
        Parcel tempParcel = null; //temporary parcel for sorting choosen parcel with buuble sort
        Rectangle containerRect; //2d view in canvas of initialized container
        public MainWindow()
        {
            InitializeComponent();
            listViewParcels.ItemsSource = parcels;
            listViewChoosenParcels.ItemsSource = parcelsChoosen;
            lblCountOfAllParcels.Content = parcels.Count;
            lblContainerSize.Content = container.containerSizeX + " m x " + container.containerSizeY + " m";
            lblSizeOfContainerNumbers.Content = container.containerSize + " m2";
            drawContainer();
        }

        private void btnAddParcel_Click(object sender, RoutedEventArgs e)
        {
            //new window for add parcel
            AddParcel windowAddParcel = new AddParcel();
            windowAddParcel.Show();
        }

        private void btnEditContainer_Click(object sender, RoutedEventArgs e)
        {
            //new window for edit container
            EditContainer windowEditContainer = new EditContainer();
            windowEditContainer.Show();
        }

        private void Grid_LayoutUpdated(object sender, EventArgs e)
        {
            //updating the textBoxes on the mainWindow
            lblContainerSize.Content = container.containerSizeX + " m x " + container.containerSizeY + " m";
            lblCountOfAllParcels.Content = parcels.Count;
            lblCountOfChoosenParcels.Content = parcelsChoosen.Count;
            lblSizeOfContainerNumbers.Content = container.containerSize + " m2";
            sizeOfParcels = 0.0;
            foreach (Parcel p in parcelsChoosen)
            {
                sizeOfParcels += Math.Round(p.parcelSizeX * p.parcelSizeY, 2);
            }
            lblSizeOfParcelsNumbers.Content = sizeOfParcels.ToString() + " m2";
        }

        private void btnDeleteParcel_Click(object sender, RoutedEventArgs e)
        {
            if (listViewParcels.SelectedIndex != -1)
            {
                MessageBoxResult resultOfDeletingParcel = MessageBox.Show("Czy na pewno chcesz usunąć paczkę z listy?", "Usuń paczkę", MessageBoxButton.YesNo, MessageBoxImage.Question);
                switch (resultOfDeletingParcel)
                {
                    case MessageBoxResult.Yes:
                        {
                            parcels.RemoveAt(listViewParcels.SelectedIndex);
                            MessageBox.Show("Paczka została usunięta z listy", "Usuń paczkę", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        }
                    case MessageBoxResult.No:
                        {
                            break;
                        }
                }
            }

        }

        private void btnChooseParcel_Click(object sender, RoutedEventArgs e)
        {
            //function that moving parcels to parcelsChoosen
            if (listViewParcels.SelectedIndex != -1) //checking is anything in list is marked
            {
                if (listViewParcels.SelectedItems.Count == 1) //checking if it only one item marked
                {
                    Parcel pTemp = (Parcel)listViewParcels.SelectedItem;
                    if (pTemp.parcelSizeX > container.containerSizeX && pTemp.parcelSizeY > container.containerSizeY)
                        MessageBox.Show("Paczka jest za duża na ten kontener. Powiększ kontener", "Za duża paczka", MessageBoxButton.OK, MessageBoxImage.Error);
                    else
                    {
                        parcelsChoosen.Add((Parcel)listViewParcels.SelectedItem);
                        parcels.RemoveAt(listViewParcels.SelectedIndex);
                    }
                }
                else //else if more than one item is marked
                {
                    List<Parcel> selectedParcels = new List<Parcel>(); //new list for removing choosen parcels from list of parcels, because listViewParcels.SelectedItems will change if i remove item from listViewParcels
                    foreach (Parcel selectedParcel in listViewParcels.SelectedItems)
                    {
                        if (selectedParcel.parcelSizeX > container.containerSizeX && selectedParcel.parcelSizeY > container.containerSizeY) //checking if size of parcel is not too big for that container
                        {
                            MessageBox.Show("Paczka jest za duża na ten kontener. Powiększ kontener", "Za duża paczka", MessageBoxButton.OK, MessageBoxImage.Error);
                            continue;
                        }
                        else
                        {
                            parcelsChoosen.Add(selectedParcel);
                            selectedParcels.Add(selectedParcel);
                        }
                    }
                    for (int i = 0; i < selectedParcels.Count; i++)
                    {
                        parcels.Remove(selectedParcels.ElementAt(i));

                    }
                }
            }
        }

        private void btnDeleteChoosenParcel_Click(object sender, RoutedEventArgs e)
        {
            //same thing as upper function, bo from parcelChoosen to parcels
            if (listViewChoosenParcels.SelectedIndex != -1)
            {
                if (listViewChoosenParcels.SelectedItems.Count == 1)
                {
                    parcels.Add((Parcel)listViewChoosenParcels.SelectedItem);
                    parcelsChoosen.RemoveAt(listViewChoosenParcels.SelectedIndex);
                }
                else
                {
                    List<Parcel> selectedChoosenParcels = new List<Parcel>();
                    foreach (Parcel selectedChoosenParcel in listViewChoosenParcels.SelectedItems)
                    {
                        parcels.Add(selectedChoosenParcel);
                        selectedChoosenParcels.Add(selectedChoosenParcel);
                    }
                    for (i = 0; i < selectedChoosenParcels.Count; i++)
                    {
                        parcelsChoosen.Remove(selectedChoosenParcels.ElementAt(i));

                    }
                }
            }
        }

        private void btnResetContainer_Click(object sender, RoutedEventArgs e)
        {
            drawContainer();
        }

        private void btnPlaceInContainer_Click(object sender, RoutedEventArgs e)
        {
            drawContainer();
            if (container.containerSize < sizeOfParcels)
            {
                MessageBox.Show("Powierzchnia kontenera jest za mała, aby zmieścić tyle paczek", "Brak miejsca", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                coordinates.Clear();
                parcelsChoosenSortBySize = new Parcel[parcelsChoosen.Count];
                parcelsChoosenSortBySize = parcelsChoosen.ToArray(); //creating table of parcelsChoosen 
                double tempParcelToRotate = 0.0;
                foreach (Parcel p in parcelsChoosenSortBySize)
                {
                    if (p.parcelSizeY > p.parcelSizeX && p.parcelSizeY < container.containerSizeX) //rotate parcel if sizeY > sizeX and sizeY < containerSizeX
                    {
                        tempParcelToRotate = p.parcelSizeX;
                        p.parcelSizeX = p.parcelSizeY;
                        p.parcelSizeY = tempParcelToRotate;
                    }
                }

                #region sorting table with bubble sort
                for (i = 0; i < parcelsChoosenSortBySize.Length - 1; i++) //sort table descend with bubble sort
                {
                    for (j = 0; j < parcelsChoosenSortBySize.Length - 1; j++)
                    {
                        if (parcelsChoosenSortBySize[j].parcelSizeY < parcelsChoosenSortBySize[j + 1].parcelSizeY)
                        {
                            tempParcel = parcelsChoosenSortBySize[j];
                            parcelsChoosenSortBySize[j] = parcelsChoosenSortBySize[j + 1];
                            parcelsChoosenSortBySize[j + 1] = tempParcel;
                        }
                        else if (parcelsChoosenSortBySize[j].parcelSizeY == parcelsChoosenSortBySize[j + 1].parcelSizeY)
                        {
                            if (parcelsChoosenSortBySize[j].parcelSizeX < parcelsChoosenSortBySize[j + 1].parcelSizeX)
                            {
                                tempParcel = parcelsChoosenSortBySize[j];
                                parcelsChoosenSortBySize[j] = parcelsChoosenSortBySize[j + 1];
                                parcelsChoosenSortBySize[j + 1] = tempParcel;
                            }
                        }
                    }
                }
                #endregion

                //this should be algorithm for placing parcels in container but it doesn't work as it should
                coordinates.Add(new Coordinates(0, 0));
                j = 0;
                byte o = 10;
                for (int w = 0; w < parcelsChoosenSortBySize.Length; w++)
                {
                    Rectangle parcel = new Rectangle();
                    parcel.Stroke = Brushes.Black;
                    parcel.StrokeThickness = 1;
                    parcel.Fill = new SolidColorBrush(Color.FromRgb(o, o, o));

                    if ((coordinates.ElementAt(j).coordinateX + (parcelsChoosenSortBySize[w].parcelSizeX * 30) + 1) <= (container.containerSizeX * 30))
                    {
                        coordinates.Add(new Coordinates(0, 0));
                        parcel.Width = parcelsChoosenSortBySize[w].parcelSizeX * 30;
                        parcel.Height = parcelsChoosenSortBySize[w].parcelSizeY * 30;
                        Canvas.SetTop(parcel, coordinates.ElementAt(j).coordinateY);
                        Canvas.SetLeft(parcel, coordinates.ElementAt(j).coordinateX);
                        coordinates.ElementAt(j).coordinateX += parcel.Width;
                        coordinates.ElementAt(j + 1).coordinateY += parcel.Height;
                    }
                    else if ((coordinates.ElementAt(j).coordinateX + (parcelsChoosenSortBySize[w].parcelSizeY * 30) + 1) <= (container.containerSizeX * 30))
                    {
                        coordinates.Add(new Coordinates(0, 0));
                        parcel.Width = parcelsChoosenSortBySize[w].parcelSizeY * 30;
                        parcel.Height = parcelsChoosenSortBySize[w].parcelSizeX * 30;
                        Canvas.SetTop(parcel, coordinates.ElementAt(j).coordinateY);
                        Canvas.SetLeft(parcel, coordinates.ElementAt(j).coordinateX);
                        coordinates.ElementAt(j).coordinateX += parcel.Width;
                        coordinates.ElementAt(j + 1).coordinateY += parcel.Height;
                    }
                    else
                    {
                        j++;

                        if ((coordinates.ElementAt(j).coordinateX + (parcelsChoosenSortBySize[w].parcelSizeX * 30) + 1) <= (container.containerSizeX * 30))
                        {
                            coordinates.Add(new Coordinates(0, coordinates.ElementAt(j).coordinateY));
                            parcel.Width = parcelsChoosenSortBySize[w].parcelSizeX * 30;
                            parcel.Height = parcelsChoosenSortBySize[w].parcelSizeY * 30;
                            Canvas.SetTop(parcel, coordinates.ElementAt(j).coordinateY);
                            Canvas.SetLeft(parcel, coordinates.ElementAt(j).coordinateX);
                            coordinates.ElementAt(j).coordinateX += parcel.Width;
                            coordinates.ElementAt(j + 1).coordinateY += parcel.Height;
                        }
                        else if ((coordinates.ElementAt(j).coordinateY + (parcelsChoosenSortBySize[w].parcelSizeX * 30) + 1) <= (container.containerSizeX * 30))
                        {
                            coordinates.Add(new Coordinates(0, coordinates.ElementAt(j).coordinateY));
                            parcel.Width = parcelsChoosenSortBySize[w].parcelSizeY * 30;
                            parcel.Height = parcelsChoosenSortBySize[w].parcelSizeX * 30;
                            Canvas.SetTop(parcel, coordinates.ElementAt(j).coordinateY);
                            Canvas.SetLeft(parcel, coordinates.ElementAt(j).coordinateX);
                            coordinates.ElementAt(j).coordinateX += parcel.Width;
                            coordinates.ElementAt(j + 1).coordinateY += parcel.Height;
                        }
                    }
                    cnvContainer.Children.Add(parcel);
                    o += 30;
                }
            }
        }

        private void drawContainer()
        {
            //function draws a rectangle in size of container on the canvas
            if (cnvContainer.Children.Count > 0)
                cnvContainer.Children.Clear();
            containerRect = new Rectangle();
            containerRect.Stroke = Brushes.Black;
            containerRect.StrokeThickness = 1;
            containerRect.Fill = new SolidColorBrush(Colors.Wheat);
            containerRect.Width = container.containerSizeX * 30;
            containerRect.Height = container.containerSizeY * 30;
            Canvas.SetLeft(containerRect, 0);
            Canvas.SetTop(containerRect, 0);
            cnvContainer.Children.Add(containerRect);
        }
    }
}