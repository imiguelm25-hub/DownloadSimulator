using System.Collections.Concurrent;

namespace Ariketa8
{
    public partial class Form1 : Form
    {

        //BlockingCollection atributua
        private BlockingCollection<Fitxategia> fitxategiak;

        public Form1()
        {
            InitializeComponent();

            // TextBox-a altua eta lerro anitzekoa izateko kode bidez:
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;


            //Hasieratu bilduma 
            fitxategiak = new BlockingCollection<Fitxategia>();

            fitxategiak.Add(new Fitxategia("Fitxategi 1", 100));
            fitxategiak.Add(new Fitxategia("Fitxategi 2", 200));
            fitxategiak.Add(new Fitxategia("Fitxategi 3", 80));
            fitxategiak.Add(new Fitxategia("Fitxategi 4", 250));
            fitxategiak.Add(new Fitxategia("Fitxategi 5", 180));
            fitxategiak.CompleteAdding();

        }

        private async void Hasi_DeskargaButton(object sender, EventArgs e)
        {

            Task t1 = DeskargatuFitxategiak(etiketa1, barra1, "Ataza 1");
            Task t2 = DeskargatuFitxategiak(etiketa2, barra2, "Ataza 2");


            await Task.WhenAll(t1, t2);           

        }

        private async Task DeskargatuFitxategiak (Label etiketaEgoera, ProgressBar barraEgoera, string tIzena)
        {
            //BlockingCollection-ko elementu bat hartzen du aplikazioa blokeatu gabe
            while (fitxategiak.TryTake(out Fitxategia fitx)) 
            {
                barraEgoera.Maximum = fitx.Tamaina;
                barraEgoera.Value = 0;

                for (int i = 0; i <= fitx.Tamaina; i += 10)
                {
                    await Task.Delay(200);

                    etiketaEgoera.Text = $"{fitx.Izena}: ({i}MB/{fitx.Tamaina}MB)";
                    barraEgoera.Value = i;

                }

                textBox1.AppendText($"{fitx.Izena} ({fitx.Tamaina} OK)\r\n");
            }
        }   
    }
}
