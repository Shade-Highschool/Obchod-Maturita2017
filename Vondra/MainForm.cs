using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

// Tomáš Vondra, 4TB   26.4.2017

namespace Vondra
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static List<Reproduktor> listReproduktoru = new List<Reproduktor>(); //Zde se budou ukládat všechny položky
        string hlavicka; //hlavicka v csv dokumentu

        private string ZapisStatistiku()
        {
            int bezdrat = listReproduktoru.Count(x => x.bluetooth == "ano"); // spočítá reproduktory s bluetooth
            Reproduktor maxVykon = listReproduktoru.Where(x => x.Vykon == listReproduktoru.Max(x2 => x2.Vykon)).First(); // vybere reproduktor s max výkonem
            Reproduktor nejCena = listReproduktoru.Where(x => x.CenaZaWatt() == listReproduktoru.Min(x2 => x2.CenaZaWatt())).First(); // vybere reproduktor s nejlepší cenou za watt

            string statistika = "Statistika" + Environment.NewLine;
            statistika += "Na skladě je celkem reproduktorů " + listReproduktoru.Count + ", z toho bezdrátových " + bezdrat + Environment.NewLine;
            statistika += "Největší výkon mají reproduktory od společnosti " + maxVykon.vyrobce + " nazvané " + maxVykon.nazev + Environment.NewLine;
            statistika += "Nejlepší cenu za jeden watt výkonu mají reproduktory od společnosti " + nejCena.vyrobce + " s názvem " + nejCena.nazev;
            return statistika; // naskládá do proměnný data a pošle

        } // tato metoda nám vrátí string proměnnou se statistikou
        private void ZobrazBezdratove()
        {
            List<Reproduktor> bezdrat = listReproduktoru.Where(x => x.bluetooth == "ano").ToList(); // vybere všechny reproduktory s bluetooth
            string zprava = "";

            foreach (Reproduktor item in bezdrat)
            {
                zprava += "Výrobce: " + item.vyrobce + "\t Název: " + item.nazev + Environment.NewLine;
            } // Od každého zařízení vezme data a vloží do zprávy
            MessageBox.Show(zprava);
        } //Tato metoda vypíše MBOX s bezdrát. reproduktory
        private void LoadCSV() 
        {
            using (StreamReader reader = new StreamReader("zbozi.csv", Encoding.Default))
            {
                hlavicka = reader.ReadLine(); //přečte hlavičku

                while(!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(';'); //získá data o reproduktoru

                    Reproduktor rep;
                   
                    if (line[2] == "2.0")
                        rep = new Reproduktor2(line);
                     else if (line[2] == "2.1")
                        rep = new Reproduktor21(line);
                    else
                        rep = new Reproduktor51(line); //zjistí, jakej typ a podle toho vytvoří instanci třídy

                    listReproduktoru.Add(rep); //uschová do listu
                }
            }
            UpdateView(); //Updatuje listbox
        } //Načte CSV
        private void UpdateView()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = listReproduktoru;
        } //Updatuje listbox
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCSV();
        }

        private void editovatProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) //Ověří, jestli je vybranej nějaký produkt
            {
                Reproduktor rep = (Reproduktor)listBox1.SelectedItem;
                EditForm form = new EditForm(rep); // vytvoří instanci a pošle jí do formo
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateView(); // update listbox
                }
            }
            else
                MessageBox.Show("Vyberte produkt!");
        } //Edit reproduktoru

        private void vytvořitNovýProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm(); // otevře edit formu
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateView(); //update listbox
            }
        } //Nový produkt

        private void smazatProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null) // Zjistí, jestli je vybranej reproduktor
            {
                listReproduktoru.Remove((Reproduktor)listBox1.SelectedItem);
                UpdateView(); // Odstraní z listu a update listbox
            }
            else
                MessageBox.Show("Vyberte produkt!");
        } //Smazat produkt

        private void zobrazDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem !=null) //Ověří, zda je vybrát produkt
            {
                DetailForm form = new DetailForm((Reproduktor)listBox1.SelectedItem, hlavicka);
                form.Show(); // pošle ho do detail formy + hlavičku csv
            }
            else
                MessageBox.Show("Vyberte produkt!");
        } //Detail

        private void zobrazBezdrátovéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZobrazBezdratove();
        } //Zavolá metodu ZobrazBezdratove

        private void zobrazNejlevnějšíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Reproduktor> rep2_list = listReproduktoru.Where(x => x.typSoustavy == "2.0").ToList();
            List<Reproduktor> rep21_list = listReproduktoru.Where(x => x.typSoustavy == "2.1").ToList();
            List<Reproduktor> rep51_list = listReproduktoru.Where(x => x.typSoustavy == "5.1").ToList();

            //Vytvoří list s příslušným typem soustavy

            Reproduktor rep2 = rep2_list.Where(x => x.cena == rep2_list.Min(x2 => x2.cena)).First();
            Reproduktor rep21 = rep21_list.Where(x => x.cena == rep21_list.Min(x2 => x2.cena)).First();
            Reproduktor rep51 = rep51_list.Where(x => x.cena == rep51_list.Min(x2 => x2.cena)).First();

            // z příslušnýho typu soustavy zobrazí nejlevnější. Asi by to šlo pouze do tří řádků, ale takovej machr nejsem. Power of linq

            MessageBox.Show("Reproduktor 2.0: " + rep2.vyrobce + "\t" + rep2.nazev + Environment.NewLine +
                            "Reproduktor 2.1: " + rep21.vyrobce + "\t" + rep21.nazev + Environment.NewLine +
                            "Reproduktor 5.1: " + rep51.vyrobce + "\t" + rep51.nazev); //Vypíše

        } //Zobraz nejlevnější

        private void cenaZaWattToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null) //Pokud byl vybrát reproduktor
            {
                Reproduktor rep = (Reproduktor)listBox1.SelectedItem;
                MessageBox.Show("Jeden watt stojí: " + rep.CenaZaWatt().ToString()); //Zavolá metodu která vypočítá cenu za watt a zobrazí
            }
        } //Zavolá metodu CenaZaWatt

        private void uložDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = ".txt | *.txt";
            dialog.FileName = "data.txt"; //nastaví filter na txt a defaultní jméno data

            if(dialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter writer = new StreamWriter(dialog.FileName, false, Encoding.Default))
                {
                    foreach (Reproduktor item in listReproduktoru)
                    {
                        writer.WriteLine(item.InformaceOZbozi());
                    } //projede všechny reproduktory a vypíše jejich informace
                    writer.WriteLine();
                    writer.WriteLine(ZapisStatistiku()); //Vypíše statistiku
                }
            }
        } //Uloží data

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("zbozi.csv", false, Encoding.Default))
            {
                writer.WriteLine(hlavicka);

                foreach (Reproduktor item in listReproduktoru)
                {
                    writer.WriteLine(item.ObjektNaCSVradek());
                }
            }
        } //Uložení zboží
    }
}
