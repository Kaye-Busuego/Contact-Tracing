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
            file.WriteLine("Had any contact with a COVID-19 patient for the last 2 weeks: " + txtboxq2.Text);
            file.WriteLine("Had a family member who had infected with COVID-19 recently: " + txtboxq3.Text);
            file.WriteLine("Had been recently tested for COVID-19 due to symptoms and are still awaiting test results: " + txtboxq4.Text);
            file.WriteLine("Age: " + txtboxAge.Text);
            file.WriteLine("Age: " + txtboxAge.Text);
            file.Close();


            MessageBox.Show("Information Saved Successfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}