using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Whitney
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //instance of the Voicegreeting class to call the greet method and play the audio file when the application starts
            Voicegreeting greet = new Voicegreeting();

            //calls the greet method to play the audio file
            greet.greet();
           
        }

        //method runs when the user clicks the start chat button, it will open a new window with the chat interface
        private void startchat_click(object sender, RoutedEventArgs e)
        {
            //instance to open the chat window
            chatwindow nextWindow = new chatwindow();

            //shows the next window and hides the current one
            nextWindow.Show();

            //closes the current window
            this.Close();
        }
    }
}