using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CharpTest
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void button_task1_Click(object sender, EventArgs e)
        {
            Form1 c = new Form1();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
        private void button_task2_Click_1(object sender, EventArgs e)
        {
            Form2 c = new Form2();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
        private void button_task3_Click_1(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
    }
}