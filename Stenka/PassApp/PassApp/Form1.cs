namespace PassApp
{
    public partial class Form1 : Form
    {
        private string haslo = "";
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string imie = imieInput.Text;
            string nazwisko = nazwiskoInput.Text;
            string stanowisko = "";

            if (stanowiskaLista.SelectedIndex != -1)
            {
                stanowisko = stanowiskaLista.SelectedItem.ToString();
            }

            MessageBox.Show($"{imie} {nazwisko} {stanowisko} {haslo}");
        }

        private void genPass_Click(object sender, EventArgs e)
        {
            string maleWielkieLitery = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cyfry = "1234567890";
            string znakiSpecjalne = "!@#$%^&*()_+-=";
            string dostepneZnaki = "";

            if (checkBox1.Checked) dostepneZnaki += maleWielkieLitery;
            if (checkBox2.Checked) dostepneZnaki += cyfry;
            if (checkBox3.Checked) dostepneZnaki += znakiSpecjalne;

            if (string.IsNullOrEmpty(dostepneZnaki))
            {
                MessageBox.Show("Musisz wybraæ przynajmniej jeden typ znaków!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox1.Text, out int dlugoscHasla) || dlugoscHasla <= 0)
            {
                MessageBox.Show("Podaj poprawn¹ liczbê znaków!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Random r = new Random();
            haslo = "";

            for (int i = 0; i < dlugoscHasla; i++)
            {
                int losowyIndex = r.Next(dostepneZnaki.Length);
                haslo += dostepneZnaki[losowyIndex];
            }

            MessageBox.Show($"Wygenerowane has³o: {haslo}");
        }

        private void imieInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void nazwiskoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void stanowiskaLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}