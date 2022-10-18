using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightYourBrain
{
    public partial class EndScore : Form
    {
        public EndScore()
        {
            InitializeComponent();
        }

        private void EndScore_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataScoreDataSet.Table' . Możesz go przenieść lub usunąć.
            this.tableTableAdapter.Fill(this.dataScoreDataSet.Table);

        }
    }
}
