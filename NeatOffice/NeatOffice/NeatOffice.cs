﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeatOffice
{
    public partial class NeatOffice : Form
    {
        public NeatOffice()
        {
            InitializeComponent();
            
        }

        private void StripMenuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripDropDownButtonTop_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTo_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(dateTimePickerFrom.Text);
            DateTime todate = Convert.ToDateTime(dateTimePickerTo.Text);
            if (fromdate <= todate)
            {
                TimeSpan ts = todate.Subtract(fromdate);
                int days = Convert.ToInt16(ts.Days);
                numericUpDownDays.Value = days;
            }
            else
            {
                MessageBox.Show("Error in the dates");
            }
            
        }
    }
}
