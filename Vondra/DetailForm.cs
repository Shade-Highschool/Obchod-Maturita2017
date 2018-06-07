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
    public partial class DetailForm : Form
    {
        public DetailForm(Reproduktor rep, string hlavicka)
        {
            InitializeComponent();

            string[] header = hlavicka.Split(';'); // vezmeme data z hlavičky
            foreach (string item in header)
            {
                dataGridView1.Columns.Add(item, item);
            } //vytvoříme columns
            string[] data = rep.ObjektNaCSVradek().Split(';');
            dataGridView1.Rows.Add(data); //přidáme řádky
        }
    }
}
