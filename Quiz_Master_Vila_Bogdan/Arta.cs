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
    public partial class Arta : Form
    {
        public Arta()
        {
            InitializeComponent();
            label2.Visible = false;
            picture2.Visible = false;
            q2a1.Visible = false;
            q2a2.Visible = false;
            q2a3.Visible = false;
            q2a4.Visible = false;
            label3.Visible = false;
            picture3.Visible = false;
            q3a1.Visible = false;
            q3a2.Visible = false;
            q3a3.Visible = false;
            q3a4.Visible = false;
            label4.Visible = false;
            picture4.Visible = false;
            q4a1.Visible = false;
            q4a2.Visible = false;
            q4a3.Visible = false;
            q4a4.Visible = false;
            label5.Visible = false;
            picture5.Visible = false;
            q5a1.Visible = false;
            q5a2.Visible = false;
            q5a3.Visible = false;
            q5a4.Visible = false;
            label6.Visible = false;
            picture6.Visible = false;
            q6a1.Visible = false;
            q6a2.Visible = false;
            q6a3.Visible = false;
            q6a4.Visible = false;
            label7.Visible = false;
            picture7.Visible = false;
            q7a1.Visible = false;
            q7a2.Visible = false;
            q7a3.Visible = false;
            q7a4.Visible = false;
            label8.Visible = false;
            picture8.Visible = false;
            q8a1.Visible = false;
            q8a2.Visible = false;
            q8a3.Visible = false;
            q8a4.Visible = false;
            label9.Visible = false;
            picture9.Visible = false;
            q9a1.Visible = false;
            q9a2.Visible = false;
            q9a3.Visible = false;
            q9a4.Visible = false;
            label10.Visible = false;
            picture10.Visible = false;
            q10a1.Visible = false;
            q10a2.Visible = false;
            q10a3.Visible = false;
            q10a4.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
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

        int raspunsuri = 0;
        int corecte = 0;

        private void q1a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 1;
            if (raspunsuri == 1)
            {
                label1.Visible = false;
                picture1.Visible = false;
                q1a1.Visible = false;
                q1a2.Visible = false;
                q1a3.Visible = false;
                q1a4.Visible = false;
                label2.Visible = true;
                picture2.Visible = true;
                q2a1.Visible = true;
                q2a2.Visible = true;
                q2a3.Visible = true;
                q2a4.Visible = true;
            }
        }

        private void q1a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 1;
            corecte++;
            if (raspunsuri == 1)
            {
                label1.Visible = false;
                picture1.Visible = false;
                q1a1.Visible = false;
                q1a2.Visible = false;
                q1a3.Visible = false;
                q1a4.Visible = false;
                label2.Visible = true;
                picture2.Visible = true;
                q2a1.Visible = true;
                q2a2.Visible = true;
                q2a3.Visible = true;
                q2a4.Visible = true;
            }
        }

        private void q1a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 1;
            if (raspunsuri == 1)
            {
                label1.Visible = false;
                picture1.Visible = false;
                q1a1.Visible = false;
                q1a2.Visible = false;
                q1a3.Visible = false;
                q1a4.Visible = false;
                label2.Visible = true;
                picture2.Visible = true;
                q2a1.Visible = true;
                q2a2.Visible = true;
                q2a3.Visible = true;
                q2a4.Visible = true;
            }
        }

        private void q1a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 1;
            if (raspunsuri == 1)
            {
                label1.Visible = false;
                picture1.Visible = false;
                q1a1.Visible = false;
                q1a2.Visible = false;
                q1a3.Visible = false;
                q1a4.Visible = false;
                label2.Visible = true;
                picture2.Visible = true;
                q2a1.Visible = true;
                q2a2.Visible = true;
                q2a3.Visible = true;
                q2a4.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 g = new Form1();
            this.Visible = false;
            g.ShowDialog();
        }

        private void q2a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 2;
            if (raspunsuri == 2)
            {
                label2.Visible = false;
                picture2.Visible = false;
                q2a1.Visible = false;
                q2a2.Visible = false;
                q2a3.Visible = false;
                q2a4.Visible = false;
                label3.Visible = true;
                picture3.Visible = true;
                q3a1.Visible = true;
                q3a2.Visible = true;
                q3a3.Visible = true;
                q3a4.Visible = true;
            }
        }

        private void q2a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 2;
            if (raspunsuri == 2)
            {
                label2.Visible = false;
                picture2.Visible = false;
                q2a1.Visible = false;
                q2a2.Visible = false;
                q2a3.Visible = false;
                q2a4.Visible = false;
                label3.Visible = true;
                picture3.Visible = true;
                q3a1.Visible = true;
                q3a2.Visible = true;
                q3a3.Visible = true;
                q3a4.Visible = true;
            }
        }

        private void q2a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 2;
            corecte++;
            if (raspunsuri == 2)
            {
                label2.Visible = false;
                picture2.Visible = false;
                q2a1.Visible = false;
                q2a2.Visible = false;
                q2a3.Visible = false;
                q2a4.Visible = false;
                label3.Visible = true;
                picture3.Visible = true;
                q3a1.Visible = true;
                q3a2.Visible = true;
                q3a3.Visible = true;
                q3a4.Visible = true;
            }
        }

        private void q2a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 2;
            if (raspunsuri == 2)
            {
                label2.Visible = false;
                picture2.Visible = false;
                q2a1.Visible = false;
                q2a2.Visible = false;
                q2a3.Visible = false;
                q2a4.Visible = false;
                label3.Visible = true;
                picture3.Visible = true;
                q3a1.Visible = true;
                q3a2.Visible = true;
                q3a3.Visible = true;
                q3a4.Visible = true;
            }
        }

        private void q3a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 3;
            if (raspunsuri == 3)
            {
                label3.Visible = false;
                picture3.Visible = false;
                q3a1.Visible = false;
                q3a2.Visible = false;
                q3a3.Visible = false;
                q3a4.Visible = false;
                label4.Visible = true;
                picture4.Visible = true;
                q4a1.Visible = true;
                q4a2.Visible = true;
                q4a3.Visible = true;
                q4a4.Visible = true;
            }
        }

        private void q3a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 3;
            if (raspunsuri == 3)
            {
                label3.Visible = false;
                picture3.Visible = false;
                q3a1.Visible = false;
                q3a2.Visible = false;
                q3a3.Visible = false;
                q3a4.Visible = false;
                label4.Visible = true;
                picture4.Visible = true;
                q4a1.Visible = true;
                q4a2.Visible = true;
                q4a3.Visible = true;
                q4a4.Visible = true;
            }
        }

        private void q3a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 3;
            if (raspunsuri == 3)
            {
                label3.Visible = false;
                picture3.Visible = false;
                q3a1.Visible = false;
                q3a2.Visible = false;
                q3a3.Visible = false;
                q3a4.Visible = false;
                label4.Visible = true;
                picture4.Visible = true;
                q4a1.Visible = true;
                q4a2.Visible = true;
                q4a3.Visible = true;
                q4a4.Visible = true;
            }
        }

        private void q3a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 3;
            corecte++;
            if (raspunsuri == 3)
            {
                label3.Visible = false;
                picture3.Visible = false;
                q3a1.Visible = false;
                q3a2.Visible = false;
                q3a3.Visible = false;
                q3a4.Visible = false;
                label4.Visible = true;
                picture4.Visible = true;
                q4a1.Visible = true;
                q4a2.Visible = true;
                q4a3.Visible = true;
                q4a4.Visible = true;
            }
        }

        private void q4a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 4;
            if (raspunsuri == 4)
            {
                label4.Visible = false;
                picture4.Visible = false;
                q4a1.Visible = false;
                q4a2.Visible = false;
                q4a3.Visible = false;
                q4a4.Visible = false;
                label5.Visible = true;
                picture5.Visible = true;
                q5a1.Visible = true;
                q5a2.Visible = true;
                q5a3.Visible = true;
                q5a4.Visible = true;
            }
        }

        private void q4a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 4;
            corecte++;
            if (raspunsuri == 4)
            {
                label4.Visible = false;
                picture4.Visible = false;
                q4a1.Visible = false;
                q4a2.Visible = false;
                q4a3.Visible = false;
                q4a4.Visible = false;
                label5.Visible = true;
                picture5.Visible = true;
                q5a1.Visible = true;
                q5a2.Visible = true;
                q5a3.Visible = true;
                q5a4.Visible = true;
            }
        }

        private void q4a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 4;
            if (raspunsuri == 4)
            {
                label4.Visible = false;
                picture4.Visible = false;
                q4a1.Visible = false;
                q4a2.Visible = false;
                q4a3.Visible = false;
                q4a4.Visible = false;
                label5.Visible = true;
                picture5.Visible = true;
                q5a1.Visible = true;
                q5a2.Visible = true;
                q5a3.Visible = true;
                q5a4.Visible = true;
            }
        }

        private void q4a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 4;
            if (raspunsuri == 4)
            {
                label4.Visible = false;
                picture4.Visible = false;
                q4a1.Visible = false;
                q4a2.Visible = false;
                q4a3.Visible = false;
                q4a4.Visible = false;
                label5.Visible = true;
                picture5.Visible = true;
                q5a1.Visible = true;
                q5a2.Visible = true;
                q5a3.Visible = true;
                q5a4.Visible = true;
            }
        }

        private void q5a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 5;
            corecte++;
            if (raspunsuri == 5)
            {
                label5.Visible = false;
                picture5.Visible = false;
                q5a1.Visible = false;
                q5a2.Visible = false;
                q5a3.Visible = false;
                q5a4.Visible = false;
                label6.Visible = true;
                picture6.Visible = true;
                q6a1.Visible = true;
                q6a2.Visible = true;
                q6a3.Visible = true;
                q6a4.Visible = true;
            }
        }

        private void q5a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 5;
            if (raspunsuri == 5)
            {
                label5.Visible = false;
                picture5.Visible = false;
                q5a1.Visible = false;
                q5a2.Visible = false;
                q5a3.Visible = false;
                q5a4.Visible = false;
                label6.Visible = true;
                picture6.Visible = true;
                q6a1.Visible = true;
                q6a2.Visible = true;
                q6a3.Visible = true;
                q6a4.Visible = true;
            }
        }

        private void q5a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 5;
            if (raspunsuri == 5)
            {
                label5.Visible = false;
                picture5.Visible = false;
                q5a1.Visible = false;
                q5a2.Visible = false;
                q5a3.Visible = false;
                q5a4.Visible = false;
                label6.Visible = true;
                picture6.Visible = true;
                q6a1.Visible = true;
                q6a2.Visible = true;
                q6a3.Visible = true;
                q6a4.Visible = true;
            }
        }

        private void q5a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 5;
            if (raspunsuri == 5)
            {
                label5.Visible = false;
                picture5.Visible = false;
                q5a1.Visible = false;
                q5a2.Visible = false;
                q5a3.Visible = false;
                q5a4.Visible = false;
                label6.Visible = true;
                picture6.Visible = true;
                q6a1.Visible = true;
                q6a2.Visible = true;
                q6a3.Visible = true;
                q6a4.Visible = true;
            }
        }

        private void q6a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 6;
            if (raspunsuri == 6)
            {
                label6.Visible = false;
                picture6.Visible = false;
                q6a1.Visible = false;
                q6a2.Visible = false;
                q6a3.Visible = false;
                q6a4.Visible = false;
                label7.Visible = true;
                picture7.Visible = true;
                q7a1.Visible = true;
                q7a2.Visible = true;
                q7a3.Visible = true;
                q7a4.Visible = true;
            }
        }

        private void q6a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 6;
            if (raspunsuri == 6)
            {
                label6.Visible = false;
                picture6.Visible = false;
                q6a1.Visible = false;
                q6a2.Visible = false;
                q6a3.Visible = false;
                q6a4.Visible = false;
                label7.Visible = true;
                picture7.Visible = true;
                q7a1.Visible = true;
                q7a2.Visible = true;
                q7a3.Visible = true;
                q7a4.Visible = true;
            }
        }

        private void q6a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 6;
            corecte++;
            if (raspunsuri == 6)
            {
                label6.Visible = false;
                picture6.Visible = false;
                q6a1.Visible = false;
                q6a2.Visible = false;
                q6a3.Visible = false;
                q6a4.Visible = false;
                label7.Visible = true;
                picture7.Visible = true;
                q7a1.Visible = true;
                q7a2.Visible = true;
                q7a3.Visible = true;
                q7a4.Visible = true;
            }
        }

        private void q6a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 6;
            if (raspunsuri == 6)
            {
                label6.Visible = false;
                picture6.Visible = false;
                q6a1.Visible = false;
                q6a2.Visible = false;
                q6a3.Visible = false;
                q6a4.Visible = false;
                label7.Visible = true;
                picture7.Visible = true;
                q7a1.Visible = true;
                q7a2.Visible = true;
                q7a3.Visible = true;
                q7a4.Visible = true;
            }
        }

        private void q7a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 7;
            if (raspunsuri == 7)
            {
                label7.Visible = false;
                picture7.Visible = false;
                q7a1.Visible = false;
                q7a2.Visible = false;
                q7a3.Visible = false;
                q7a4.Visible = false;
                label8.Visible = true;
                picture8.Visible = true;
                q8a1.Visible = true;
                q8a2.Visible = true;
                q8a3.Visible = true;
                q8a4.Visible = true;
            }
        }

        private void q7a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 7;
            corecte++;
            if (raspunsuri == 7)
            {
                label7.Visible = false;
                picture7.Visible = false;
                q7a1.Visible = false;
                q7a2.Visible = false;
                q7a3.Visible = false;
                q7a4.Visible = false;
                label8.Visible = true;
                picture8.Visible = true;
                q8a1.Visible = true;
                q8a2.Visible = true;
                q8a3.Visible = true;
                q8a4.Visible = true;
            }
        }

        private void q7a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 7;
            if (raspunsuri == 7)
            {
                label7.Visible = false;
                picture7.Visible = false;
                q7a1.Visible = false;
                q7a2.Visible = false;
                q7a3.Visible = false;
                q7a4.Visible = false;
                label8.Visible = true;
                picture8.Visible = true;
                q8a1.Visible = true;
                q8a2.Visible = true;
                q8a3.Visible = true;
                q8a4.Visible = true;
            }
        }

        private void q7a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 7;
            if (raspunsuri == 7)
            {
                label7.Visible = false;
                picture7.Visible = false;
                q7a1.Visible = false;
                q7a2.Visible = false;
                q7a3.Visible = false;
                q7a4.Visible = false;
                label8.Visible = true;
                picture8.Visible = true;
                q8a1.Visible = true;
                q8a2.Visible = true;
                q8a3.Visible = true;
                q8a4.Visible = true;
            }
        }

        private void q8a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 8;
            corecte++;
            if (raspunsuri == 8)
            {
                label8.Visible = false;
                picture8.Visible = false;
                q8a1.Visible = false;
                q8a2.Visible = false;
                q8a3.Visible = false;
                q8a4.Visible = false;
                label9.Visible = true;
                picture9.Visible = true;
                q9a1.Visible = true;
                q9a2.Visible = true;
                q9a3.Visible = true;
                q9a4.Visible = true;
            }
        }

        private void q8a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 8;
            if (raspunsuri == 8)
            {
                label8.Visible = false;
                picture8.Visible = false;
                q8a1.Visible = false;
                q8a2.Visible = false;
                q8a3.Visible = false;
                q8a4.Visible = false;
                label9.Visible = true;
                picture9.Visible = true;
                q9a1.Visible = true;
                q9a2.Visible = true;
                q9a3.Visible = true;
                q9a4.Visible = true;
            }
        }

        private void q8a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 8;
            if (raspunsuri == 8)
            {
                label8.Visible = false;
                picture8.Visible = false;
                q8a1.Visible = false;
                q8a2.Visible = false;
                q8a3.Visible = false;
                q8a4.Visible = false;
                label9.Visible = true;
                picture9.Visible = true;
                q9a1.Visible = true;
                q9a2.Visible = true;
                q9a3.Visible = true;
                q9a4.Visible = true;
            }
        }

        private void q8a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 8;
            if (raspunsuri == 8)
            {
                label8.Visible = false;
                picture8.Visible = false;
                q8a1.Visible = false;
                q8a2.Visible = false;
                q8a3.Visible = false;
                q8a4.Visible = false;
                label9.Visible = true;
                picture9.Visible = true;
                q9a1.Visible = true;
                q9a2.Visible = true;
                q9a3.Visible = true;
                q9a4.Visible = true;
            }
        }

        private void q9a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 9;
            if (raspunsuri == 9)
            {
                label9.Visible = false;
                picture9.Visible = false;
                q9a1.Visible = false;
                q9a2.Visible = false;
                q9a3.Visible = false;
                q9a4.Visible = false;
                label10.Visible = true;
                picture10.Visible = true;
                q10a1.Visible = true;
                q10a2.Visible = true;
                q10a3.Visible = true;
                q10a4.Visible = true;
            }
        }

        private void q9a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 9;
            if (raspunsuri == 9)
            {
                label9.Visible = false;
                picture9.Visible = false;
                q9a1.Visible = false;
                q9a2.Visible = false;
                q9a3.Visible = false;
                q9a4.Visible = false;
                label10.Visible = true;
                picture10.Visible = true;
                q10a1.Visible = true;
                q10a2.Visible = true;
                q10a3.Visible = true;
                q10a4.Visible = true;
            }
        }

        private void q9a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 9;
            corecte++;
            if (raspunsuri == 9)
            {
                label9.Visible = false;
                picture9.Visible = false;
                q9a1.Visible = false;
                q9a2.Visible = false;
                q9a3.Visible = false;
                q9a4.Visible = false;
                label10.Visible = true;
                picture10.Visible = true;
                q10a1.Visible = true;
                q10a2.Visible = true;
                q10a3.Visible = true;
                q10a4.Visible = true;
            }
        }

        private void q9a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 9;
            if (raspunsuri == 9)
            {
                label9.Visible = false;
                picture9.Visible = false;
                q9a1.Visible = false;
                q9a2.Visible = false;
                q9a3.Visible = false;
                q9a4.Visible = false;
                label10.Visible = true;
                picture10.Visible = true;
                q10a1.Visible = true;
                q10a2.Visible = true;
                q10a3.Visible = true;
                q10a4.Visible = true;
            }
        }

        private void q10a1_Click(object sender, EventArgs e)
        {
            raspunsuri = 10;
            label10.Visible = false;
            picture10.Visible = false;
            q10a1.Visible = false;
            q10a2.Visible = false;
            q10a3.Visible = false;
            q10a4.Visible = false;
            label13.Text = Convert.ToString(corecte);
            label11.Visible = true;
            label13.Visible = true;
        }

        private void q10a2_Click(object sender, EventArgs e)
        {
            raspunsuri = 10;
            label10.Visible = false;
            picture10.Visible = false;
            q10a1.Visible = false;
            q10a2.Visible = false;
            q10a3.Visible = false;
            q10a4.Visible = false;
            label13.Text = Convert.ToString(corecte);
            label11.Visible = true;
            label13.Visible = true;
        }

        private void q10a3_Click(object sender, EventArgs e)
        {
            raspunsuri = 10;
            label10.Visible = false;
            picture10.Visible = false;
            q10a1.Visible = false;
            q10a2.Visible = false;
            q10a3.Visible = false;
            q10a4.Visible = false;
            label13.Text = Convert.ToString(corecte);
            label11.Visible = true;
            label13.Visible = true;
        }

        private void q10a4_Click(object sender, EventArgs e)
        {
            raspunsuri = 10;
            corecte++;
            label10.Visible = false;
            picture10.Visible = false;
            q10a1.Visible = false;
            q10a2.Visible = false;
            q10a3.Visible = false;
            q10a4.Visible = false;
            label13.Text = Convert.ToString(corecte);
            label11.Visible = true;
            label13.Visible = true;
        }
    }
}
