using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektroMobil
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            if (progressBar1.Value >= 50)
            {

                timer1.Enabled = false;
                Voltacar vt = new Voltacar();
                vt.Show();
                this.Hide();
               
                
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

    }
}
