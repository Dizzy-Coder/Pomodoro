using System.ComponentModel;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string duration = textBox1.Text;
            string brk = textBox2.Text;
            string sess = textBox3.Text;

            this.Hide();
            Form2 f2 = new Form2(sess.ToString(), brk.ToString(), duration.ToString());
            f2.Show();
          
        }
        
    }
}
