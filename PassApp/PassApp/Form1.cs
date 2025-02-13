namespace PassApp
{
    public partial class Form1 : Form
    {
        // Zmienna przechowuj�ca wygenerowane has�o
        private string haslo = "";
        // Obiekt losuj�cy liczby do generowania has�a
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // Metoda obs�uguj�ca przycisk "Zatwierd�"
        private void submit_Click(object sender, EventArgs e)
        {
            // Pobieranie danych wprowadzonych przez u�ytkownika
            string imie = imieInput.Text;
            string nazwisko = nazwiskoInput.Text;
            string stanowisko = "";

            // Sprawdzenie, czy u�ytkownik wybra� stanowisko z listy
            if (stanowiskaLista.SelectedIndex != -1)
            {
                stanowisko = stanowiskaLista.SelectedItem.ToString();
            }

            // Wy�wietlenie komunikatu z danymi u�ytkownika oraz wygenerowanym has�em
            MessageBox.Show($"{imie} {nazwisko} {stanowisko} {haslo}");
        }

        // Metoda generuj�ca has�o po klikni�ciu przycisku "Generuj has�o"
        private void genPass_Click(object sender, EventArgs e)
        {
            // Definicje dost�pnych znak�w
            string maleWielkieLitery = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cyfry = "1234567890";
            string znakiSpecjalne = "!@#$%^&*()_+-=";
            string dostepneZnaki = "";

            // Sprawdzenie, kt�re typy znak�w u�ytkownik wybra�
            if (checkBox1.Checked) dostepneZnaki += maleWielkieLitery;
            if (checkBox2.Checked) dostepneZnaki += cyfry;
            if (checkBox3.Checked) dostepneZnaki += znakiSpecjalne;

            // Je�li nie wybrano �adnego typu znak�w, wy�wietlamy komunikat o b��dzie
            if (string.IsNullOrEmpty(dostepneZnaki))
            {
                MessageBox.Show("Musisz wybra� przynajmniej jeden typ znak�w!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobranie d�ugo�ci has�a z pola tekstowego
            if (!int.TryParse(textBox1.Text, out int dlugoscHasla) || dlugoscHasla <= 0)
            {
                MessageBox.Show("Podaj poprawn� liczb� znak�w!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Random r = new Random();
            // Resetowanie poprzedniego has�a
            haslo = "";

            // Generowanie losowego has�a
            for (int i = 0; i < dlugoscHasla; i++)
            {
                int losowyIndex = r.Next(dostepneZnaki.Length);
                haslo += dostepneZnaki[losowyIndex];
            }

            // Wy�wietlenie wygenerowanego has�a
            MessageBox.Show($"Wygenerowane has�o: {haslo}");
        }

        // Metody obs�uguj�ce zmiany w polach tekstowych (obecnie puste, ale mog� by� u�yte w przysz�o�ci)
        private void imieInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}