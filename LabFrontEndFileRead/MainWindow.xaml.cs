using System;
using System.Collections.Generic;
using System.IO;
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

namespace lab_master_detail_AndreLussier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e) // e is the selected movie
        {

            /*
            Movie x;
            x = (Movie) e.AddedItems[0];

            textBoxName.Text = x.Name;
            textBoxRottenTomatoesScore.Text = x.RottenTomatoesScore.ToString();
            textBoxReview.Text = x.Review;
            */

        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("input.txt");

            while (!sr.EndOfStream)
            {
                // Create an instance of movie
                Movie m = new Movie();

                // Read in the movie name
                m.Name = sr.ReadLine();


                // Read in the Rotten Tomatoes Score
                m.RottenTomatoesScore = Convert.ToInt32(sr.ReadLine());

                m.Review = sr.ReadLine();

                listViewMovies.Items.Add(m);



            }
        }
    }
}
