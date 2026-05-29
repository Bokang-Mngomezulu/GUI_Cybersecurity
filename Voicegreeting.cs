using System;
using System.IO; // Added to use Path.Combine
using System.Media;

namespace Whitney
{//start of the namespace
    public class Voicegreeting
    {//start of the class Voicegreeting
        public void greet()
        {//start of the method greet

            // Combines the running directory with your audio filename safely
            
            string autopath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cybersecurity.wav.wav");

            SoundPlayer greeting = new SoundPlayer();

            //Tells the SoundPlayer where the audio file lives
            greeting.SoundLocation = autopath;

            try
            {
                //Pre-load the file into memory so it plays instantly without lag
                greeting.Load();
                greeting.Play();
            }
            catch (Exception ex)
            {
                // If something goes wrong (e.g. misspelled filename), this stops the app from crashing
                System.Windows.MessageBox.Show("Audio error: " + ex.Message);
            }

        }//end of the method greet
    }//end of the class Voicegreeting
}//end of the namespace