namespace TransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
            transport.GetStations("Luzern");
        }
    }
}