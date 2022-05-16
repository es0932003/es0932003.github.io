using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

//Program: Animal Matching Game
//Programmer: Emmaleigh Stone
//Date: 04/26/2022
//Purpose: allow user to play an animal matching game that contains a timer and the date

namespace MatchGame
{

    using System.Windows.Threading;

    //MainWindow class
    public partial class MainWindow : Window
    {
        //declare variable timer
        DispatcherTimer timer = new DispatcherTimer();
        //declare tenthOfSecondsElasped variable
        int tenthsOfSecondsElapsed;
        //declare matchesFound variable
        int matchesFound;

        //MainWindow() method
        public MainWindow()
        {
            //create the window using XAML
            InitializeComponent();
            //set timer to run on seconds
            timer.Interval = TimeSpan.FromSeconds(.1);
            //add time to the timer
            timer.Tick += Timer_Tick;
            //add date to dateTime textbox
            dateTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //call the SetUpGame() method
            SetUpGame();
        }

        //event when timer is ticking
        private void Timer_Tick(object sender, EventArgs e)
        {
            //add time to the tenthsOfSecondsElapsed variable
            tenthsOfSecondsElapsed++;
            //set timeTextBlock to show time as string
            timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            //if all the matches are found
            if (matchesFound == 8)
            {
                //stop timer using Stop() method
                timer.Stop();
                //add the prompting text to the stopped timer
                timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
            }
        }

        //method to set up the game
        private void SetUpGame()
        {
            //declare string list animalEmoji
            List<string> animalEmoji = new List<string>()
            {
                //pairs of emoji strings
                "🐵", "🐵",
                "🐶", "🐶",
                "🐯", "🐯",
                "🐴", "🐴",
                "🐮", "🐮",
                "🐷", "🐷",
                "🐭", "🐭",
                "🐰", "🐰",
            };
            //declare random using Random() method
            Random random = new Random();
            //for each type of textblock in grid
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                //if textblock is not named timeTextBlock
                if (textBlock.Name != "timeTextBlock")
                {
                    //make textBlock visable
                    textBlock.Visibility = Visibility.Visible;
                    //declare index variable as random animalEmoji
                    int index = random.Next(animalEmoji.Count);
                    //declare nextEmoji as the index of animalEmoji
                    string nextEmoji = animalEmoji[index];
                    //make textBlock text nextEmoji
                    textBlock.Text = nextEmoji;
                    //remove the animalEmoji thats been used from index
                    animalEmoji.RemoveAt(index);
                }
            }
            //start the timer using Start() method
            timer.Start();
            //declare tenthsOfSecondsElapsed variable
            tenthsOfSecondsElapsed = 0;
            //declare matchesFound variable
            matchesFound = 0;
        }

        //declare lastTextBlockClicked variable
        TextBlock lastTextBlockClicked;
        //declare findingMatch variable as false
        bool findingMatch = false;

        //event when TextBlock has been clicked
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //set textBlock as sender
            TextBlock textBlock = sender as TextBlock;
            //if the match has not be found
            if (findingMatch == false)
            {
                //hide textBlock
                textBlock.Visibility = Visibility.Hidden;
                //set lastTextBlockClicked as variable textBlock
                lastTextBlockClicked = textBlock;
                //set findingMatch to true
                findingMatch = true;
            }
            //if textBlock text is the same as lastTextBlockClicked text
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                //add to matchesFound
                matchesFound++;
                //hide textBlock variable
                textBlock.Visibility = Visibility.Hidden;
                //set findingMatch to false
                findingMatch = false;
            }
            //anything else
            else
            {
                //make lastTextBlockClicked visable
                lastTextBlockClicked.Visibility = Visibility.Visible;
                //set findingMatch to false
                findingMatch = false;
            }
        }

        //event when timeTextBlock has been clicked
        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //if all matches have been found
            if (matchesFound == 8)
            {
                //restart game
                SetUpGame();
            }
        }
    }
}
