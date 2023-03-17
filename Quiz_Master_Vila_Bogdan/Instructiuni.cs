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
    public partial class Instructiuni : Form
    {
        public Instructiuni()
        {
            InitializeComponent();
        }

        private void Instructiuni_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Generic f = new Generic();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
