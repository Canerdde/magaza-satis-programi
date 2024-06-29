namespace GorselProgramlama
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
                label6.Text = "0";
            else if (listBox1.Text == "Uzun Kol")
                label6.Text = "50";
            else if (listBox1.Text == "Kýsa Kol")
                label6.Text = "60";
            else if (listBox1.Text == "Hakim Yaka")
                label6.Text = "70";
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.Text == "")
                label7.Text = "0";
            else if (listBox3.Text == "Keten")
                label7.Text = "95";
            else if (listBox3.Text == "Kumaþ")
                label7.Text = "115";
            else if (listBox3.Text == "Kot")
                label7.Text = "130";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
                label8.Text = "0";
            else if (listBox2.Text == "Kot")
                label8.Text = "240";
            else if (listBox2.Text == "Kumaþ")
                label8.Text = "260";
            else if (listBox2.Text == "Deri")
                label8.Text = "295";
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.Text == "")
                label9.Text = "0";
            else if (listBox4.Text == "Suni Deri")
                label9.Text = "950";
            else if (listBox4.Text == "Spor")
                label9.Text = "600";
            else if (listBox4.Text == "Haki Deri")
                label9.Text = "1250";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            listBox5.Items.Clear();
            if (listBox1.Text != "")
                listBox5.Items.Add("Gömlek" + listBox1.Text + " " + label6.Text);

            if (listBox3.Text != "")
                listBox5.Items.Add("Pantolon" + listBox3.Text + " " + label7.Text);

            if (listBox2.Text != "")
                listBox5.Items.Add("Ceket" + listBox2.Text + " " + label8.Text);

            if (listBox4.Text != "")
                listBox5.Items.Add("Ayakkabý" + listBox4.Text + " " + label9.Text);

            toplam = int.Parse(label6.Text) + int.Parse(label7.Text) + int.Parse(label8.Text) + int.Parse(label9.Text);
            textBox1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam, ogrenci , indirim , odenecekTutar;
            toplam = double.Parse(textBox1.Text);

            if (checkBox1.Checked)
                ogrenci = toplam / 20;            
            else
                ogrenci = 0;

            if (toplam >= 100)
                indirim = toplam / 10;
            else
                indirim = 0;

            odenecekTutar = toplam - indirim - ogrenci;

            richTextBox1.Text = "";
            richTextBox1.Text += "TOPLAM TUTAR = " + toplam + "\n";
            richTextBox1.Text += "ÝNDÝRÝM TUTARI = " + indirim + "\n";
            richTextBox1.Text += "ÖÐRENCÝ ÝNDÝRÝMÝ = " + ogrenci + "\n";
            richTextBox1.Text += "__________________________________";
            richTextBox1.Text += "ÖDENECEK TUTAR = " + odenecekTutar + "\n";
        }
    }
}
