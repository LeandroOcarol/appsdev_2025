using System.Diagnostics.Eventing.Reader;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            string[] cuisine = { "Filipino", "Japanese", "Chinese", "Korean" };
            comboBox.Items.AddRange(cuisine);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedItem = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string[] filipinoFood = { "Sisig", "Lumpia" };
            string[] japaneseFood = { "Ramen", "Takoyaki" };
            string[] chineseFood = { "Chow Mein", "Lo Mein" };
            string[] koreanFood = { "Samgyeopsal", "Tteokbokki" };

            checkedListBox.Items.Clear();

            if (comboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox.Items.AddRange(filipinoFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox.Items.AddRange(japaneseFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox.Items.AddRange(chineseFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox.Items.AddRange(koreanFood);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox.Items)
            {
                bool isSelected = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(item));
                if (isSelected && !listBox.Items.Contains(item))
                {
                    listBox.Items.Add(item);
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
