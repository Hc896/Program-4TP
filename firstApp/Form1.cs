namespace firstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ocenaWF = int.Parse(wfInput.Text);
            int ocenaFiz = int.Parse(fizInput.Text);
            int ocenaChem = int.Parse(chemInput.Text);
            int ocenaGeo = int.Parse(geoInput.Text);

            int suma = ocenaWF + ocenaFiz + ocenaChem + ocenaGeo;
            double srednia = (double)suma / 4;

            MessageBox.Show(srednia.ToString());
         
        }

        private void wfInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
