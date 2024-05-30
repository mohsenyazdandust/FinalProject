namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Home home = new Home();

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text.ToString();
            if (password == "1234")
            {
                home.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Wrong Password!");
            }
        }
    }
}