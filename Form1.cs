namespace Form2
{
    public partial class Form1 : Form
    {
        private string name = string.Empty;
        private DateTime dateTime;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Легенда - {name}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"Время сейчас {DateTime.Now} ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Дата рождения - {dateTime}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button2_Click(sender, e);
            button3_Click(sender, e);
            button4_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTime = dateTimePicker1.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("пасхалка");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = progressBar1.Minimum + i;
                System.Threading.Thread.Sleep(100);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Scroll += trackBar1_Scroll;
        }
    }
}