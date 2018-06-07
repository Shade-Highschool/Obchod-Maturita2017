using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vondra
{
    public class Reproduktor
    {
        #region Variables
        public virtual double Vykon
        {
            get
            {
                return 0;
            }
            set { Vykon = value; }
        } //Vlastnost která vypočítá výkon

        public string vyrobce;
        public string nazev;
        public string typSoustavy;
        public int cena;
        public string bluetooth;
        #endregion

        public Reproduktor(string[] radekCSV)
        {
            
            vyrobce = radekCSV[0];
            nazev = radekCSV[1];
            typSoustavy = radekCSV[2];
            int.TryParse(radekCSV[3], out cena);
            bluetooth = radekCSV[4];
        } //z csv načte základ

        public virtual string ObjektNaCSVradek()
        {
            return vyrobce + ";" + nazev + ";" + typSoustavy + ";" + cena + ";" + bluetooth;
        } // vrátí zpátky do formátu csv.
        public double CenaZaWatt()
        {
            return cena / Vykon;
        } //Vypočítá cenu za watt
        public string InformaceOZbozi()
        {
            return "Reproduktor " + nazev + " od společnosti " + vyrobce + ", využívá typ soustavy " + typSoustavy +
                ", má celkový výkon " + Vykon + "W RMS a stojí " + cena + " Kč";
                ;
        } //Vratí informace ve formátu. Další otročina
        public override string ToString()
        {
            return "Výrobce: " + vyrobce + "\t Název: " + nazev + "\t" + cena + " Kč";
        } //Zobrazení v listboxu
    }
}
