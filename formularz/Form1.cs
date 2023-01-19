using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

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
            
            dane.album1 = maskedTextBox1.Text;
            dane.album2 = maskedTextBox2.Text;
            dane.album3 = maskedTextBox5.Text;
            dane.album4 = maskedTextBox4.Text;
            
            dane.data1 = maskedTextBox3.Text;
            dane.data2 = maskedTextBox6.Text;
            dane.data3 = maskedTextBox7.Text;
            dane.data4 = maskedTextBox8.Text;
            
            dane.tytul = textBox15.Text;
            dane.angielski = textBox16.Text;
            dane.wejsciowe = textBox17.Text;
            dane.zakrespracy = textBox18.Text;
            dane.promotor = textBox19.Text;
            dane.jednostka = textBox20.Text;
            dane.datazatwierdzenia = maskedTextBox9.Text;

            XmlSerializer serial = new XmlSerializer(typeof(Data));

            var xml = "";

            using (var swriter = new StringWriter())
            {
                using(XmlWriter writer = new XmlTextWriter(swriter)) 
                {
                    serial.Serialize(writer, dane);
                    xml = swriter.ToString();
                }
            }

            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "XML Files (*.xml)|*.xml";
            saveFD.FilterIndex= 0;
            saveFD.DefaultExt = "xml";
            
            if(saveFD.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFD.FileName, xml);
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 0;
            openFileDialog.DefaultExt = "xml";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Data));
                System.IO.StreamReader load = new System.IO.StreamReader(openFileDialog.FileName);

                Data dane = (Data)reader.Deserialize(load);
                load.Close();

                comboBox1.Text = dane.karta;
                textBox1.Text = dane.kierunek;
                textBox2.Text = dane.zakres;
                comboBox2.Text = dane.profil;
                comboBox3.Text = dane.forma;
                comboBox4.Text = dane.poziom;

                textBox3.Text = dane.student1;
                textBox4.Text = dane.student2;
                textBox5.Text = dane.student3;
                textBox6.Text = dane.student4;

                maskedTextBox1.Text = dane.album1;
                maskedTextBox2.Text = dane.album2;
                maskedTextBox5.Text = dane.album3;
                maskedTextBox4.Text = dane.album4;

                maskedTextBox3.Text = dane.data1;
                maskedTextBox6.Text = dane.data2;
                maskedTextBox7.Text = dane.data3;
                maskedTextBox8.Text = dane.data4;

                textBox15.Text = dane.tytul;
                textBox16.Text = dane.angielski;
                textBox17.Text = dane.wejsciowe;
                textBox18.Text = dane.zakrespracy;
                textBox19.Text = dane.promotor;
                textBox20.Text = dane.jednostka;
                maskedTextBox9.Text = dane.datazatwierdzenia;

            }
        }
    }
}