using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
using System.Windows.Forms;

//Program: Favorite Season Survey Program
//Programmer: Emmaleigh Stone
//Date: 04/14/2022
//Purpose: to run a simple season survey with Window Forms
namespace L11_Assign_Survey_Form
{
    //class containing form
    public partial class Form1 : Form
    {
        //form1 method
        public Form1()
        {
            InitializeComponent();
        }
        //submit button click method
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //if winter radio button is checked when submit button is clicked
            if (radioWinter.Checked)
            {
                //print sentence in textbox
                textBoxFavoriteSeason.Text = "Your favorite season is winter!";
            }
            //if spring radio button is checked when submit button is clicked
            if (radioSpring.Checked)
            {
                //print sentence in textbox
                textBoxFavoriteSeason.Text = "Your favorite season is spring!";
            }
            //if summer radio button is checked when submit button is clicked
            if (radioSummer.Checked)
            {
                //print sentence in textbox
                textBoxFavoriteSeason.Text = "Your favorite season is summer!";
            }
            //if fall radio button is checked when submit button is clicked
            if (radioFall.Checked)
            {
                //print sentence in textbox
                textBoxFavoriteSeason.Text = "Your favorite season is fall!";
            }
        }
        //clear button click method
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clearing the radio buttons
            radioWinter.Checked = false;
            radioSpring.Checked = false;
            radioSummer.Checked = false;
            radioFall.Checked = false;
            //clearing the textbox
            textBoxFavoriteSeason.Text = "";
            }
        //winter radio button check changed method
        private void radioWinter_CheckedChanged(object sender, EventArgs e)
        {
            //if winter radio button is checked
            if (radioWinter.Checked)
            {
                //preview the selection in textbox
                textBoxFavoriteSeason.Text = "Winter";
            }
            //if radio button is not selected
            else
            {
                //keep textbox empty
                textBoxFavoriteSeason.Text = "";
            }
        }
        //spring radio button check changed method
        private void radioSpring_CheckedChanged(object sender, EventArgs e)
        {
            //if spring radio button is checked
            if (radioSpring.Checked)
            {
                //preview the selection in textbox
                textBoxFavoriteSeason.Text = "Spring";
            }
            //if radio button is not selected
            else
            {
                //keep textbox empty
                textBoxFavoriteSeason.Text = "";
            }
        }
        //summer radio button check changed method
        private void radioSummer_CheckedChanged(object sender, EventArgs e)
        {
            //if summer radio button is checked
            if (radioSummer.Checked)
            {
                //preview the selection in textbox
                textBoxFavoriteSeason.Text = "Summer";
            }
            //if radio button is not selected
            else
            {
                //keep textbox empty
                textBoxFavoriteSeason.Text = "";
            }
        }
        //fall radio button check changed method
        private void radioFall_CheckedChanged(object sender, EventArgs e)
        {
            //if fall radio button is checked
            if (radioFall.Checked)
            {
                //preview the selection in textbox
                textBoxFavoriteSeason.Text = "Fall";
            }
            //if radio button is not selected
            else
            {
                //keep textbox empty
                textBoxFavoriteSeason.Text = "";
            }
        }
    }
} 
