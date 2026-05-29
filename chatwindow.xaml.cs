using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Whitney
{
    /// <summary>
    /// Interaction logic for chatwindow.xaml
    /// </summary>
    public partial class chatwindow : Window
    {
        //filepath where names will be stored
        private readonly string filepath = "remembered_names.txt";
        public chatwindow()
        {
            InitializeComponent();
        }

        private void questions(object sender, RoutedEventArgs e)
        {
            //gets the username from the textbox and stores it in a variable
            string userName = usernametextbox.Text;

            //checks if the username is empty or only whitespace, and shows a message box if it is
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Please enter your name before proceeding!", "Name Required", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            //saves the username to a text file
            bool isReturningUser = false;

            //checks if the file exists and reads the names from it, comparing them to the current username
            if (File.Exists(filepath))
            {//start of if statement to check if file exists
                string[] savedNames = File.ReadAllLines(filepath);

                foreach (string name in savedNames)
                {//compares the current username to each name in the file, ignoring case
                    if (name.Equals(userName, StringComparison.OrdinalIgnoreCase))
                    {//if the username is found in the file, it sets the
                        isReturningUser = true;
                        break;
                    }//if the username is found in the file, it sets the isReturningUser flag to true and breaks out of the loop
                }//if the username is not found in the file, it adds it to the file
            }//end of if statement to check if file exists
            //welcome back message for returning users
            if (isReturningUser)
            { //if the username is found in the file, it shows a welcome back message
            MessageBox.Show("Welcome back, " + userName + "!", " Whitney", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Welcome, {userName}!", "Whitney Chatbot", MessageBoxButton.OK, MessageBoxImage.Information);
                //if the username is not found in the file, it adds it to the file
                File.AppendAllText(filepath, userName + Environment.NewLine);
            }//creates a new instance of the questions window, which is the next step in the chatbot conversation, and shows it while closing the current chatwindow

            //instance to open the chat window
            questions nextWindow = new questions();

            //shows the next window and hides the current one
            nextWindow.Show();

            //closes the current window
            this.Close();
        }//end of questions method
    }//end of chatwindow class
}//end of namespace Whitney
