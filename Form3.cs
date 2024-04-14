using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWDB_6_AC
{
    public partial class Form3 : Form
    {
        private Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)// textbook x
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)// textbooks y
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//dydelfy
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//krokodyle
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//czas
        {

        }

        private void button1_Click(object sender, EventArgs e)//zatwierdz
        {
            if (Int32.Parse(textBox2.Text) <= 10 && Int32.Parse(textBox1.Text) <= 10 && Int32.Parse(textBox3.Text) + Int32.Parse(textBox5.Text) <= Int32.Parse(textBox2.Text) * Int32.Parse(textBox1.Text) && Int32.Parse(textBox4.Text) > 0)
            {
                form1.X = Int32.Parse(textBox2.Text);
                form1.Y = Int32.Parse(textBox1.Text);
                form1.dydelfy = Int32.Parse(textBox3.Text);
                form1.krokodyle = Int32.Parse(textBox5.Text);
                form1.czas = Int32.Parse(textBox4.Text);
                Close();
            }
            else 
            {
                label7.Text = "Podano niepoprawne dane";
            }
        }
    }
}
