using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vondra
{
    class Reproduktor2 : Reproduktor
    {
        public override double Vykon
        {
            get
            {
                return fl + fr;
            }
            set { Vykon = value; }
        } //Vlastnost která vypočítá výkon

        public double fl;
        public double fr;
        public Reproduktor2(string[] data) : base(data)
        {
            double.TryParse(data[5], out fl);
            double.TryParse(data[6], out fr);
        }

        public override string ObjektNaCSVradek()
        {
            return vyrobce + ";" + nazev + ";" + typSoustavy + ";" + cena + ";" + bluetooth + ";" +
               fl + ";" + fr + ";;;;";
        }
    }
}
