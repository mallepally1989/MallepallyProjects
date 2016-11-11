using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Coromandel
{
    public partial class Coromandel_MasterPage : Form
    {
        
        string marqueeText = "---WELCOME TO COROMANDEL ATI SYSTEM---";

        public Coromandel_MasterPage()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(ScrollTextBox)); /// Thread to start the scrollint text
            thread.Start();
        }



        //#region Scrolling Text Methods

        private void ScrollTextBox()
        {
            string tempChar = string.Empty;
            string tempText = string.Empty;
            tempText = marqueeText;  // adds spaces at the end of the text so there is a clear ending to the text

            while (true)
            {
                tempChar = tempText.Substring(0, 1);
                tempText = tempText.Remove(0, 1) + tempChar;
                try
                {
                    lblScroll.Invoke(new ScrollTextboxCallback(this.UpdateTextBox), new object[] { tempText });
                }
                catch { }
                Thread.Sleep(250);  //lowering this value with make the marquee scroll faster
            }

        }
        public delegate void ScrollTextboxCallback(string t);
        private void UpdateTextBox(string m_text)
        {
            lblScroll.Text = m_text;
        }

        private void Coromandel_MasterPage_Load(object sender, EventArgs e)
        {

        }

        //#endregion
    }
}
