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
            file.WriteLine("Age: " + txtboxAge.Text);
            file.WriteLine("Address: " + txtboxAddress.Text);
            file.WriteLine("Sex: " + txtboxSex.Text);
            file.WriteLine("Contact#: " + txtboxContact.Text);
            file.WriteLine("Temperature: " + txtboxTemp.Text);
            file.WriteLine("Date of Visit: " + txtboxDOV.Text);
            file.WriteLine("Reason for Visitation: " + txtboxRFV.Text);
            file.Close();
        }
    }
}