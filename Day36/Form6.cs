namespace Day36
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void comboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxStates.Text = "";
            comboBoxStates.Items.Clear();
            switch (comboBoxCountries.SelectedIndex)
            {
                case 0:
                    comboBoxStates.Items.AddRange(new string[] { "Andhra Pradesh", "Chhattisgarh", "Karnataka", "Madhya Pradesh", "Maharashtra", "Telangana" });
                    break;
                case 1:
                    comboBoxStates.Items.AddRange(new string[] { "Seoul", "Gyeonggi-do", "Gwangju", "Incheon" });
                    break;
                case 2:
                    comboBoxStates.Items.AddRange(new string[] { "Altai", "Amur", "Belgorod Region", "Mari EI" });
                    break;

            }
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
