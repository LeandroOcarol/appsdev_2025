namespace SimpleFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void suffix_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string fnameValue = firstName.Text;
            string mnameValue = middleName.Text;
            string lnameValue = lastName.Text;
            string suffixValue = suffix.Text;

            MessageBox.Show($"Hello There! {fnameValue} {mnameValue} {lnameValue} {suffixValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
