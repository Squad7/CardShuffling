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

namespace CardShuffling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creating an array of an entire 52 card unshuffled deck
        string[] deck =
        {
            "2_of_clubs",
            "2_of_diamonds",
            "2_of_hearts",
            "2_of_spades",
            "3_of_clubs",
            "3_of_diamonds",
            "3_of_hearts",
            "3_of_spades",
            "4_of_clubs",
            "4_of_diamonds",
            "4_of_hearts",
            "4_of_spades",
            "5_of_clubs",
            "5_of_diamonds",
            "5_of_hearts",
            "5_of_spades",
            "6_of_clubs",
            "6_of_diamonds",
            "6_of_hearts",
            "6_of_spades",
            "7_of_clubs",
            "7_of_diamonds",
            "7_of_hearts",
            "7_of_spades",
            "8_of_clubs",
            "8_of_diamonds",
            "8_of_hearts",
            "8_of_spades",
            "9_of_clubs",
            "9_of_diamonds",
            "9_of_hearts",
            "9_of_spades",
            "10_of_clubs",
            "10_of_diamonds",
            "10_of_hearts",
            "10_of_spades",
            "ace_of_clubs",
            "ace_of_diamonds",
            "ace_of_hearts",
            "ace_of_spades",
            "jack_of_clubs",
            "jack_of_diamonds",
            "jack_of_hearts",
            "jack_of_spades",
            "king_of_clubs",
            "king_of_diamonds",
            "king_of_hearts",
            "king_of_spades",
            "queen_of_clubs",
            "queen_of_diamonds",
            "queen_of_hearts",
            "queen_of_spades",
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        //Shuffling the original deck and creating a new shuffled deck
        public void Shuffle()
        {
            Random r = new Random(52);

            for (int i = 0; i < 1000; i++)
            {
                int random1 = r.Next(0, 52);
                int random2 = r.Next(0, 52);

                string temp = deck[random1];
                deck[random1] = deck[random2];
                deck[random2] = temp;


            }

        }
        
        //Displaying the whole new shuffled deck in text
        public void PrintDeck()
        {

            CardList.Document.Blocks.Clear();

            Shuffle();

            for (int i = 0; i < deck.Length; i++)
            {
                CardList.AppendText(deck[i] + "\r");
            }

        }



        //Displaying the top 5 cards from the new shuffled deck 
        public void PrintTop5()
        {
            DisplayCard1.Source = new BitmapImage(new Uri($"Cards/{deck[0]}.png", UriKind.Relative));
            DisplayCard2.Source = new BitmapImage(new Uri($"Cards/{deck[1]}.png", UriKind.Relative));
            DisplayCard3.Source = new BitmapImage(new Uri($"Cards/{deck[2]}.png", UriKind.Relative));
            DisplayCard4.Source = new BitmapImage(new Uri($"Cards/{deck[3]}.png", UriKind.Relative));
            DisplayCard5.Source = new BitmapImage(new Uri($"Cards/{deck[4]}.png", UriKind.Relative));
        }

       

        //All actions that happen when shuffle button is clicked
        private void ShuffleButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDeck();
            PrintTop5();
        }

        //Card deck displays when the program starts
        private void Page1_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                CardList.AppendText(deck[i] + "\r");
            }
                
        }
    }
}
