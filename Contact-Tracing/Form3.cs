﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader(@"C:\Users\Jovelyn Vitales\Desktop\Contact Tracing\Result.txt");
            string all = reader.ReadToEnd();
            MessageBox.Show(all);
        }
    
    }
}
