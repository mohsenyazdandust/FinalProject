namespace FinalProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Members
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.membersPage.Show();
            } catch (Exception ex) { 
                Form1.membersPage = new Members();
                Form1.membersPage.Show();
            }
            Form1.membersPage.TopMost = true;
            Form1.membersPage.TopMost = false;
        }

        // Log Out
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add Member
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.addMemberPage.Show();
            }
            catch (Exception ex)
            {
                Form1.addMemberPage = new AddMember();
                Form1.addMemberPage.Show();
            }

            Form1.addMemberPage.TopMost = true;
            Form1.addMemberPage.TopMost = false;
        }

    }
}
