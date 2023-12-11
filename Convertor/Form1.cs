namespace Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            linkLabel1.Text = "Visit my GitHub";
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/DenisBG312");

            linkLabel1.LinkClicked -= linkLabel1_LinkClicked;
            // Subscribe to the LinkClicked event
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            FormBorderStyle = FormBorderStyle.FixedSingle; // or FormBorderStyle.Fixed3D
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(textBox1.Text);
            double result = 0;
            switch (comboBox1.Text)
            {
                case "USD":
                    result = input * 0.55;
                    break;
                case "EUR":
                    result = input * 0.51;
                    break;
                case "GBP":
                    result = input * 0.44;
                    break;
                case "AUD":
                    result = input * 0.84;
                    break;
                case "CAN":
                    result = input * 0.75;
                    break;
                case "RON":
                    result = input * 2.54;
                    break;
            }
            textBox2.Text = result.ToString("f2");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int newWidth = 200;
            int newHeight = 200;
            pictureBox1.Width = newWidth;
            pictureBox1.Height = newHeight;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check if the left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                // Open the clicked link in the default web browser
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = e.Link.LinkData.ToString(),
                        UseShellExecute = true
                    });
                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    // Handle exception, e.g., log it or display an error message
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}