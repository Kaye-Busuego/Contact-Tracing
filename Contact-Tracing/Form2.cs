using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\Jovelyn Vitales\Desktop\Contact Tracing\Result.txt");
            List<string> dates = new List<string>();


            string searchedDate = dateTimePicker2.Text;
            int countDate = 0;

            while (!reader.EndOfStream)
            {
                string dateinfo = reader.ReadLine();
                if (dateinfo.Contains(searchedDate))
                {
                    countDate++;
                    dates.Add(dateinfo);
                }
            }
            if (countDate == 0)
            {
                MessageBox.Show("No responses found.");
                reader.Close();
            }
            else
            {
                reader.Close();
                StreamWriter file = new StreamWriter(@"C:\Users\Jovelyn Vitales\Desktop\Contact Tracing\Respondent.txt");
                foreach (string dateinfo in dates)
                {
                    file.WriteLine(dateinfo);
                }

                MessageBox.Show(countDate.ToString() + "Responded");

                file.Close();

                Form3 Form = new Form3();
            }

        }

        private void cmBoxyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmBoxday_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmBoxmonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
