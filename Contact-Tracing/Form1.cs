namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Jovelyn Vitales\Desktop\Contact Tracing\Result.txt", true);
            file.WriteLine("Name: " + txtboxName.Text);
            file.WriteLine("Student ID#: " + txtboxStudentID.Text);
            file.WriteLine("Age: " + txtboxAge.Text);
            file.WriteLine("Address: " + txtboxAddress.Text);
            file.WriteLine("Sex: " + txtboxSex.Text);
            file.WriteLine("Contact#: " + txtboxContact.Text);
            file.WriteLine("Temperature: " + txtboxTemp.Text);
            file.WriteLine("Date of Visit: " + txtboxDOV.Text);
            file.WriteLine("Reason for Visitation: " + txtboxRFV.Text);
            file.WriteLine("Had COVID-19 for the past 90 days: " + txtboxq1.Text);
            file.WriteLine("Had received COVID-19 vaccine: " + txtboxq5.Text);
            file.Close();


            MessageBox.Show("Information Saved Successfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}