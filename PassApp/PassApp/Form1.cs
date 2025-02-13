namespace PassApp
{
    public partial class Form1 : Form
    {
        // Zmienna przechowuj¹ca wygenerowane has³o
        private string haslo = "";
        // Obiekt losuj¹cy liczby do generowania has³a
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // Metoda obs³uguj¹ca przycisk "ZatwierdŸ"
        private void submit_Click(object sender, EventArgs e)
        {
            // Pobieranie danych wprowadzonych przez u¿ytkownika
            string imie = imieInput.Text;
            string nazwisko = nazwiskoInput.Text;
            string stanowisko = "";

            // Sprawdzenie, czy u¿ytkownik wybra³ stanowisko z listy
            if (stanowiskaLista.SelectedIndex != -1)
            {
                stanowisko = stanowiskaLista.SelectedItem.ToString();
            }

            // Wyœwietlenie komunikatu z danymi u¿ytkownika oraz wygenerowanym has³em
            MessageBox.Show($"{imie} {nazwisko} {stanowisko} {haslo}");
        }

        // Metoda generuj¹ca has³o po klikniêciu przycisku "Generuj has³o"
        private void genPass_Click(object sender, EventArgs e)
        {
            // Definicje dostêpnych znaków
            string maleWielkieLitery = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cyfry = "1234567890";
            string znakiSpecjalne = "!@#$%^&*()_+-=";
            string dostepneZnaki = "";

            // Sprawdzenie, które typy znaków u¿ytkownik wybra³
            if (checkBox1.Checked) dostepneZnaki += maleWielkieLitery;
            if (checkBox2.Checked) dostepneZnaki += cyfry;
            if (checkBox3.Checked) dostepneZnaki += znakiSpecjalne;

            // Jeœli nie wybrano ¿adnego typu znaków, wyœwietlamy komunikat o b³êdzie
            if (string.IsNullOrEmpty(dostepneZnaki))
            {
                MessageBox.Show("Musisz wybraæ przynajmniej jeden typ znaków!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobranie d³ugoœci has³a z pola tekstowego
            if (!int.TryParse(textBox1.Text, out int dlugoscHasla) || dlugoscHasla <= 0)
            {
                MessageBox.Show("Podaj poprawn¹ liczbê znaków!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Random r = new Random();
            // Resetowanie poprzedniego has³a
            haslo = "";

            // Generowanie losowego has³a
            for (int i = 0; i < dlugoscHasla; i++)
            {
                int losowyIndex = r.Next(dostepneZnaki.Length);
                haslo += dostepneZnaki[losowyIndex];
            }

            // Wyœwietlenie wygenerowanego has³a
            MessageBox.Show($"Wygenerowane has³o: {haslo}");
        }

        // Metody obs³uguj¹ce zmiany w polach tekstowych (obecnie puste, ale mog¹ byæ u¿yte w przysz³oœci)
        private void imieInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}