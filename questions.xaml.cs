using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
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
    /// Interaction logic for questions.xaml
    /// </summary>
    public partial class questions : Window
    {
        //arraylist for the questions and answers
        ArrayList reply = new ArrayList();
        ArrayList ignore = new ArrayList();

        // MEMORY AND RECALL VARIABLES
        private string userName = "User"; 
        private string favoriteTopic = string.Empty; 
        private readonly string filepath = "remembered_names.txt";

        public questions()
        {
            InitializeComponent();

            new respond(reply, ignore) { };

            //Automatically load the name entered in the previous window
            if (File.Exists(filepath))
            {
                string[] savedNames = File.ReadAllLines(filepath);
                if (savedNames.Length > 0)
                {
                    userName = savedNames[savedNames.Length - 1]; // Grabs the most recent name
                }
            }
        }

        //method to get the question and process it
        private void enter_question(object sender, RoutedEventArgs e)
        {
            //get the question
            string Questions = Question.Text.ToString();

            //if statment to check if user entered a question or not or if the user entered exit to close the program
            if (Questions.ToLower() == "exit")
            {
                //closes the program
                Application.Current.Shutdown();
                return;
            }
            if (string.IsNullOrWhiteSpace(Questions))
            {
                //call the error method
                error_method("You did not enter a question");
            }
            else
            {//start of else

                string questionsLower = Questions.ToLower();
                bool justCapturedTopic = false;

                // --- MEMORY FEATURE: Detect and store favorite cybersecurity topic ---
                if (string.IsNullOrEmpty(favoriteTopic))
                {
                    string[] trackableTopics = { "privacy", "phishing", "vpn", "password", "firewall", "cybersecurity" };
                    foreach (string topic in trackableTopics)
                    {
                        // Checks if they state an interest (e.g., "I am interested in privacy" or "privacy is my favorite")
                        if (questionsLower.Contains("interested in " + topic) ||
                           (questionsLower.Contains(topic) && (questionsLower.Contains("favorite") || questionsLower.Contains("like"))))
                        {
                            favoriteTopic = topic;
                            justCapturedTopic = true;
                            break;
                        }
                    }
                }

                // If we just saved their preference, show the exact acknowledgment from the assignment sheet
                if (justCapturedTopic)
                {
                    show_chats.Items.Add(
                        new TextBlock
                        {
                            Inlines = {
                                new Run { Text = "Whitney : ", Foreground = Brushes.Blue, FontWeight = FontWeights.Bold },
                                new Run { Text = $"Great! I'll remember that you're interested in {favoriteTopic}. It's a crucial part of staying safe online.", Foreground = Brushes.Red }
                            }
                        }
                    );

                    // Auto scroll line
                    if (show_chats.Items.Count > 0)
                    {
                        show_chats.ScrollIntoView(show_chats.Items[show_chats.Items.Count - 1]);
                    }
                    Question.Clear();
                    return; // Stop processing further for this turn
                }


                //temp varaibles and arrays
                string[] words = Questions.Split(' ');

                bool found = false;
                string message = string.Empty;

                Random indexer = new Random();

                ArrayList per_words = new ArrayList();
                ArrayList answers_found = new ArrayList();

                //alterate per word from the words array
                foreach (string word in words)
                {//start of the main foreach

                    //check if the word is allowed or not
                    if (!ignore.Contains(word.ToLower()))
                    {//start of check word if

                        //MessageBox.Show( word + " is allowed " );
                        per_words.Clear();
                        //foreach to search for the answer of the word allowed
                        foreach (string answer in reply)
                        {//start of anwser loop

                            //check and store
                            if (answer.Contains(word.ToLower()))
                            {//start of check answer if

                                found = true;

                                //store all answers for word
                                per_words.Add(answer);

                            }//end of check answer if

                        }//end of anwser loop

                        //than check if found is true and store
                        //per random
                        if (found)
                        {//start of found if

                            //get the random indexer
                            int indexing = indexer.Next(0, per_words.Count);

                            //store one answer per word now
                            answers_found.Add(per_words[indexing]);

                        }//end of found if


                    }//end of check word if

                }//end of the main foreach

                //check and show the user answers
                if (found)
                {//start of found if true

                    //get all of answers and show to the user
                    foreach (string per_answer in answers_found)
                    {//start of show answer loop

                        string cleanAnswer = per_answer;

                        // Strips out "Whitney: keyword" so only the actual answer displays
                        if (cleanAnswer.StartsWith("Whitney:"))
                        {
                            string[] parts = cleanAnswer.Split(new[] { ' ' }, 3);
                            if (parts.Length == 3)
                            {
                                cleanAnswer = parts[2];
                            }
                        }

                        // --- MEMORY FEATURE: Recall preference later in the conversation ---
                        if (!string.IsNullOrEmpty(favoriteTopic))
                        {
                            // Tailor the advice dynamically based on what they saved earlier
                            if (favoriteTopic == "privacy")
                            {
                                cleanAnswer += " As someone interested in privacy, you might want to review the security settings on your accounts.";
                            }
                            else
                            {
                                cleanAnswer += $" As someone interested in {favoriteTopic}, always make sure to stay updated on this topic to keep {userName} secure!";
                            }
                        }

                        // Adds a beautifully styled colorful text block to the list view
                        show_chats.Items.Add(
                            new TextBlock
                            {
                                Inlines = {
                                    new Run {
                                        Text = "Whitney : ",
                                        Foreground = Brushes.Blue, // Color for whitneys Name
                                        FontWeight = FontWeights.Bold
                                    },
                                    new Run {
                                        Text = cleanAnswer,
                                        Foreground = Brushes.Red // Color for whitneys text response
                                    }
                                }
                            }
                        );
                    }

                    // Auto scroll line
                    if (show_chats.Items.Count > 0)
                    {
                        show_chats.ScrollIntoView(show_chats.Items[show_chats.Items.Count - 1]);
                    }

                }//end of show answer loop//end of found if true
                else
                {//else method if no answer found
                    error_method($"I don't understand the question {userName}, please try again with different words");
                }//end of else method if no answer found
            }//end of else

            Question.Clear(); // Clears input box for next question
        }//end of private void send method

        //start of the error method
        private void error_method(string errorText = "error!!!")
        {
            // call the chats with the list view
            show_chats.Items.Add(
                  new TextBlock
                  {
                      Inlines = {
                  new Run {
                      Text = "Whitney : ",
                      Foreground = Brushes.Blue
                  },
                  new Run {
                      Text = errorText, // Displays the custom error message
                      Foreground = Brushes.Red
                  }
                      }
                  }
            );

            // Auto scroll line
            if (show_chats.Items.Count > 0)
            {
                show_chats.ScrollIntoView(show_chats.Items[show_chats.Items.Count - 1]);
            }
        }
    }
}
