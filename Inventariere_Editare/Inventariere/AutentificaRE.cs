using System;
using System.Windows.Forms;

namespace Inventariere
{
    public partial class Autentificare : Form
    {
        SQL sqlComenzi = new SQL();

        public Autentificare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlComenzi.checkuser(textBox1.Text))
            {
                this.Hide();
                new Form1().Show();
            }
            else   
                MessageBox.Show("Nu exista asa utilizator !!!");
        }

        private void Autentificare_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
