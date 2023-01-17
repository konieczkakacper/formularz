using System.Windows.Forms;

namespace formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Data
        {
            public string karta { get; set; }
            public string kierunek { get; set; }
            public string zakres { get; set; }
            public string profil { get; set; }
            public string forma { get; set; }
            public string poziom { get; set; }
            public string student1 { get; set; }
            public string student2 { get; set; }
            public string student3 { get; set; }
            public string student4 { get; set; }
            public string album1 { get; set; }
            public string album2 { get; set; }
            public string album3 { get; set; }
            public string album4 { get; set; }
            public string data1 { get; set; }
            public string data2 { get; set; }
            public string data3 { get; set; }
            public string data4 { get; set; }
            public string tytul { get; set; }
            public string angielski{ get; set; }
            public string wejsciowe { get; set; }
            public string zakrespracy { get; set; }
            public string promotor { get; set; }
            public string jednostka { get; set; }
            public string datazatwierdzenia { get; set; }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Data dane = new Data();
            dane.karta = comboBox1.Text;
            dane.kierunek = textBox1.Text;
            dane.zakres = textBox2.Text;
            dane.profil = comboBox2.Text;
            dane.forma = comboBox3.Text;
            dane.poziom = comboBox4.Text;
            dane.student1 = textBox3.Text;
            dane.student2 = textBox4.Text;
            dane.student3 = textBox5.Text;
            dane.student4 = textBox6.Text;
            //zmienic na masked
            dane.album1 = maskedTextBox1.Text;
            dane.album2 = 
            dane.album3 = 
            dane.album4 = 
            dane.data1 = 
            dane.data2 = 
            dane.data3 = 
            dane.data4 = 
            dane.tytul = textBox15.Text;
            dane.angielski = textBox16.Text;
            dane.wejsciowe = textBox17.Text;
            dane.zakrespracy = textBox18.Text;
            dane.promotor = textBox19.Text;
            dane.jednostka = textBox20.Text;
            //zmienic na masked
            dane.datazatwierdzenia = 
        }

        private void button_load_Click(object sender, EventArgs e)
        {

        }
    }
}