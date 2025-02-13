
namespace firstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inicjalizacja komponent�w formularza
        }

        // Obs�uga zdarzenia klikni�cia przycisku
        private void button1_Click(object sender, EventArgs e)
        {
            // Pobranie warto�ci z p�l tekstowych i zamiana na liczby ca�kowite
            int ocenaWF = int.Parse(wfInput.Text);
            int ocenaFiz = int.Parse(fizInput.Text);
            int ocenaChem = int.Parse(chemInput.Text);
            int ocenaGeo = int.Parse(geoInput.Text);

            // Obliczenie sumy ocen
            int suma = ocenaWF + ocenaFiz + ocenaChem + ocenaGeo;

            // Obliczenie �redniej ocen
            double srednia = (double)suma / 4;

            // Wy�wietlenie �redniej w oknie dialogowym
            MessageBox.Show(srednia.ToString());
        }

        // Obs�uga zdarzenia zmiany tekstu w polu wfInput
        private void wfInput_TextChanged(object sender, EventArgs e)
        {
            // Aktualnie pusta metoda - mo�na doda� walidacj� wej�cia
        }

        // Obs�uga zdarzenia klikni�cia etykiety label2
        private void label2_Click(object sender, EventArgs e)
        {
            // Aktualnie pusta metoda - mo�na doda� odpowiedni� logik�
        }
    }
}

