using System.Xml;

namespace Lista_filmow1
{
    public partial class Filmy : Form
    {
        public Filmy()
        {
            InitializeComponent();
        }


        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Dodawanie_Click(string tytul, string rezyser, string data, string aktor)
        {
            ListViewItem item = new ListViewItem(new[] { tytul, rezyser, data });
            listView1.Items.Add(item);
        }

        private void Dodawanie_Click(string[] dane)
        {
            ListViewItem item = new ListViewItem(dane);
            listView1.Items.Add(item);
        }

        private void Dodawanie_Click(object sender, EventArgs e)
        {
            Dodawanie_Click(textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text);
        }

        private void Zamykanie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Filmy_Load(object sender, EventArgs e)
        {

        }

        private void Usuñ_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            } 
        }

        private string[] WierszeDoPliku()
        {
            string[] linie = new string[listView1.Items.Count];
            int i = 0; 
            foreach (ListViewItem item in listView1.Items)
            {
                linie[i] = "";
                for (int k = 0; k < item.SubItems.Count; k++)
                {
                    linie[i] += item.SubItems[k].Text + "*";
                    i++;
                }
                return linie;
            }
        }

        private void Zapisywanie_Click(object sender, EventArgs e)
        {
            string[] linie = WierszeDoPliku();

            File.WriteAllLines("filmy.txt", linie);
        }
    }
}