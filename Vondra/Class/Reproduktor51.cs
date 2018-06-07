using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vondra
{
    class Reproduktor51 : Reproduktor
    {
        public override double Vykon
        {
            get
            {
                return fl + fr + subwoofer + rl + rr + center;
            }
            set { Vykon = value; }
        } //Vlastnost která vypočítá výkon

        public double fl;
        public double fr;
        public double subwoofer;
        public double rl;
        public double rr;
        public double center;
        public Reproduktor51(string[] data) : base(data)
        {
            double.TryParse(data[5], out fl);
            double.TryParse(data[6], out fr);
            double.TryParse(data[7], out subwoofer);
            double.TryParse(data[8], out rl);
            double.TryParse(data[9], out rr);
            double.TryParse(data[10], out center);
        }

        public override string ObjektNaCSVradek()
        {
            return vyrobce + ";" + nazev + ";" + typSoustavy + ";" + cena + ";" + bluetooth + ";" +
               fl + ";" + fr + ";" + subwoofer + ";" + rl + ";" + rr + ";" + center;
        }
    }
}
