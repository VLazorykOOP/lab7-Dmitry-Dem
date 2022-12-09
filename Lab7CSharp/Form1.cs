namespace Lab7CharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += $"{textBox1.Text} - operation time = {DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}\n";
        }
        private void button_task1_Click(object sender, EventArgs e)
        {
            MainMenu c = new MainMenu();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
    }
}