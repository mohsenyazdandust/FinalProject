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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        AddMember addMember = new AddMember();
        Members members = new Members();

        private void button1_Click(object sender, EventArgs e)
        {
            members.Show();
            members.TopMost = true;
        }

        // Log Out
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        // Add Member
        private void button2_Click(object sender, EventArgs e)
        {
            addMember.Show();
            addMember.TopMost = true;
        }
    }
}
