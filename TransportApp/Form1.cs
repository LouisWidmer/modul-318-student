using SwissTransport.Core;
using SwissTransport.Models;

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
            gridAbfahrten.Rows.Clear();
            ITransport transport = new Transport();
            if (combVon.Text.Length >= 3)
            {
                DateTime dateTime;
                try
                {
                    string dateTimeString = datePicker.Value.ToString("yyyy-MM-dd ") + txtTime.Text;
                    dateTime = DateTime.Parse(dateTimeString);
                }
                catch (Exception)
                {
                    MessageBox.Show("ungültiges Datum");
                    return;
                }
                if (combNach.Text == "")
                {
                    StationBoardRoot stationBoardRoot;
                    stationBoardRoot = transport.GetStationBoard(combVon.Text, "0");
                    gridAbfahrten.Hide();
                    gridStationBoard.Show();
                    gridStationBoard.Rows.Clear();
                    for (int i = 0; i < stationBoardRoot.Entries.Count; i++)
                    {
                        string[] text = new string[3];
                        text[0] = stationBoardRoot.Station.Name;
                        text[1] = stationBoardRoot.Entries[i].To;
                        text[2] = stationBoardRoot.Entries[i].Stop.Departure.ToString();
                        gridStationBoard.Rows.Add(text);
                    }
                }
                else
                {
                    Connections connections = new Connections();
                    if (dateTime > DateTime.Now)
                    {
                        connections = transport.GetConnectionsWithTime(combVon.Text, combNach.Text, dateTime);
                    }
                    else
                    {
                        connections = transport.GetConnections(combVon.Text, combNach.Text);
                    }
                    gridStationBoard.Hide();
                    gridAbfahrten.Show();
                    for (int i = 0; i < connections.ConnectionList.Count; i++)
                    {
                        string[] text = new string[5];
                        text[0] = connections.ConnectionList[i].From.Platform;
                        text[1] = connections.ConnectionList[i].From.Departure.ToString();
                        text[2] = connections.ConnectionList[i].To.Arrival.ToString();
                        text[3] = Convert.ToString(connections.ConnectionList[i].To.Arrival - connections.ConnectionList[i].From.Departure);
                        text[4] = Convert.ToString(connections.ConnectionList[i].From.Delay);
                        gridAbfahrten.Rows.Add(text);
                    }
                }
            }
        }

        private void combVon_DropDown(object sender, EventArgs e)
        {
            if (combVon.Text.Length >= 3)
            {
                combVon.Items.Clear();
                combVon.Items.Add(combVon.Text);
                ITransport transport = new Transport();
                Stations stations = new Stations();
                stations = transport.GetStations(combVon.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    combVon.Items.Add(stations.StationList[i].Name);
                }
            }
        }

        private void combNach_DropDown(object sender, EventArgs e)
        {
            if (combNach.Text.Length >= 3)
            {
                combNach.Items.Clear();
                combNach.Items.Add(combNach.Text);
                ITransport transport = new Transport();
                Stations stations = new Stations();
                stations = transport.GetStations(combNach.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    combNach.Items.Add(stations.StationList[i].Name);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridAbfahrten.Show();
            gridStationBoard.Hide();
            datePicker.Text = DateTime.Now.ToString();
            txtTime.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}