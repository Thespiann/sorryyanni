using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProj
{
    public partial class Form1 : Form
    {
        private int dvdnum=0;
        public int num=0;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//Smooth animation
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
        //Animation
        bool currentlyAnimating = false;
        bool isAnimating = true;
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (isAnimating)
            {
                AnimateImage();
                ImageAnimator.UpdateFrames();
            }
            base.OnPaintBackground(e);
        }
        public void AnimateImage()
        {
            if (!currentlyAnimating)
            {
                ImageAnimator.Animate(this.BackgroundImage, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }
        private void OnFrameChanged(object o, EventArgs e)
        {
            this.Invalidate();
        }
        public void setdvdnum(int i) {
            dvdnum = i;        
        }
        public int getdvdnum() {
            return dvdnum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checknum();
            if (dvdnum !=0) {
                for (int i = 0; i < dvdnum; i++)
                {
                    new Form2().Show();
                }
                this.Hide();
            }
        }
        private void checknum() {
            if (Int32.TryParse(textBox1.Text, out num))
            {
                if (num <= 10 && num > 0) { setdvdnum(num); }
                else { MessageBox.Show("Incorrect number"); }
            }
            else { MessageBox.Show("Not a number"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
