namespace ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("İşçi");
            comboBox1.Items.Add("muhendis");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel
     (adTxt.Text, adresTxt.Text, comboBox1.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text));

            if (comboBox1.Text == "İşçi")

            {
                MessageBox.Show(pers.ucretHesapla().ToString());

            }
            else
            {
                pers.ucretHesapla(1000);
            }
        }
    }
}