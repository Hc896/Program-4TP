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

            MessageBox.Show(ocenaWF.ToString());
            MessageBox.Show(ocenaFiz.ToString());
        }
    }
}
