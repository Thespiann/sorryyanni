using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProj
{
    public partial class Form2 : Form
    { 
        Random loc = new Random();
        Random r= new Random();
        int dvdx, dvdy;
        string[] colors = { "LightBlue", "LightCoral", "LightGoldenrodYellow", "LightGreen", "LightSkyBlue", "LightPink" };
        int counter = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(loc.Next(Screen.PrimaryScreen.Bounds.Width - this.Width), loc.Next(Screen.PrimaryScreen.Bounds.Height - this.Height-100));
            dvdx = r.Next(0, 5);
            dvdy = r.Next(0, 5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + dvdx, this.Location.Y + dvdy);
            if (this.Location.X < 0 ||
                this.Location.X + this.Width > Screen.PrimaryScreen.Bounds.Width) {
                dvdx = -dvdx;
                counter++;
                this.BackColor = Color.FromName(colors[counter]);
                if (counter > 4) { counter = -1; }
                
            }
            if (this.Location.Y < 0 ||
               this.Location.Y + this.Height+100> Screen.PrimaryScreen.Bounds.Height)
            {
                dvdy = -dvdy;
                counter++;
                this.BackColor = Color.FromName(colors[counter]);
                if (counter > 4) { counter = -1; }

            }
            


        }
    }
}
