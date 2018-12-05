using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
        int mov;
        int movx;
        int movy;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="User Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text=="User Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor=Color.DarkBlue;
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.sub_2_1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
           pictureBox2.Image = Resources.Sub_1_1;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.cancel__1_;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.cancel__2_;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Form2 op = new Form2();
            op.Show();
            Visible = false;
        }
    }
}
