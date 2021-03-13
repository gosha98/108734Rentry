using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _108734Rentry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "დრო";
            label2.Text = "ტიპი";
            label3.Text = "დასახელება";
            label4.Text = "ლექტორი";
            label5.Text = "Zoom ID";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
            linkLabel1.Enabled = false;


            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            char z1 = textBox5.Text[0];
            char z2 = textBox5.Text[1];
            char z3 = textBox5.Text[2];
            char z4 = textBox5.Text[4];
            char z5 = textBox5.Text[5];
            char z6 = textBox5.Text[6];
            char z7 = textBox5.Text[8];
            char z8 = textBox5.Text[9];
            char z9 = textBox5.Text[10];
            char z10 = textBox5.Text[11];

            string zid = z1.ToString() + z2.ToString() + z3.ToString() + z4.ToString() + z5.ToString() + z6.ToString() + z7.ToString() + z8.ToString() + z9.ToString() + z10.ToString();


            string divider = @" |";
            string time = textBox1.Text + divider;
            string time2h = textBox1.Text + @"`2სთ`" + divider;
            string type = @"*" + textBox2.Text + @"*" + divider;
            string title = textBox3.Text + divider;
            string lecture = textBox4.Text + divider;
            string zoomid = textBox5.Text + divider;
            string joinzoom = @"[Join Zoom](https://zoom.us/j/" + zid + @")";

            string n = richTextBox1.Text + "\n";

           

            if (checkBox1.Checked)
            {
                richTextBox1.Text = n + time2h + type + title + lecture + zoomid + joinzoom;
                
            }
            else
            {
                richTextBox1.Text = n + time + type + title + lecture + zoomid + joinzoom;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fromscratch = @"დრო | ტიპი | დასახელება | ლექტორი | Zoom ID | JoinZoom" + "\n" + @"--|--|--|--|--|--";
            richTextBox1.Text = fromscratch;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            checkBox1.Checked = false;
            checkBox1.Enabled = true;
            linkLabel1.Enabled = true;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }
    }
}
