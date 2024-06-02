using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = textBox1.Text.ToString();
            string phone = textBox2.Text.ToString();
            string age = numericUpDown2.Value.ToString();
            string paid = numericUpDown1.Value.ToString();

            // TO-Do: Validate

            DBHandler.ExecuteNonQuery($"INSERT INTO Member (fullname, phone, age, paid) VALUES ('{fullname}', '{phone}', {age}, {paid})");
            MessageBox.Show("DONE!");
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void AddMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            // this.Hide();
        }
    }
}
