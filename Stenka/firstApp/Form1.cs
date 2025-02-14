
namespace firstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inicjalizacja komponentów formularza
        }

        // Obs³uga zdarzenia klikniêcia przycisku
        private void button1_Click(object sender, EventArgs e)
        {
            // Pobranie wartoœci z pól tekstowych i zamiana na liczby ca³kowite
            int ocenaWF = int.Parse(wfInput.Text);
            int ocenaFiz = int.Parse(fizInput.Text);
            int ocenaChem = int.Parse(chemInput.Text);
            int ocenaGeo = int.Parse(geoInput.Text);

            // Obliczenie sumy ocen
            int suma = ocenaWF + ocenaFiz + ocenaChem + ocenaGeo;

            // Obliczenie œredniej ocen
            double srednia = (double)suma / 4;

            // Wyœwietlenie œredniej w oknie dialogowym
            MessageBox.Show(srednia.ToString());
        }

        // Obs³uga zdarzenia zmiany tekstu w polu wfInput
        private void wfInput_TextChanged(object sender, EventArgs e)
        {
            // Aktualnie pusta metoda - mo¿na dodaæ walidacjê wejœcia
        }

        // Obs³uga zdarzenia klikniêcia etykiety label2
        private void label2_Click(object sender, EventArgs e)
        {
            // Aktualnie pusta metoda - mo¿na dodaæ odpowiedni¹ logikê
        }
    }
}

