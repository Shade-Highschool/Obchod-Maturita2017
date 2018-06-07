using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vondra
{
    public partial class EditForm : Form
    {

        public EditForm()
        {
            InitializeComponent();
        }
        //Šetřeno podmínkami a tryparse. Nejjednoduší a nejlepší řešení. Díky tryparse program nikdy nespadne a díky podmínkám se stane co my chceme

        Reproduktor rep;
        bool is21 = false;
        bool is2 = false;
        public EditForm(Reproduktor rep)
        {
            InitializeComponent();
            this.rep = rep;

            comboBox1.SelectedIndex = comboBox1.FindStringExact(rep.typSoustavy); //zjistí typ soustavy, podle toho nastaví
            comboBox1.Enabled = false;
            if (comboBox1.SelectedIndex == 0)
            {
                txtFL.Text = (rep as Reproduktor2).fl.ToString();
                txtFR.Text = (rep as Reproduktor2).fr.ToString();
            } //pokud 2.0
            else if (comboBox1.SelectedIndex == 1)
            {
                txtFL.Text = (rep as Reproduktor21).fl.ToString();
                txtFR.Text = (rep as Reproduktor21).fr.ToString();
                txtSubwoofer.Text = (rep as Reproduktor21).subwoofer.ToString();
            } //pokud 2.1
            else
            {
                txtFL.Text = (rep as Reproduktor51).fl.ToString();
                txtFR.Text = (rep as Reproduktor51).fr.ToString();
                txtSubwoofer.Text = (rep as Reproduktor51).subwoofer.ToString();
                txtRL.Text = (rep as Reproduktor51).rl.ToString();
                txtRR.Text = (rep as Reproduktor51).rr.ToString();
                txtCenter.Text = (rep as Reproduktor51).center.ToString();
            } //pokud 5.1

            txtVyrobce.Text = rep.vyrobce;
            txtNazev.Text = rep.nazev;
            txtCena.Text = rep.cena.ToString();
            comboBox2.SelectedIndex = comboBox2.FindStringExact(rep.bluetooth); //nastaví bluetooth


            btnCreate.Text = "Editovat";
            //Načte do textboxů a změní tlačítko, protože se bude editovat.
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (rep != null) //Pokud byl poslán reproduktor, bude se editovat. Jinak se vytváří nový
            {
                rep.vyrobce = txtVyrobce.Text;
                rep.nazev = txtNazev.Text;
                rep.typSoustavy = comboBox1.Text;
                int.TryParse(txtCena.Text, out rep.cena);
                rep.bluetooth = comboBox2.Text;

                if (is2)
                {
                    double.TryParse(txtFL.Text, out (rep as Reproduktor2).fl);
                    double.TryParse(txtFR.Text, out (rep as Reproduktor2).fr);
                }
                else if (is21)
                {
                    double.TryParse(txtFL.Text, out (rep as Reproduktor21).fl);
                    double.TryParse(txtFR.Text, out (rep as Reproduktor21).fr);
                    double.TryParse(txtSubwoofer.Text, out (rep as Reproduktor21).subwoofer);
                }
                else
                {
                    double.TryParse(txtFL.Text, out (rep as Reproduktor51).fl);
                    double.TryParse(txtFR.Text, out (rep as Reproduktor51).fr);
                    double.TryParse(txtSubwoofer.Text, out (rep as Reproduktor51).subwoofer);
                    double.TryParse(txtRL.Text, out (rep as Reproduktor51).rl);
                    double.TryParse(txtRR.Text, out (rep as Reproduktor51).rr);
                    double.TryParse(txtCenter.Text, out (rep as Reproduktor51).center);
                }
                DialogResult = DialogResult.OK;
                this.Close(); //OTROČINA
            }
            else
            {
                string line = txtVyrobce.Text + ";" + txtNazev.Text + ";" + comboBox1.Text + ";" +
                              txtCena.Text + ";" + comboBox2.Text + ";" + txtFL.Text + ";" +
                              txtFR.Text + ";" + txtSubwoofer.Text + ";" + txtRL.Text + ";" +
                              txtRR.Text + ";" + txtCenter.Text;
                // převedeme textbox data na csv řádku a pošleme jí do konstruktoru. OTROČINA

                string[] data = line.Split(';');

                Reproduktor newRep;
                if (data[2] == "2.1")
                    newRep = new Reproduktor21(data);
                else if (data[2] == "2.0")
                    newRep = new Reproduktor2(data);
                else
                    newRep = new Reproduktor51(data);

                MainForm.listReproduktoru.Add(newRep);
                DialogResult = DialogResult.OK;
                this.Close(); //Rozhodneme typ a vytvoříme
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSubwoofer.Enabled = true;
            txtRL.Enabled = true;
            txtRR.Enabled = true;
            txtCenter.Enabled = true;
            if (comboBox1.SelectedIndex == 0)
            {
                txtSubwoofer.Enabled = false;
                txtRL.Enabled = false;
                txtRR.Enabled = false;
                txtCenter.Enabled = false;
                is2 = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                txtRL.Enabled = false;
                txtRR.Enabled = false;
                txtCenter.Enabled = false;
                is21 = true;
            }
            else
            {

            }
        } //validace enabled textboxů
    }
}
