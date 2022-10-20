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
    public partial class LightYourBrain_mainForm : Form
    {
        public LightYourBrain_mainForm()
        {
            InitializeComponent();
        }
        
        public void DisplayForm(object Form)
        {
            if (this.showWindows.Controls.Count > 0)
                this.showWindows.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.showWindows.Controls.Add(f);
            this.showWindows.Tag = f;
            f.Show();
        }
        
        private void StartGame(object sender, MouseEventArgs e)
        {
           DisplayForm(new QuestionsForm_main());
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            DisplayForm(new EndScore());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
