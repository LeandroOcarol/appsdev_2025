namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(textBox.Text);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
