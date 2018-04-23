using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int lockTimerCounter;
        private void OnTimerTick(object sender, System.EventArgs e)
        {
            if (lockTimerCounter == 0)
            {
                lockTimerCounter++;
                UpdateText();
                lockTimerCounter--;
            }
        }
        protected void Init()
        {
            timer.Stop();
            offsetCounter = -digitalGauge1.DigitCount;
            timer.Interval = 500 / (trackBarControl1.Value + 1);
            timer.Start();
        }
        int offsetCounter = 0;
        protected void UpdateText()
        {
            string fullTextToShow = textEdit1.Text;
            char[] textToShow = new char[digitalGauge1.DigitCount];
            for (int i = 0; i < digitalGauge1.DigitCount; i++)
            {
                if (i + offsetCounter >= 0 && i + offsetCounter < fullTextToShow.Length)
                {
                    textToShow[i] = fullTextToShow[i + offsetCounter];
                }
                else textToShow[i] = ' ';
            }
           offsetCounter++; 
            if (offsetCounter > digitalGauge1.DigitCount + fullTextToShow.Length) offsetCounter = -digitalGauge1.DigitCount;
            digitalGauge1.Text = new string(textToShow);
        }


        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Init();
        }


        private void trackBarControl1_ValueChanged(object sender, EventArgs e)
        {
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new XtraForm1().ShowProgress();
        }

    }
}