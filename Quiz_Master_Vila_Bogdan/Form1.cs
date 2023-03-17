using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Master_Vila_Bogdan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion

        #region .. code for Flickering ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Generic f = new Generic();
            this.Visible = false;
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Geografie f = new Geografie();
            this.Visible = false;
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Istorie g = new Istorie();
            this.Visible = false;
            g.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Turism h = new Turism();
            this.Visible = false;
            h.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Bio i = new Bio();
            this.Visible = false;
            i.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Arta j = new Arta();
            this.Visible = false;
            j.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Sport k = new Sport();
            this.Visible = false;
            k.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Auto l = new Auto();
            this.Visible = false;
            l.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Steaguri m = new Steaguri();
            this.Visible = false;
            m.ShowDialog();
        }
    }
}
