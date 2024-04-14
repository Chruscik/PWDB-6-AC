namespace PWDB_6_AC
{
    public partial class Form1 : Form
    {
        public int X = 0; 
        public int Y = 0;   
        public int dydelfy = 0;
        public int krokodyle = 0;
        public int czas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//start
        {
            Form2 frm2 = new Form2(this);
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)//ustawienia
        {
            Form3 frm3 = new Form3(this);
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)//koniec
        {
            Close();
        }
    }
}
