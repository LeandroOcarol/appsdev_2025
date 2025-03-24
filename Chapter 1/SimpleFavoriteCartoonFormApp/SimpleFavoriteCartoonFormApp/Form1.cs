using System.Windows.Forms;

namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox.Items.Add("Scooby Doo");
            comboBox.Items.Add("Shaggy");
            comboBox.Items.Add("Fred");
            comboBox.Items.Add("Daphne");
            comboBox.Items.Add("Velma");

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedChars = comboBox.SelectedItem.ToString();

            switch (selectedChars)
            {
                case "Scooby Doo":
                    pictureBox.Image = Image.FromFile(@"D:\Chapter 1\SimpleFavoriteCartoonFormApp\pictures\scoobs.jpg");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Shaggy":
                    pictureBox.Image = Image.FromFile(@"D:\Chapter 1\SimpleFavoriteCartoonFormApp\pictures\shaggy.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Fred":
                    pictureBox.Image = Image.FromFile(@"D:\Chapter 1\SimpleFavoriteCartoonFormApp\pictures\fred.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Daphne":
                    pictureBox.Image = Image.FromFile(@"D:\Chapter 1\SimpleFavoriteCartoonFormApp\pictures\daphne.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Velma":
                    pictureBox.Image = Image.FromFile(@"D:\Chapter 1\SimpleFavoriteCartoonFormApp\pictures\velma.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox.Image = null;
                    break;
            }

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
