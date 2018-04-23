using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsApplication1
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        int time;
        int maxtime = 30;
        public void ShowProgress()
        {
            ShowDialog();
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            linearScaleComponent1.Value = time*10 % linearScaleComponent1.MaxValue;
            time++;
            if (time > maxtime)
            {
                timer1.Stop();
                Dispose();
            }
        }
    }
}